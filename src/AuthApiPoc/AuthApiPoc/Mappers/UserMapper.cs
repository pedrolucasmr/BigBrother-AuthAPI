using AuthApiPoc.DTOs.Request;
using AuthApiPoc.Models;
using AutoMapper;

namespace AuthApiPoc.Mappers
{
    public static class UserMapper
    {
        public static IMapper SetupTemporaryUserMapper()
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<CreateRegistrationRequest, TemporaryUser>();
            });

            return new Mapper(config);
        }
        public static TemporaryUser MapTemporaryUserFromRequest(CreateRegistrationRequest request)
        {
            var _mapper = SetupTemporaryUserMapper();

            var result = _mapper.Map<TemporaryUser>(request);

            result.User.Password = null;

            return result;
        }
    }
}
