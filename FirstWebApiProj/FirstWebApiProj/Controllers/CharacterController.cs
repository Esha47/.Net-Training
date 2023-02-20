using FirstWebApiProj.Models;
using FirstWebApiProj.Service.CharacterService;
using Microsoft.AspNetCore.Mvc; //for the controllerbase have to import it
using System.Collections.Generic; // for the list type

namespace FirstWebApiProj.Controllers
{
    [ApiController] //used to server http responses
    [Route("[controller]")] //controller will be used to access this route
    public class CharacterController : ControllerBase
    {

        private readonly ICharacterService _characterService;
        public CharacterController(ICharacterService characterService)
        {
            _characterService = characterService;
        }

        //[Route("getAll")]
        [HttpGet("getAll")] // this will also return the same as above
        public IActionResult Get()
        {
            return Ok(_characterService.GetAllCharacters()); //OK is status code, it can be cannot found etc or anything else
        }

        // for single character
        [HttpGet("{id}")]
        public IActionResult GetSingle(int id) // for getting the specific use by id
        {
            return Ok(_characterService.GetCharacterById(id)); //OK is status code, it can be cannot found etc or anything else
        }



        // POST Operations
        [HttpPost]
        public IActionResult AddCharacter(Character newCharacter)
        {
            
            return Ok(_characterService.AddCharacter(newCharacter));
        }
    }
}
