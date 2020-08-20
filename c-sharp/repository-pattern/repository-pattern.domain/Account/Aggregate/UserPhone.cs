using System;

namespace repository_pattern.domain.Account.Aggregate
{
	public class UserPhone
	{
		public Guid Id { get; set; }
		public string PhoneNumber { get; set; }
	}
}
