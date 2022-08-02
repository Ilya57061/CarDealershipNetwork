
using CarDealerships.BusinessLogic.Interfaces;
using CarDealerships.Common.Models;
using Microsoft.AspNetCore.Mvc;

namespace CarDealerships.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {

        private readonly IAccountService _accountService;

        public AccountController(IAccountService accountService)
        {
            _accountService = accountService;
        }

        [HttpPost("register")]
        public ActionResult<UserModel> Register(RegisterModel userModel)
        {
            return Ok(_accountService.Register(userModel));
        }
        [HttpPost("login")]
        public ActionResult<UserModel> Register(LoginModel loginModel)
        {
            return Ok(_accountService.Login(loginModel));
        }
    }
}
