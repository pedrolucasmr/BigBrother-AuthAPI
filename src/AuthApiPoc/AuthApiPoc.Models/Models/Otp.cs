namespace AuthApiPoc.Models.Models
{
    public class Otp
    {
        public Otp()
        {

        }

        public Otp(DateTime createdAt, string code, string userId)
        {
            Id = Guid.NewGuid();
            Code = code;
            CreatedAt = createdAt;
            ExpiresAt = createdAt.AddMinutes(5);
        }

        public Guid Id { get; set; }
        public string Code { get; set; }
        public string UserId { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime ExpiresAt { get; set; }

        public bool IsExpired(DateTime currentTime)
        {
            return ExpiresAt >= currentTime;
        }
    }
}
