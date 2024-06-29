using Microsoft.EntityFrameworkCore;

namespace edhandho.Db
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> option) : base(option)
        {

        }

        //Entities

        //Views

        //Store Procedures

        //Functions

    }
}