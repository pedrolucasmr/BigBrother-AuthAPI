using System.ComponentModel.DataAnnotations;

namespace AuthApiPoc.Models.DTOs.Request
{
    public record CompleteRegistrationRequest
    {
        [Required]
        public string UserId { get; set; }

        [Required]
        public string OTPCode { get; set; }
    }
}
