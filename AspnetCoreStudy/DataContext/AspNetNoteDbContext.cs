using AspnetCoreStudy.Models;
using Microsoft.EntityFrameworkCore;

namespace AspnetCoreStudy.DataContext
{
    public class AspNetNoteDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }

        public DbSet<Note> Notes { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //base.OnConfiguring(optionsBuilder);

            //optionsBuilder.UseSqlServer(@"Server=localhost;Database=AspNetNoteDb;Trusted_Connection=True;");

            optionsBuilder.UseSqlServer(@"Data Source=(local)\MSSQLServer01;Initial Catalog=AspNetNoteDb;Integrated Security=True");
        }

    }
}
