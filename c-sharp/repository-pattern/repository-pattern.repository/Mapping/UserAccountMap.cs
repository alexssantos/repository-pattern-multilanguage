using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using repository_pattern.domain.Account.Aggregate;

namespace repository_pattern.repository.Mapping
{
	/*Fluent API*/
	public class UserAccountMap : IEntityTypeConfiguration<UserAccount>
	{
		public void Configure(EntityTypeBuilder<UserAccount> builder)
		{


			builder.HasKey(x => x.Id);
			builder.Property(x => x.Id).IsRequired().ValueGeneratedOnAdd();
			builder.Property(x => x.Name).IsRequired().HasMaxLength(250);
			builder.Property(x => x.Email).IsRequired().HasMaxLength(250);
			builder.Property(x => x.CPF).IsRequired().HasMaxLength(11);
			builder.Property(x => x.DtBirthday).IsRequired();
		}
	}
}
