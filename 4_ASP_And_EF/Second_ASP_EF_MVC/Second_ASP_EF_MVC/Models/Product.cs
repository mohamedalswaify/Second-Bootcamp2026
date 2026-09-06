using System.ComponentModel.DataAnnotations.Schema;

namespace Second_ASP_EF_MVC.Models
{
    public class Product
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public decimal Price { get; set; }

        [ForeignKey("Category")]
        public int? CategoryId { get; set; }
        public Category? Category { get; set; }
    }
}
