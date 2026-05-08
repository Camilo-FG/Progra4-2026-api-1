using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Progra4_2026_api_1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PokemonController : ControllerBase
    {
        // GET: api/<PokemonController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "Pikachu", "Charmander", "Bulbasaur" };
        }

     
    }
}
