using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace MVCODEV.Models
{
    public class OgrenciContext:DbContext
    {
        public DbSet<Ogrenci> Ogrenciler { get; set; } //<> bu parantez generic yapı olduğunu belirtir.
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=.\MSSQLSERVER1; Initial Catalog=MVCOdev;Integrated Security=true");
        }
    }
}
