using Microsoft.EntityFrameworkCore;
using Task__management.Domain;

namespace Task__management.Application.Data
{
	public class Task__managementDbContext : DbContext
	{
		public Task__managementDbContext(DbContextOptions options) : base(options)
		{
		}
        public DbSet<Users> Users { get; set; }
        public DbSet<Projects> Projects { get; set; }
		public DbSet<Tasks> Tasks { get; set; }
    }
}
