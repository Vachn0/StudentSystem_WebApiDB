using StudentSystem_WebApiDB.Data.Models;

namespace StudentSystem_WebApiDB.Data.DTO
{
    public class StudentCreateDTO
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public int LectorId { get; set; }
    }
}
