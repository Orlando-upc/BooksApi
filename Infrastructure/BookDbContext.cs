
using Domain;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure;
public class BookDbContext : DbContext
{
    public BookDbContext(DbContextOptions options) : base(options)
    {

    }

    public DbSet<Book> Book { get; set; }   
}

