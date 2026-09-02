using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Second_ASP_EF_MVC.Models
{
    public class Employee
    {
        //[Key]
        public int Id { get; set; }

        public string Name { get; set; } = "";

        public string? Description { get; set; }


        [ForeignKey("Department")]
        public int? DepartmentId { get; set; } // Foreign key property
        public Department? Department { get; set; } // Navigation property
    }
}
