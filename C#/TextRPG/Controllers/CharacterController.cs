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
        private static List<Character> _characters = new List<Character>{
            new Character(),
            new Character { Id = 1 ,Name = "Vegeta", HP = 9000, Strength = 500, Defense = 500, Speed = 500, Intelligence = 500, Ki = 1000, Race = CharacterRace.Saiyan },
        };

        [HttpGet("{id}")] // An HTTP GET request is used to retrieve data from a server
        //ActionResult is used for returning a response to the client
        // adding the id parameter to the method will allow the method to accept a parameter from the route
        public ActionResult<Character> GetCharacter(int id)
        {
            /* c = character in the list
            // => is used to define a lambda expression and specifies where the character Id returned is equal to the id passed in
            // a lambda expression is a shorthand way of writing a method example being 
            (x, y) => x + y is the same as writing public int Add(int x, int y) { return x + y; } 
            */
            return Ok(_characters.FirstOrDefault(c => c.Id == id));
        }

        [HttpGet("GetAll")] 
        public ActionResult<List<Character>> GetAll()
        {
            return Ok(_characters);
        }
        
        [HttpPost] // An HTTP POST request is used to send data to the server
        public ActionResult<List<Character>> AddCharacter(Character newCharacter)
        {
            _characters.Add(newCharacter);
            return Ok(_characters);
        }
    }
}
