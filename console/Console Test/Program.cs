using Domain;
using System.ComponentModel;

namespace Console_Test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Person nasabah = new Nasabah("Budi", Sex.Male, "Jakarta Utara", "081213141516");
            //Console.Write($"Id: {nasabah.Id}\n" +
            //    $"Nama: {nasabah.Name}\n" +
            //    $"Kelamin: {nasabah.Sex}\n" +
            //    $"Alamat: {nasabah.Address}\n" +
            //    $"Phone: {nasabah.Phone}\n\n");

            //Person petugas = new Petugas("Budi", Sex.Male);
            //Console.Write($"Id: {petugas.Id}\n" +
            //    $"Nama: {petugas.Name}\n" +
            //    $"Kelamin: {petugas.Sex}\n" +
            //    $"Alamat: {petugas.Address}\n" +
            //    $"Phone: {petugas.Phone}\n\n");

            //List<Gudang> gudang = new List<Gudang>();
            //Sampah sampah = new Sampah("Plastik", "Sampah plastik", JenisSampah.Plastik);

            //Gudang plastikOne = new Gudang(sampah.Id);
            //plastikOne.AddStock(5);
            //gudang.Add(plastikOne);

            //Gudang plastikTwo = new Gudang(sampah.Id);
            //plastikTwo.AddStock(6);
            //gudang.Add(plastikTwo);

            PesanDelegate pesanDelegateA = PesanA;
            PesanDelegate pesanDelegateB = PesanB;

            PesanDelegate pesanMulticase = pesanDelegateA + pesanDelegateB;
            pesanMulticase("Halo ini pesan dengan delegate");

            pesanMulticase -= pesanDelegateA;
            pesanMulticase("Halo ini pesan dengan delegate setelah dihapus");

            Func<string, string> pesanFunc = PesanC;
            Console.WriteLine(pesanFunc("Halo ini pesan dengan func delegate"));

            Action<string> pesanAct = PesanB;
            pesanAct("Halo ini pesan dengan action delegate");
        }

        public delegate void PesanDelegate(string pesan);
        public static void PesanA(string pesan)
        {
            Console.WriteLine($"A: {pesan}");
        }

        public static void PesanB(string pesan)
        {
            Console.WriteLine($"B: {pesan}");
        }

        public static string PesanC(string pesan)
        {
            return $"C: {pesan}";
        }
    }
}