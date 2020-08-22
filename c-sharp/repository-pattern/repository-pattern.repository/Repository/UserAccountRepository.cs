using repository_pattern.domain.Account.Aggregate;
using repository_pattern.domain.Account.Aggregate.Repository;
using repository_pattern.repository.Context;

namespace repository_pattern.repository.Repository
{
	public class UserAccountRepository : RepositoryBase<UserAccount>, IUserAccountRepository
	{
		private MyContext Context { get; set; }

		public UserAccountRepository(MyContext context) : base(context)
		{
			Context = context;
		}
	}
}
