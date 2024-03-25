namespace StudentSystem_WebApiDB.Data.DTO.LectorDTO
{
    public class LectorUpdateDTO
    {
        public int LectorID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Specialty { get; set; }
        public string DateOfBirth { get; set; }
    }
}
