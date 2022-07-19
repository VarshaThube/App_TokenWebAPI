using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TokenWebAPI.Model;

namespace TokenWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TokenController : ControllerBase
    {
        private readonly ITokenManager _tokenManager;
        public TokenController(ITokenManager tokenManager)
        {
            _tokenManager = tokenManager;
        }
        [AllowAnonymous]
        [HttpPost("Authenticate")]
        public IActionResult Authenticate([FromBody] UserCredential userCredential)
        {
            var token = _tokenManager.Autheticate(userCredential.UserName, userCredential.Password);

            if(string.IsNullOrEmpty(token))
                return Unauthorized();

            return Ok(token);
        }
    }
}
