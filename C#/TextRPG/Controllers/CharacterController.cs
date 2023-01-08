using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace textrpg.Controllers
{
    [ApiController] // API controllers are a special type of controller that are used to create RESTful APIs such as GET, POST, PUT, DELETE
    [Route("api/[controller]")] // this is the route that the controller will be listening on for example api/Character
    public class CharacterController : ControllerBase
    {
        private static List<Character> _characters = new List<Character>{
            new Character(),
            new Character { Name = "Vegeta", HP = 9000, Strength = 500, Defense = 500, Speed = 500, Intelligence = 500, Ki = 1000, Race = CharacterRace.Saiyan },
        };

        [HttpGet("GetCharacter")] // An HTTP GET request is used to retrieve data from a server
        //ActionResult is used for returning a response to the client
        public ActionResult<Character> GetCharacter()
        {
            return Ok(_characters);
        }

        [HttpGet("GetAll")] 
        public ActionResult<List<Character>> GetAll()
        {
            return Ok(_characters);
        }
    }
}
