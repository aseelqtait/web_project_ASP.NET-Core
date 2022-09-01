using System.ComponentModel.DataAnnotations;

namespace book_store.Models
{
    public class Login 
    {
        [Key]
        [Required(ErrorMessage = "Plz enter Email")]
        public string Email { get; set; }
        [Required(ErrorMessage ="Plz enter Password")]
        public string Password { get; set; }
        [Required]
        public int CustomerId { get; set; }
    }
}
