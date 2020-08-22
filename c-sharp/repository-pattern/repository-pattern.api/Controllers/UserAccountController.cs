using Microsoft.AspNetCore.Mvc;
using repository_pattern.domain.Account.Aggregate.Repository;
using repository_pattern.domain.Account.Aggregate.Specification;
using System.Threading.Tasks;

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
		public async Task<ActionResult> GetAll()
		{
			return Ok(await _repoUserAccount.GetAll());
		}

		[Route("{cpf}")]
		[HttpGet]
		public async Task<ActionResult> GetAll(string cpf)
		{
			return Ok(await this._repoUserAccount.GetAllByCriteria(
				UserAccountSpecification.GetAllByCPF(cpf)));
		}
	}
}
