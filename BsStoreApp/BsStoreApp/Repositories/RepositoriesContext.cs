using BsStoreApp.Models;
using Microsoft.EntityFrameworkCore;

namespace WebApi.Repositories;

public class RepositoriesContext : DbContext
{

    public RepositoriesContext(DbContextOptions options) : base(options)
    {

    }

    public DbSet<Book> Books { get; set; }
}
