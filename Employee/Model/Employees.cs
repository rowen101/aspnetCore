namespace EmployeeManagement.Model
{
    public class Employees : UserActivity
    {
        public int Id { get; set; }
        public string empno { get; set; }
        public string fname { get; set; }

        public string mname { get; set; }

        public string lname { get; set; }

        public string fullname => $"{fname} {mname} {lname}";

        public int phone { get; set; }

        public string email { get; set; }
        public string country { get; set; }
        public string department { get; set; }
        public string designation { get; set; }

    }
}
