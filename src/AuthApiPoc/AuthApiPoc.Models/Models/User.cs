namespace AuthApiPoc.Models.Models
{
    public class User
    {
        public Guid Id { get; set; }

        public string Username { get; set; }

        public Password Password { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        public string Document { get; set; }

        public string IsCorporate { get; set; }

        public DateTime BirthDate { get; set; }

        public string Country { get; set; }

        public string Gender { get; set; }

        public List<Address> Addresses { get; set; }

        public List<Phone> Phones { get; set; }
    }
}
