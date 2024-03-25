using StudentSystem_WebApiDB.Data.DTO.StudentDTO;
using StudentSystem_WebApiDB.Data.Models;

namespace StudentSystem_WebApiDB.Interface
{
    public interface IStudentService
    {
        public Task<ICollection<Student>> GetAll();
        public Task<Student> GetStudentByID(int id);
        public Task<bool> CreateStudent(StudentCreateDTO studentDTO);
        public Task<bool> UpdateStudent(StudentUpdateDTO studentDTO);
        public Task<bool> DeleteStudent(int id);
        
    }
}
