using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace book_store.Models
{
    public class Order
    {
        public int OrderId { get; set; }
        [Required]
        public int  UserId{ get; set; }
        [Required]
        public int  BookId { set; get; }
        public  string Status { get; set; }



    }
}
