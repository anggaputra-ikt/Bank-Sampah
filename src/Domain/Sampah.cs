using System.ComponentModel.DataAnnotations.Schema;

namespace Domain
{
    public enum Sex
    {
        Male,
        Female
    }

    public abstract class Person
    {
        public Person()
        {
            Id = Guid.NewGuid().ToString();
        }

        public string? Id { get; }
        public string? Name { get; }
        public Sex Sex { get; }
        public string? Address { get; }
        public string? Phone { get; }
    }

    public enum JenisSampah
    {
        Kertas,
        Plastik,
        Beling,
        Besi
    }

    public class Sampah
    {
        public int Id { get; }
        public string? Name { get; }
        public string? Description { get; }
        public JenisSampah JenisSampah { get; }
    }


    public class Nasabah : Person
    {
    }

    public class Pengepul : Person
    {
    }

    public class Petugas : Person
    {
    }

    public class Gudang
    {
        public Gudang(int sampahId)
        {
            SampahId = sampahId;
        }

        private int stock;
        public int Id { get; }
        public int SampahId { get; }
        public int Stock
        {
            get
            {
                return stock;
            }
        }

        public void AddStock(int total)
        {
            if (total > 0)
            {
                stock += total;
            }
        }

        public void RemoveStock(int total)
        {
            if (total > 0)
            {
                stock -= total;
            }
        }
    }
}