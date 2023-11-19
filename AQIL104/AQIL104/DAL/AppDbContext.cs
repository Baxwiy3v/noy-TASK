using AQIL104.Models;
using Microsoft.EntityFrameworkCore;

namespace AQIL104.DAL
{
	public class AppDbContext : DbContext
	{

		public AppDbContext(DbContextOptions options) : base(options) { }

        public DbSet<Product> Products { get; set; }
        public DbSet<Slide> Slides { get; set; }

        public DbSet<ProductImage> ProductImages { get; set; }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Category> Categories { get; set; }

    }

   
}

    
