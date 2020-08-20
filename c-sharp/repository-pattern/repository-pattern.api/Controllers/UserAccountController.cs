using Microsoft.AspNetCore.Mvc;
using repository_pattern.domain.Account.Aggregate.Repository;

namespace repository_pattern.api.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class UserAccountController : ControllerBase
	{
		private IUserAccountRepository _repoUserAccount { get; set; }


		public UserAccountController(IUserAccountRepository repoUserAccount)
		{
			this._repoUserAccount = repoUserAccount;
		}

		[Route("")]
		[HttpGet]
		public ActionResult GetAll()
		{
			return Ok(_repoUserAccount.GetAll());
		}
	}
}
