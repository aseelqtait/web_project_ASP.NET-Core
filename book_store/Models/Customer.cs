using System.ComponentModel.DataAnnotations;

namespace book_store.Models
{
    public class Customer
    {
        public int CustomerId { get; set; }
        [Required]
        public string CustomerName { get; set; }
        [Required]
        public string address { get; set; }
    }
}
