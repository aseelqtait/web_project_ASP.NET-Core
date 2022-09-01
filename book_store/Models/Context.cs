using Microsoft.EntityFrameworkCore;

namespace book_store.Models
{
    public class Context: DbContext
    {
      public Context(DbContextOptions<Context> options) : base(options) { }  
      public DbSet<Customer> Customers { get; set; }
      public DbSet<Order> Orders { get; set; }
      public DbSet<Book> Books { get; set; }
      public DbSet<Login> Login { set; get; }
    }
}
