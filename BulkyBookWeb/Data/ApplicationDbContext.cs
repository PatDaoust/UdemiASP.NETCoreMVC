using BulkyBookWeb.Models;
using Microsoft.EntityFrameworkCore;

namespace BulkyBookWeb.Data {
    public class ApplicationDbContext : DbContext {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) :base(options) {

        }

        //creates category table names "Categories" with the 4 columns from the class Category's properties
        //is code first appreach
        public DbSet<Category> Categories { get; set; }
    } 
}
