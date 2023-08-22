using Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public interface INasabahSrvice
    {
        void Create();
        void Read();
        void Update();
        void Delete();
    }

    // Interface pada class harus diimplementasikan atau memiliki penggunaan
    public class NasabahSrvice : INasabahSrvice
    {
        private readonly DatabaseContext context;

        public NasabahSrvice(DatabaseContext context)
        {
            this.context = context;
        }

        public void Create()
        {
            // to do Create
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
