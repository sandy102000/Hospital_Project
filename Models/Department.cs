namespace CareNet_System.Models
{
    public class Department
    {
        public int Id { get; set; }
        public string name { get; set; }
        public string? manager { get; set; }
        public int Patients_num { get; set; }
        public int employees_num { get; set; }

        public List<Staff>? staff { get; set; }
        public List<Patient>? patients { get; set; }
        

    }
}
