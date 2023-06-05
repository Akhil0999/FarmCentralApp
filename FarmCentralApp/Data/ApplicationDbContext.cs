using FarmCentralApp.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
//abstract representation of database
namespace FarmCentralApp.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        //2. Table that you want to create... model classes go here

        public DbSet<SalesLeadEntity> SalesLeadEntities { get; set; }
        public DbSet<AppUser> AppUser { get; set; }
        //public DbSet<ProductsEntity> Products { get; set; }
    }
}