using Domain;

namespace Application.Nasabahs.Dtos
{
    public class NasabahDto
    {
        public string? Id { get; set; }
        public string? Name { get; set; }
        public Sex Sex { get; set; }
        public AddressDto? Address { get; set; }
        public string? Phone { get; set; }
    }

    public class AddressDto
    {
        public string? City { get; set; }
        public string? State { get; set; }
        public string? Country { get; set; }
    }
}
