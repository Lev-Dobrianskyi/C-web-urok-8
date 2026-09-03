using System.ComponentModel.DataAnnotations;
namespace urok_8.Models
{
    public class OrderModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Title is required.")]
        [MinLength(3, ErrorMessage = "Title must be at least 3 characters long.")]
        [MaxLength(50, ErrorMessage = "Title must be no more than 50 characters long.")]
        public string Title { get; set; }
        public string Description { get; set; }
        [Range(1.00, 10000.00, ErrorMessage = "Price limits are: 1.00 <= price <= 10000.00")]
        public decimal Price { get; set; }
        [Range(1, 100, ErrorMessage = "Quantity limits are: 1 <= quantity <= 100")]
        public int Quantity { get; set; }
        public decimal TotalPrice => Price * Quantity;
    }
}
