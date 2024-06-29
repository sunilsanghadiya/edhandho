using edhandho.Entities;
using Microsoft.EntityFrameworkCore;

namespace edhandho.Db
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> option) : base(option)
        {

        }

        //Entities
        DbSet<Users> Users => Set<Users>();
        
        //Views

        //Store Procedures

        //Functions

    }
}