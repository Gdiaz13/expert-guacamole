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
    public class CharacterController(ICharacterService characterService) : ControllerBase
    {
        private readonly ICharacterService _characterService = characterService; // this is a private field that will be used to access the CharacterService class

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
            return Ok(await _characterService.GetCharacterById(id));
        }


        [HttpGet("GetAllCharacters")]
        public async Task<ActionResult<ServiceResponse<List<GetCharacterResponseDto>>>> GetAll()
        {
            return Ok(await _characterService.GetAllCharacters()); // _characterService is being used for accessing the CharacterService class
        }

        [HttpPost("AddCharacter")] // An HTTP POST request is used to send data to the server
        public async Task<ActionResult<ServiceResponse<List<GetCharacterResponseDto>>>> AddCharacter(AddCharacterRequestDto newCharacter)
        {
            return Ok(await _characterService.AddCharacter(newCharacter));
        }

        [HttpPut] // An HTTP PUT request is used to update data on the server
        public async Task<ActionResult<ServiceResponse<GetCharacterResponseDto>>> UpdateCharacter(UpdateCharacterRequestDto updatedCharacter)
        {
            var response = await _characterService.UpdateCharacter(updatedCharacter);
            if (response.Data == null)
            {
                return NotFound(response);
            }
            return Ok(response);
        }
        [HttpDelete("{id}")] // An HTTP DELETE request is used to delete data from the server
        public async Task<ActionResult<ServiceResponse<GetCharacterResponseDto>>> DeleteCharacter(int id)
        {
            var response = await _characterService.DeleteCharacter(id);
            if (response.Data == null)
            {
                return NotFound(response);
            }

            return Ok(response);
        }
    }
}
