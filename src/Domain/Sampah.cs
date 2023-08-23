namespace Domain
{
    public enum Sex
    {
        Male,
        Female
    }

    public abstract class Person
    {
        public Person(string name, Sex sex)
        {
            GenereateId();

            Name = name;
            Sex = sex;
        }

        public Person(string name, Sex sex, Address address, string phone) : this(name, sex)
        {
            Address = address;
            Phone = phone;
        }

        public string? Id { get; protected set; }
        public string? Name { get; }
        public Sex Sex { get; }
        public Address? Address { get; }
        public string? Phone { get; }

        /// <summary>
        /// Membuat Id secara otomatis serta dapat dimodifikasi
        /// </summary>
        public virtual void GenereateId()
        {
            Id = Guid.NewGuid().ToString();
        }
    }

    // Try Complex AutoMapper
    public class Address
    {
        public string? City { get; set; }
        public string? State { get; set; }
        public string? Country { get; set; }
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
        public Sampah(string name, string description, JenisSampah jenisSampah)
        {
            Id = $"{Guid.NewGuid()}";
            Name = name;
            Description = description;
            JenisSampah = jenisSampah;
        }

        public string? Id { get; }
        public string? Name { get; }
        public string? Description { get; }
        public JenisSampah JenisSampah { get; }
    }

    public class Nasabah : Person
    {
        public Nasabah(string name, Sex sex, Address address, string phone) : base(name, sex, address, phone)
        {
        }

        public override void GenereateId()
        {
            Id = $"{nameof(Nasabah)}_{Guid.NewGuid()}";
        }
    }

    public class Pengepul : Person
    {
        public Pengepul(string name, Sex sex, Address address, string phone) : base(name, sex, address, phone)
        {
        }

        public override void GenereateId()
        {
            Id = $"{nameof(Pengepul)}_{Guid.NewGuid()}";
        }
    }

    public class Petugas : Person
    {
        public Petugas(string name, Sex sex) : base(name, sex)
        {
        }

        public override void GenereateId()
        {
            Id = $"{nameof(Petugas)}_{Guid.NewGuid()}";
        }
    }

    public class Gudang
    {
        public Gudang(string sampahId)
        {
            SampahId = sampahId;
        }

        private int stock;
        public int Id { get; }
        public string? SampahId { get; }
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