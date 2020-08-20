using Microsoft.EntityFrameworkCore;
using repository_pattern.domain.Account.Aggregate;
using repository_pattern.repository.Mapping;

namespace repository_pattern.repository.Context
{
	public class MyContext : DbContext
	{
		public MyContext(DbContextOptions<MyContext> options) : base(options)
		{

		}

		protected override void OnModelCreating(ModelBuilder builder)
		{
			builder.ApplyConfiguration(new UserAccountMap());
			builder.ApplyConfiguration(new UserAddressMap());
			builder.ApplyConfiguration(new UserPhoneMap());

			base.OnModelCreating(builder);
		}

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			base.OnConfiguring(optionsBuilder);
		}

		public DbSet<UserAccount> UserAccounts { get; set; }
	}
}
