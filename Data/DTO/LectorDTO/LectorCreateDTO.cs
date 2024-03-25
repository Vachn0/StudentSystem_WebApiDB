namespace StudentSystem_WebApiDB.Data.DTO.LectorDTO
{
    public class LectorCreateDTO
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Specialty { get; set; }
        public string DateOfBirth { get; set; }
        public int StudentID { get; set; }
    }
}
