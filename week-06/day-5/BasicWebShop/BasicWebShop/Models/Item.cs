namespace BasicWebShop.Models
{
    public class Item
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; } 
        public int Quantity { get; set; }
        
        public int ID { get; set; }
    }
}