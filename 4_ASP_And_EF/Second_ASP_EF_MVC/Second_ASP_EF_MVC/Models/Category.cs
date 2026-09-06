namespace Second_ASP_EF_MVC.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<Product>? Products { get; set; } = new List<Product>();
    }
}
