namespace AuthApiPoc.Models
{
    public class Otp
    {
        public Otp()
        {

        }

        public Otp(DateTime createdAt,string code, string userId)
        {
            this.Id = Guid.NewGuid();
            this.Code = code;
            this.CreatedAt = createdAt;
            this.ExpiresAt = createdAt.AddMinutes(5);
        }

        public Guid Id { get; set; }
        public string Code { get; set; }
        public string UserId { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime ExpiresAt { get; set; }

        public bool IsExpired(DateTime currentTime)
        {
            return this.ExpiresAt >= currentTime;
        }
    }
}
