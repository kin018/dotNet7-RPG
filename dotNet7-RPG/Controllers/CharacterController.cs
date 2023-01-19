//global using dotNet7_RPG.Models;  Could also be here for global usings or could simply do using dotNet7_RPG.Models; for each controller etc. Like previously
using dotNet7_RPG.Services.CharacterService;
using Microsoft.AspNetCore.Mvc;

namespace dotNet7_RPG.Controllers
{
   [ApiController]
   [Route("[controller]")]
   public class CharacterController : ControllerBase //since its just an API we use ControllerBase but if we were using a view we derive from controller
   {
      private static List<Character> characters = new List<Character> {
         new Character(),
         new Character {Id = 1, Name = "Sam" },
      };

      public CharacterController(ICharacterService characterService)
      {

      }

      //[HttpGet]
      //[Route("[id]")] can do this or the below for routing
      [HttpGet("GetAll")]
      public ActionResult<List<Character>> Get()
      {
         return Ok(characters);
      }

      [HttpGet("{id}")]
      public ActionResult<Character> GetSingleCharacter(int id)
      {
         return Ok(characters.FirstOrDefault(c => c.Id == id));
      }

      [HttpPost]
      public ActionResult<List<Character>> AddCharacter(Character newCharacter) { 
      
         characters.Add(newCharacter);
         return Ok(characters);  
      }
   }
}