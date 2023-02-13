using BulkyBook.Models;
using Microsoft.EntityFrameworkCore;
using System.Data.Entity;
using DbContext = Microsoft.EntityFrameworkCore.DbContext;

namespace BulkyBookWeb.Data {
    public class ApplicationDbContext : DbContext {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) :base(options) {

        }

        //creates category table names "Categories" with the 4 columns from the class Category's properties
        //is code first appreach
        public Microsoft.EntityFrameworkCore.DbSet<Category> Categories { get; set; }
    } 
}
