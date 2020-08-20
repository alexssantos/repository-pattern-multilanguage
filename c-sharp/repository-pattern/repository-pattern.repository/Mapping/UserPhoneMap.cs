using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using repository_pattern.domain.Account.Aggregate;

namespace repository_pattern.repository.Mapping
{
	public class UserPhoneMap : IEntityTypeConfiguration<UserPhone>
	{
		public void Configure(EntityTypeBuilder<UserPhone> builder)
		{
			builder.HasKey(x => x.Id);
			builder.Property(x => x.Id).IsRequired().ValueGeneratedOnAdd();
			builder.Property(x => x.PhoneNumber).IsRequired().HasMaxLength(255);
		}
	}
}
