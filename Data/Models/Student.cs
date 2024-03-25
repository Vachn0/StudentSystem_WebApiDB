namespace StudentSystem_WebApiDB.Data.Models
{
    public class Student
    {
        public int StudentID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public int? LectorID { get; set; }
        public ICollection<Lector> Lector { get; set; }
    }
}
