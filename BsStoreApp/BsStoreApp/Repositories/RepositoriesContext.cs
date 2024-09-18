using BsStoreApp.Models;
using Microsoft.EntityFrameworkCore;
using WebApi.Repositories.Config;

namespace WebApi.Repositories;

public class RepositoriesContext : DbContext
{

    public RepositoriesContext(DbContextOptions options) : base(options)
    {

    }

    public DbSet<Book> Books { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new BookConfig());
    }
}
