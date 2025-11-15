namespace project1.Models
{
    public class Staff
    {
        public int Id { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string email { get; set; }

        public string department { get; set; }
        public Staff() { }
        public Staff(int id, string name, string firstName,string email,string department)
        {
            Id = id;
            lastName = name;
            firstName = firstName;
            email = email;
            department = department;
        }
    }
}
