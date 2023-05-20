using AjayTutoral.Service;
using Microsoft.AspNetCore.Mvc;

namespace AjayTutoral.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AjayTutorialController : ControllerBase
    {
        private readonly IChallengeService _challengeService;

        public AjayTutorialController(IChallengeService challengeService)
        {
            _challengeService = challengeService;
        }

        [HttpGet(Name = "GetTournamentsById")]
        public async Task<IActionResult> Get()
        {
            var matches = await _challengeService.GetChallenges();
            return Ok(matches);
        }
    }
}