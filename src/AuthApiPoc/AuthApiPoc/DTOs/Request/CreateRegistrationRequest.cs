using AuthApiPoc.Models.Enums;
using System.ComponentModel.DataAnnotations;

namespace AuthApiPoc.DTOs.Request
{
    public record CreateRegistrationRequest
    {
        [Required]
        public string Username { get; set; }

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        public string Password { get; set; }

        [Required]
        public string Email { get; set; }

        [Required]
        public string Document { get; set; }

        [Required]
        public string Birth { get; set; }

        public List<CreatePhoneRequest> Phones { get; set; }

        public List<CreateAddressRequest> Addresses { get; set; }

        public string Country { get; set; }

        public string Gender { get; set; }
    }

    public record CreatePhoneRequest
    {
        [Required]
        public string CountryCode { get; set; }

        [Required]
        public string AreaCode { get; set; }

        [Required]
        public string PhoneNumber { get; set; }

        [Required]
        public PhoneTypes Type { get; set; }
    }

    public record CreateAddressRequest
    {
        [Required]
        public string Country { get; set; }
        
        [Required]
        public string State { get; set; }

        [Required]
        public string City { get; set; }

        [Required]
        public string PostalCode { get; set; }

        public string Neighborhood { get; set; }

        public string Number { get; set; }

        public string Complement { get; set; }

        public string Type { get; set; }

        public string Label { get; set; }

        public string Description { get; set; }

        //TODO: improve this
        public string Responsible { get; set; }

        public string ResponsibleDocument { get; set; }
    }
}
