using StudentSystem_WebApiDB.Data.DTO;
using StudentSystem_WebApiDB.Data.DTO.LectorDTO;
using StudentSystem_WebApiDB.Data.Models;

namespace StudentSystem_WebApiDB.Interface
{
    public interface ILectorService
    {
        public Task<ICollection<Lector>> GetAll();
        public Task<Lector> GetLectorByID(int id);
        public Task<bool> CreateLector(LectorCreateDTO LectorDTO);
        public Task<bool> UpdateLector(LectorUpdateDTO LectorDTO);
        public Task<bool> DeleteLector(int id);
    }
}
