namespace StudentSystem_WebApiDB.Data.Models
{
    public class Lector
    {
        public int LectorID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Specialty { get; set; }
        public DateTime DateOfBirth { get; set; }
        public ICollection<Student> Students { get; set; }
    }
}
