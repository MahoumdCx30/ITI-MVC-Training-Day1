using ITI_MVC_Assingment_D1.Models;
using Microsoft.EntityFrameworkCore;

namespace ITI_MVC_Assingment_D1.Data
{
    public class ApplicationDbContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=(localdb)\\ProjectModels;Initial Catalog=ITI_MVC;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False");
        }

        public DbSet<Student> Students { get; set; }
    }
}
