using Backend.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using IActionResult = Microsoft.AspNetCore.Mvc.IActionResult;
namespace Backend.Controllers
{
    
    [Route("api/[controller]")]
    [ApiController]
    public class PersonaController : ControllerBase
    {

        private IPersonaServices _personaServices;

        public PersonaController([FromKeyedServices("personaservices")]IPersonaServices personaService)
        {
            _personaServices = personaService;
        }



        [HttpGet("all")]
        public List<PersonaDatos> GetPersonaDatos() => Repository.persona;


        //[HttpGet("{id}")]
        //public PersonaDatos GetPersonaDatos(int id) => Repository.persona.FirstOrDefault(p => p.id == id);


        //[HttpGet("search/{search}")]
        //public List<PersonaDatos> Get(string search) => Repository.persona.Where( p => p.name.Contains(search)).ToList();

        [HttpGet("search/{search}")]
        public List<PersonaDatos> Get(string search) => 
            Repository.persona.Where(p => p.name.ToUpper().Contains(search.ToUpper())).ToList();


        [HttpGet("{id}")]
        public ActionResult<PersonaDatos> Get(int id)
        {
            var persona = Repository.persona.FirstOrDefault(p => p.id == id);
            if (persona == null)
            {
                return NotFound(); //'NotFound()' -> Esto nos ha dado un error
            }
            return Ok(persona);
        }



        [HttpPost]
        public IActionResult Add(PersonaDatos persona)
        {
            if (!_personaServices.validate(persona))
            {
                return BadRequest();
            }
            Repository.persona.Add(persona);
            return NoContent();
        }

    }
}
