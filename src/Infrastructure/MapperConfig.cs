using Application.Nasabahs.Dtos;
using AutoMapper;
using Domain;

namespace Infrastructure
{
    public class MapperConfig
    {
        public static Mapper InitializeAutoMapper()
        {
            var mapperConfig = new MapperConfiguration(config =>
            {
                // Menambahkan Address mapping karena
                // Missing type map configuration or unsupported mapping.
                config.CreateMap<Address, AddressDto>();
                config.CreateMap<Nasabah, NasabahDto>();
            });

            var mapper = new Mapper(mapperConfig);
            return mapper;
        }
    }
}
