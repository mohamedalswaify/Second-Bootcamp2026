namespace Second_ASP_EF_MVC.Application.Dtos.EmployeesDto
{
    public class EmployeeDto
    {

        public int Id { get; set; }

        public string Name { get; set; }
        public string Description { get; set; }

        public string DepartmentName { get; set; }
    }

    public class CreateEmployee
    {
        public string Name { get; set; }
        
        public string Description { get; set; }

        public int DepartmentId { get; set; }
    }
}
