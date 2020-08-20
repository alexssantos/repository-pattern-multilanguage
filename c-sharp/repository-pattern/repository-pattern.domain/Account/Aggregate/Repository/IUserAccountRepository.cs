using System.Collections.Generic;

namespace repository_pattern.domain.Account.Aggregate.Repository
{
	public interface IUserAccountRepository
	{
		public IList<UserAccount> GetAll();
	}
}
