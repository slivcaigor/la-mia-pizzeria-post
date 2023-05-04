namespace la_mia_pizzeria_static.Models
{
    public class Listing
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public bool IsNew { get; set; }
        public string Type { get; set; }
    }
}
