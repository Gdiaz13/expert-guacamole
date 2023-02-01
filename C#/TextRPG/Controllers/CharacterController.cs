using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace textrpg.Controllers
{
    /*
    Create: POST
    Read: GET
    Update: PUT
    Delete: DELETE
    */
    [ApiController] // API controllers are a special type of controller that are used to create RESTful APIs such as GET, POST, PUT, DELETE
    [Route("api/[controller]")] // this is the route that the controller will be listening on for example api/Character
    public class CharacterController : ControllerBase
    {
        private readonly ICharacterService _characterService; // this is a private field that will be used to access the CharacterService class
        public CharacterController(ICharacterService characterService)
        {
            _characterService = characterService;
        }

        [HttpGet("{id}")] // An HTTP GET request is used to retrieve data from a server
        //ActionResult is used for returning a response to the client
        // adding the id parameter to the method will allow the method to accept a parameter from the route
        public async Task<ActionResult<ServiceResponse<GetCharacterResponseDto>>> GetCharacter(int id)
        {
            /* c = character in the list
            // => is used to define a lambda expression and specifies where the character Id returned is equal to the id passed in
            // a lambda expression is a shorthand way of writing a method example being 
            (x, y) => x + y is the same as writing public int Add(int x, int y) { return x + y; } 
            */
           // return Ok(_character.FirstOrDefault(c => c.Id == id));
           return Ok(await _characterService.GetCharId(id));
        }


        [HttpGet("GetAll")] 
        public async Task<ActionResult<ServiceResponse<List<GetCharacterResponseDto>>>> GetAll()
        {
            return Ok(await _characterService.GetAll()); // _characterService is being used for accessing the CharacterService class
        }
        
        [HttpPost] // An HTTP POST request is used to send data to the server
        public async Task<ActionResult<ServiceResponse<List<GetCharacterResponseDto>>>> AddCharacter(AddCharacterRequestDto newCharacter)
        {
            return Ok(await _characterService.AddCharacter(newCharacter));
           /* _characters.Add(newCharacter);
            return Ok(_characters); */
        }
    }
}
