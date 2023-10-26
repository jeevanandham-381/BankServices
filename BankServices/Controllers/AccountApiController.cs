using BankServices.models;
using BankServices.Services;
using Microsoft.AspNetCore.Mvc;

namespace BankServices.Controllers
{
    [ApiController]

    public class AccountApiController : ControllerBase
    {
        private readonly IAccountService _accountService;

        public AccountApiController(IAccountService accountService)
        {
            _accountService = accountService;
        }
        [HttpPost]
        [Route("api/[controller]/newacc")]
        public IActionResult CreateAccount([FromBody]Account account)
        {
            try
            {
                _accountService.CreateAccount(account);
                return Ok(account);
            }catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }


    }
}
