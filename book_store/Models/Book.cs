using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace book_store.Models
{
    public class Book
    {
        public int BookId { get; set; }
        [Required]
        public string  BookName { get; set; }
        [Required]
        public string Type { get; set; }
        [Range (1 , 200)]
        public double Price { get; set; }

        
    }
}
