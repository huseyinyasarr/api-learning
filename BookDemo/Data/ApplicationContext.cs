using BookDemo.Models;

namespace BookDemo.Data;

public static class ApplicationContext
{
    //bu proje için statik veri olarak kullanılacak

    public static List<Book> Books { get; set; }

    static ApplicationContext()
    {
        Books = new List<Book>()
        {
            new Book() {Id=1, Price= 5, Title="Güliverin Gezileri"},
            new Book() {Id=2, Price=10, Title="1984"},
            new Book() {Id=3, Price= 9, Title="Hayvan Çiftiliği"}
        };
    }
}
