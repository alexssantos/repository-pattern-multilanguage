using System;
using System.Collections.Generic;

namespace repository_pattern.domain.Account.Aggregate
{
	public class UserAccount
	{
		public Guid Id { get; set; }
		public string Name { get; set; }
		public string Email { get; set; }
		public string CPF { get; set; }
		public DateTime DtBirthday { get; set; }

		public IList<UserAddress> Addresses { get; set; }
		public IList<UserPhone> Phones { get; set; }

	}
}
