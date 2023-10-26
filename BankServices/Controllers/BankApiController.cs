using BankServices.models;
using BankServices.Services;
using Microsoft.AspNetCore.Mvc;

namespace BankServices.Controllers
{
    [ApiController]
    public class BankApiController : ControllerBase
    {
        private readonly IBankService _bankService;

        public BankApiController(IBankService bankService)
        {
            _bankService = bankService;

        }
        [HttpPost]
        [Route("api/[controller]/newbank")]
        public IActionResult CreateBank([FromBody] Bank bank)
        {
            try
            {
                _bankService.CreateBank(bank);
                return Ok(bank);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }


    }
}

