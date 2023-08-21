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
        public int Id { get; set; }
        public string Name { get; set; }
        public Sex Sex { get; set; }
        public virtual string Address { get; set; }
        public virtual string Phone { get; set; }
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
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public JenisSampah JenisSampah { get; set; }
    }


    public class Nasabah : Person
    {
    }

    public class Pengepul : Person
    {
    }

    public class Petugas : Person
    {
        [NotMapped]
        public override string Address { get => base.Address; set => base.Address = value; }
        [NotMapped]
        public override string Phone { get => base.Phone; set => base.Phone = value; }
    }
}