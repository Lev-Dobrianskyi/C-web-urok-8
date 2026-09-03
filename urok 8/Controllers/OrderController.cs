using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using urok_8.Models;

namespace urok_8.Controllers
{
    [Route("api/orders")]
    public class OrderController : Controller
    {
        private static List<OrderModel> orders = new List<OrderModel>();
        public IActionResult Orders()
        {
            return Content($"Orders: {string.Join(", ", orders.Select(o => o.Title))}");
        }

        [HttpGet("{id}")]
        public IActionResult ShowOrder(int id)
        {
            var order = orders.FirstOrDefault(x => x.Id == id);

            if (order == null)
            {
                return NotFound("Couldnt find order");
            }

            return Content($"Order data: {order.Id}, {order.Title}, {order.Description}, {order.Price}, {order.Quantity}, Total: {order.TotalPrice}");
        }

        [HttpGet("search")]
        public IActionResult SearchOrder(string title)
        {
            var result = orders.Where(x => x.Title.Contains(title, StringComparison.OrdinalIgnoreCase)).ToList();

            return Content($"Search results for '{title}': {string.Join(", ", result.Select(r => r.Title))}");
        }

        [HttpPost]
        public IActionResult Order(string title, string description, decimal price, int quantity)
        {
            OrderModel order = new OrderModel
            {
                Title = title,
                Description = description,
                Price = price,
                Quantity = quantity
            };

            var validationContext = new ValidationContext(order);
            var validationResults = new List<ValidationResult>();
            bool isValid = Validator.TryValidateObject(order, validationContext, validationResults, true);

            if (!isValid)
            {
                var errors = string.Join(", ", validationResults.Select(r => r.ErrorMessage));
                return Content($"Validation failed: {errors}");
            }

            order.Id = orders.Count + 1;

            System.IO.File.AppendAllText("user_data.txt", $"Id: {order.Id}, Title: {order.Title}, Description: {order.Description}, Price: {order.Price}, Quantity: {order.Quantity}, Total: {order.TotalPrice}\n");
            return Content($"Order data: {order.Id}, {order.Title}, {order.Description}, {order.Price}, {order.Quantity}, Total: {order.TotalPrice}, successfully ordered");
        }
    }
}
