using Application.Nasabahs.Dtos;
using AutoMapper;
using Domain;
using Infrastructure;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Console_Test
{
    internal class Program
    {
        //static void Main(string[] args)
        //{
        //    Person nasabah = new Nasabah("Budi", Sex.Male, "Jakarta Utara", "081213141516");
        //    Console.Write($"Id: {nasabah.Id}\n" +
        //        $"Nama: {nasabah.Name}\n" +
        //        $"Kelamin: {nasabah.Sex}\n" +
        //        $"Alamat: {nasabah.Address}\n" +
        //        $"Phone: {nasabah.Phone}\n\n");

        //    Person petugas = new Petugas("Budi", Sex.Male);
        //    Console.Write($"Id: {petugas.Id}\n" +
        //        $"Nama: {petugas.Name}\n" +
        //        $"Kelamin: {petugas.Sex}\n" +
        //        $"Alamat: {petugas.Address}\n" +
        //        $"Phone: {petugas.Phone}\n\n");

        //    List<Gudang> gudang = new List<Gudang>();
        //    Sampah sampah = new Sampah("Plastik", "Sampah plastik", JenisSampah.Plastik);

        //    Gudang plastikOne = new Gudang(sampah.Id);
        //    plastikOne.AddStock(5);
        //    gudang.Add(plastikOne);

        //    Gudang plastikTwo = new Gudang(sampah.Id);
        //    plastikTwo.AddStock(6);
        //    gudang.Add(plastikTwo);
        //}

        static void Main(string[] args)
        {
            var address = new Address()
            {
                City = "Jakarta Utara",
                State = "DKI Jakarta",
                Country = "Indonesia"
            };
            var nasabah = new Nasabah("Budi Setiawan", Sex.Male, address, "081213141516");

            // Manual Mapper
            var addressDto = new AddressDto()
            {
                City = nasabah.Address.City,
                State = nasabah.Address.State,
                Country = nasabah.Address.Country
            };
            var nasabahDto = new NasabahDto()
            {
                Id = nasabah.Id,
                Name = nasabah.Name,
                Sex = nasabah.Sex,
                Address = addressDto,
                Phone = nasabah.Phone,
            };
            Console.WriteLine($"Manual Mapper Nasabah Dto");
            Console.WriteLine($"Id: {nasabahDto.Id}");
            Console.WriteLine($"Name: {nasabahDto.Name}");
            Console.WriteLine($"Sex: {nasabahDto.Sex}");
            Console.WriteLine($"Address: {nasabahDto.Address.City}, {nasabahDto.Address.State}, {nasabahDto.Address.Country}");
            Console.WriteLine($"Phone: {nasabahDto.Phone}\n");
            
            // AutoMapper
            var mapper = MapperConfig.InitializeAutoMapper();
            var nasabahDtoMap = mapper.Map<NasabahDto>(nasabah);
            //var nasabahDtoMap = mapper.Map<Nasabah, NasabahDto>(nasabah);
            Console.WriteLine($"AutoMapper Nasabah Dto");
            Console.WriteLine($"Id: {nasabahDtoMap.Id}");
            Console.WriteLine($"Name: {nasabahDtoMap.Name}");
            Console.WriteLine($"Sex: {nasabahDtoMap.Sex}");
            Console.WriteLine($"Address: {nasabahDtoMap.Address.City}, {nasabahDtoMap.Address.State}, {nasabahDtoMap.Address.Country}");
            Console.WriteLine($"Phone: {nasabahDtoMap.Phone}\n");
        }
    }
}