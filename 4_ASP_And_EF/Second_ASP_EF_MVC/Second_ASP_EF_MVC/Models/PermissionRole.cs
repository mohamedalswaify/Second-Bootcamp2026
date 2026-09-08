using System.ComponentModel.DataAnnotations.Schema;

namespace Second_ASP_EF_MVC.Models
{
    public class PermissionRole
    {

        [ForeignKey("Permissions")]
        public int PemissionsId { get; set; }
        public Permission? Permissions { get; set; } // Navigation property


        [ForeignKey("Roles")]
        public int RolesId { get; set; }
        public Role? Roles { get; set; } // Navigation property
    }
}
