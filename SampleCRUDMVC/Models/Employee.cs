namespace SampleCRUDMVC.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public required string FirstName { get; set; }
        public required string MiddleName { get; set; }
        public required string LastName { get; set; }
        public required string PhoneNumber { get; set; }
        public required string EmailAddress { get; set; }
        public required string Gender { get; set; }
        public required string Country { get; set; }
        public string? Image { get; set; }
    }
}
