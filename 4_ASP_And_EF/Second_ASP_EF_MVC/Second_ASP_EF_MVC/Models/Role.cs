namespace Second_ASP_EF_MVC.Models
{
    public class Role
    {
        public int Id { get; set; }
        public string Name { get; set; } = "";

        public ICollection<Permission>? Permissions { get; set; } = new List<Permission>(); // Navigation property
        public ICollection<Users>? Users { get; set; } = new List<Users>(); // Navigation property

    }
}
