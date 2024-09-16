using BookDemo.Models;

namespace BookDemo.Data;

public static class ApplicationContext
{
    //bu proje için statik veri olarak kullanılacak

    public static List<Book> Books { get; set; }

    static ApplicationContext()
    {

    }
}
