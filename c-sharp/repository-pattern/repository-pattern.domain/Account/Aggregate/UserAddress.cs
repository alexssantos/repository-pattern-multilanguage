using System;

namespace repository_pattern.domain.Account.Aggregate
{
	public class UserAddress
	{
		public Guid Id { get; set; }
		public string Address { get; set; }
		public string Complement { get; set; }
		public string Neiborhood { get; set; }
		public string City { get; set; }
		public string State { get; set; }
		public string ZipCode { get; set; }
	}
}
