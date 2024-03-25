using StudentSystem_WebApiDB.Data.Models;

namespace StudentSystem_WebApiDB.Data.DTO.StudentDTO
{
    public class StudentUpdateDTO
    {
        public int StudentID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public int LectorID { get; set; }
    }
}
