namespace AuthApiPoc.Models.Models
{
    public class Address
    {
        public Guid Id { get; set; }
        public string Country { get; set; }

        public string State { get; set; }

        public string City { get; set; }

        public string PostalCode { get; set; }

        public string Neighborhood { get; set; }

        public string Number { get; set; }

        public string Complement { get; set; }

        public string Type { get; set; }

        public string Label { get; set; }

        public string Description { get; set; }

        public string ResponsibleName { get; set; }

        public string ResponsibleDocument { get; set; }
    }
}
