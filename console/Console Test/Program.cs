using Domain;
using System.ComponentModel;

namespace Console_Test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person nasabah = new Nasabah("Budi", Sex.Male, "Jakarta Utara", "081213141516");
            Console.Write($"Id: {nasabah.Id}\n" +
                $"Nama: {nasabah.Name}\n" +
                $"Kelamin: {nasabah.Sex}\n" +
                $"Alamat: {nasabah.Address}\n" +
                $"Phone: {nasabah.Phone}\n\n");

            Person petugas = new Petugas("Budi", Sex.Male);
            Console.Write($"Id: {petugas.Id}\n" +
                $"Nama: {petugas.Name}\n" +
                $"Kelamin: {petugas.Sex}\n" +
                $"Alamat: {petugas.Address}\n" +
                $"Phone: {petugas.Phone}\n\n");

            List<Gudang> gudang = new List<Gudang>();
            Sampah sampah = new Sampah("Plastik", "Sampah plastik", JenisSampah.Plastik);

            Gudang plastikOne = new Gudang(sampah.Id);
            plastikOne.AddStock(5);
            gudang.Add(plastikOne);

            Gudang plastikTwo = new Gudang(sampah.Id);
            plastikTwo.AddStock(6);
            gudang.Add(plastikTwo);
        }
    }
}