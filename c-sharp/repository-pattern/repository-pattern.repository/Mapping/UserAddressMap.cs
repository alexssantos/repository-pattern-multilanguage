using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using repository_pattern.domain.Account.Aggregate;

namespace repository_pattern.repository.Mapping
{
	public class UserAddressMap : IEntityTypeConfiguration<UserAddress>
	{
		public void Configure(EntityTypeBuilder<UserAddress> builder)
		{
			builder.HasKey(x => x.Id);
			builder.Property(x => x.Id).IsRequired().ValueGeneratedOnAdd();
			builder.Property(x => x.Address).IsRequired();
			builder.Property(x => x.City).IsRequired();
			builder.Property(x => x.Complement).IsRequired();
			builder.Property(x => x.Neiborhood).IsRequired();
			builder.Property(x => x.State).IsRequired();
			builder.Property(x => x.ZipCode).IsRequired();
		}
	}
}
