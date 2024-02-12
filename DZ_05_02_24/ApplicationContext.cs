using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_05_02_24
{
    internal class ApplicationContext : DbContext
    {
        public DbSet<Book> Books { get; set; }
        public DbSet<Author> Author { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=LIBERTY; Database=DZ_05_02_24; Trusted_Connection=True; TrustServerCertificate=True; Integrated Security=True;");        
        }
        public void UpdateBookPriceByAuthor(string authorName, decimal newPrice)
        {
            Database.ExecuteSqlInterpolated($"EXEC sp_UpdateBookPriceAuthor {authorName}, {newPrice}");
        }
    }
}
