using System.ComponentModel.DataAnnotations;

namespace OneBottle.DTOs.Cart
{
    public class CartDto
    {
        [Required]
        public Guid CartId { get; set; }
        [Required]
        public Guid UserId { get; set; }
        [Required]
        public Guid ProductId { get; set; }
        [Required, Range(1, 100, ErrorMessage = "Quantity must be between 1 and 100")]
        public int Quantity { get; set; }

        public decimal TotalPrice { get; set; }
    }

}