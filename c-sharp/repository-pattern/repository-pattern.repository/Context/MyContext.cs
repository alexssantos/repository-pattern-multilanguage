using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using repository_pattern.domain.Account.Aggregate;
using repository_pattern.repository.Mapping;

namespace repository_pattern.repository.Context
{
	public class MyContext : DbContext
	{
		public static readonly ILoggerFactory _loggerFactory = LoggerFactory
			.Create(builder => builder.AddConsole());
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
			optionsBuilder.UseLoggerFactory(_loggerFactory);
			base.OnConfiguring(optionsBuilder);
		}

		public DbSet<UserAccount> UserAccounts { get; set; }
	}
}
