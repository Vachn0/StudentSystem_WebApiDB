using StudentSystem_WebApiDB.Data.Models;

namespace StudentSystem_WebApiDB.Data.DTO.StudentDTO
{
    public class StudentCreateDTO
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public int LectorID { get; set; }
    }
}
