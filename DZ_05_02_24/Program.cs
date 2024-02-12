using DZ_05_02_24;
using Microsoft.EntityFrameworkCore;

//using (ApplicationContext db = new ApplicationContext())
//{
//    db.Database.EnsureDeleted();
//    db.Database.EnsureCreated();
//    List<Author> authors = new List<Author>()
//    {
//        new Author{Name="Author1"},
//        new Author{Name="Author2"}
//    };
//    List<Book> books = new List<Book>()
//    {
//        new Book{ Title="Book1", Price=50, Author=authors[0]},
//        new Book{ Title="Book2", Price=70, Author=authors[1]},
//        new Book{ Title="Book3", Price=350, Author=authors[0]}
//    };
//    db.AddRange(books);
//    db.SaveChanges();
//    db.Database.ExecuteSqlRaw("""
//        Create Procedure sp_UpdateBookPriceAuthor
//        @authorName NVARCHAR(100),
//        @newPrice decimal(10,2)
//        AS
//        BEGIN
//        UPDATE [Books] Set [Price]=@newPrice where [AuthorId]=(Select Top (1) [Id] from [Authors] where [Author].[Name]=@authorName)
//        End
//        """);
//}

using (ApplicationContext db = new ApplicationContext())
{
    string authorName = "Author1";
    decimal price = 400;
    db.UpdateBookPriceByAuthor(authorName, price);
}