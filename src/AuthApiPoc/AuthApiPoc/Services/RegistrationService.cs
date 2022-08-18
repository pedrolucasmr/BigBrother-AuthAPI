using AuthApiPoc.DTOs.Request;
using AuthApiPoc.Mappers;
using AuthApiPoc.Models;
using AuthApiPoc.Models.Enums;
using AuthApiPoc.Repositories.Interfaces;
using AuthApiPoc.Services.Interfaces;
using System.Security.Cryptography;

namespace AuthApiPoc.Services
{
    public class RegistrationService : IRegistrationService
    {
        private readonly IUserRepository _userRepository;
        private readonly ITemporaryUserRepository _temporaryUserRepository;
        private readonly IOtpRepository _otpRepository;

        public RegistrationService(IUserRepository userRepository, ITemporaryUserRepository temporaryUserRepository, IOtpRepository otpRepository)
        {
            _userRepository = userRepository;
            _temporaryUserRepository = temporaryUserRepository;
            _otpRepository = otpRepository;
        }

        public async Task<ErrorCode?> ProcessRegistration(CreateRegistrationRequest request)
        {
            if (_userRepository.GetUserByEmail(request.Email) is not null || _temporaryUserRepository.GetTemporaryUserByEmail(request.Email) is not null)
                return ErrorCode.UserAlreadyExists;


            var temporaryUser = UserMapper.MapTemporaryUserFromRequest(request);

            temporaryUser.User.Password = GeneratePasswordHashAndSalt(request.Password);

            var otp = GenerateOtpCode(temporaryUser.Id.ToString());

            temporaryUser.OTP = otp;

            var isInsertSuccessfull = await _temporaryUserRepository.InsertTemporaryUser(temporaryUser);

            if (!isInsertSuccessfull)
                return ErrorCode.InternalServerError;

            return null;
        }

        public Task<ErrorCode?> CompleteRegistration(CompleteRegistrationRequest request)
        {
            throw new NotImplementedException();
        }

        private Password GeneratePasswordHashAndSalt(string password)
        {
            var salt = GenerateSalt();
            var hashedPassword = new Password();
            hashedPassword.Salt = Convert.ToBase64String(salt);
            using(var hmac = new System.Security.Cryptography.HMACSHA512())
            {
                password = password + salt;
                var hash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));

                hashedPassword.EncryptedPassword = Convert.ToBase64String(hash);
            }

            return hashedPassword;
        }

        private byte[] GenerateSalt()
        {
            var salt = RandomNumberGenerator.GetBytes(128);
            return salt;
        }

        private string GenerateOtpCode(string userId)
        {
            var rng = new Random();
            var code = rng.Next(999999).ToString();
            var otp = new Otp(DateTime.UtcNow, code, userId);
            
            _otpRepository.InsertAsync(otp);

            return otp.Id;
        }
    }
}
