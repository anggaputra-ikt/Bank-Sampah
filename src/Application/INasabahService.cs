using Application.Nasabahs.Dtos;
using Domain;

namespace Application
{
    public interface INasabahService
    {
        string Create(NasabahDto nasabahDto);
        void Read();
        void Update();
        void Delete();
    }
}
