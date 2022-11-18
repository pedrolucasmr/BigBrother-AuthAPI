namespace AuthApiPoc.Business.Models
{
    public class TemporaryUser
    {
        public Guid Id { get; set; }
        public User User { get; set; }

        public string OTP { get; set; }
    }
}
