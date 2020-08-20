using repository_pattern.domain.Account.Aggregate;
using repository_pattern.domain.Account.Aggregate.Repository;
using repository_pattern.repository.Context;
using System.Collections.Generic;
using System.Linq;

namespace repository_pattern.repository.Repository
{
	public class UserAccountRepository : IUserAccountRepository
	{
		private MyContext Context { get; set; }

		public UserAccountRepository(MyContext context)
		{
			Context = context;
		}

		public IList<UserAccount> GetAll()
		{
			return this.Context.UserAccounts.ToList();
		}
	}
}
