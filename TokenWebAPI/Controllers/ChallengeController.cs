using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TokenWebAPI.Bussiness;
using TokenWebAPI.Model;

namespace TokenWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ChallengeController : ControllerBase
    {
        private readonly ITokenManager _tokenManager;
        private readonly IChallenge _challengeRepo;
        public ChallengeController(ITokenManager tokenManager, IChallenge challenge)
        {
            _tokenManager = tokenManager;
            _challengeRepo = challenge;
        }
        /// <summary>
        /// Login for anonymous user which validates credentials and returns token 
        /// </summary>
        /// <param name="userCredential"></param>
        /// <returns></returns>
        [AllowAnonymous]
        [HttpPost("Login")]
        public IActionResult Login([FromBody] UserCredential userCredential)
        {
            var token = _tokenManager.Autheticate(userCredential.UserName, userCredential.Password);

            if (string.IsNullOrEmpty(token))
                return Unauthorized();

            return Ok(token);
        }

        /// <summary>
        /// Get a List of Cars 
        /// </summary>
        /// <returns></returns>
        [Authorize]
        [HttpGet("GetCars")]
        public IActionResult GetCars()
        {
            return Ok(_challengeRepo.GetCars());
        }

        /// <summary>
        /// Add a Car a car details and returns same details with Id
        /// </summary>
        /// <param name="car"></param>
        /// <returns></returns>
        [Authorize]
        [HttpPost("AddCar")]
        public IActionResult AddCar([FromBody] Car car)
        {
            return Ok(_challengeRepo.AddCar(car));
        }
    }
}
