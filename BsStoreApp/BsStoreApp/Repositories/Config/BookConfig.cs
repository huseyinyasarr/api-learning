using BsStoreApp.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace WebApi.Repositories.Config;

public class BookConfig : IEntityTypeConfiguration<Book>
{
    public void Configure(EntityTypeBuilder<Book> builder)
    {
        builder.HasData(
                new Book { Id=1, price = 125, Title= "Güliverin Gemicikleri"},
                new Book { Id=2, price= 245, Title="Ali Ata Bakıyor"},
                new Book { Id=3, price = 180, Title="Gel Gör Beni"}
            );
    }
}
