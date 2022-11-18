using AuthApiPoc.Business.Models.Enums;

namespace AuthApiPoc.Business.Models
{
    public class Phone
    {
        public Guid Id { get; set; }

        public string CountryCode { get; set; }

        public string AreaCode { get; set; }

        public string PhoneNumber { get; set; }

        public PhoneTypes Type { get; set; }
    }
}
