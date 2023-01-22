using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SuperHeroWebAPIWithDotNet7.Services.SuperHeroService;

namespace SuperHeroWebAPIWithDotNet7.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SuperHeroController : ControllerBase
    {
        private readonly ISuperHeroService _superHeroService;

        public SuperHeroController(ISuperHeroService superHeroService)
        {
            _superHeroService = superHeroService;
        }

        [HttpGet]
        public async Task<ActionResult<List<SuperHero>>> GetAllHeroes()
        {
            return _superHeroService.GetAllSuperHeroes();
        }

        [HttpGet("{id}")]
        /** The above is the short cut form of the below two lines
        [HttpGet]
        [Route("{id}")]
        */
        public async Task<ActionResult<SuperHero>> GetSingleHero(int id)
        {
            var result = _superHeroService.GetSingleHero(id);

            if (result == null)
                return NotFound("Sorry, this hero isn't conceived yet! Keep dreaming!!!");

            return Ok(result);
        }

        [HttpPost]
        public async Task<ActionResult<List<SuperHero>>> AddHero(SuperHero request)
        {
            var result = _superHeroService.AddHero(request);
            return Ok(result);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<SuperHero>> UpdateHero(int id, SuperHero request)
        {
            var result = _superHeroService.UpdateHero(id, request);

            if (result == null)
                return NotFound("Sorry, this hero isn't conceived yet! Keep dreaming!!!");

            return Ok(result);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<SuperHero>> DeleteHero(int id)
        {
            var result = _superHeroService.DeleteHero(id);

            if (result == null)
                return NotFound("Sorry, this hero isn't conceived yet! Keep dreaming!!!");

            return Ok(result);
        }
    }
}
