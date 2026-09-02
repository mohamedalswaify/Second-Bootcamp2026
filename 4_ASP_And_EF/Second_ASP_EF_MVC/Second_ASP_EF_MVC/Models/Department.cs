namespace Second_ASP_EF_MVC.Models
{
    public class Department
    {
        public int Id { get; set; } 
        public string Name { get; set; }

        public ICollection<Employee> Employees { get; set; } = new List<Employee>(); // Navigation property
    }
}
