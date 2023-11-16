using AQIL104.Models;
using Microsoft.EntityFrameworkCore;

namespace AQIL104.DAL
{
	public class AppDbContext : DbContext
	{

		public AppDbContext(DbContextOptions options) : base(options) { }

		public DbSet<Product> Products { get; set; }
		public DbSet<Slide> Slides { get; set; }
	

	}
}
