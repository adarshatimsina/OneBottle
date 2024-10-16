namespace OneBottle.Models
{
    public class Cart
    {
        public Guid CartId { get; set; }
        public Guid UserId { get; set; }
        public User? User {get; set;}
        public List<Guid> ProductId { get; set; } 
        public Product? Product { get; set; }
        public int Quantity { get; set; }

        public decimal TotalPrice { get; set; }
    }
}