using Microsoft.EntityFrameworkCore;
using repository_pattern.domain.Account.Aggregate;

namespace repository_pattern.repository.Context
{
	public class MyContext : DbContext
	{
		public MyContext(DbContextOptions<MyContext> options) : base(options)
		{

		}

		protected override void OnModelCreating(ModelBuilder builder)
		{
			base.OnModelCreating(builder);
		}

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			base.OnConfiguring(optionsBuilder);
		}

		public DbSet<UserAccount> UserAccounts { get; set; }
	}
}
