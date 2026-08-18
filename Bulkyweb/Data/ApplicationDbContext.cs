using Bulkyweb.Models;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Metadata;

namespace Bulkyweb.Data
{
    public class ApplicationDbContext : DbContext
    {



        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options
            ) : base(options)
        {

        }
        public DbSet<Student> students { get; set; }
    }
}
