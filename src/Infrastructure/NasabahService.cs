using Application.Nasabahs.Dtos;
using Application;
using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure
{
    // Interface pada class harus diimplementasikan atau memiliki penggunaan
    public class NasabahSrvice : INasabahService
    {
        private readonly DatabaseContext context;

        public NasabahSrvice(DatabaseContext context)
        {
            this.context = context;
        }

        public string Create(NasabahDto nasabahDto)
        {
            // Manual Mapper
            var address = new Address()
            {
                City = nasabahDto.Address.City,
                State = nasabahDto.Address.State,
                Country = nasabahDto.Address.Country
            };
            var nasabah = new Nasabah(nasabahDto.Name, nasabahDto.Sex, address, nasabahDto.Phone);

            // AutoMapper
            var mapper = MapperConfig.InitializeAutoMapper();
            var nasabahDtoMap = mapper.Map<Nasabah>(nasabah);

            context.Nasabahs.Add(nasabahDtoMap);
            context.SaveChanges();
            return nasabahDtoMap.Id;
        }

        public void Delete()
        {
            // to do Delete
        }

        public void Read()
        {
            // to do Read
        }

        public void Update()
        {
            // to do Update
        }
    }
}
