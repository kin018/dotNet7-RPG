//global using dotNet7_RPG.Models;  Could also be here for global usings or could simply do using dotNet7_RPG.Models; for each controller etc. Like previously
using Microsoft.AspNetCore.Mvc;

namespace dotNet7_RPG.Controllers
{
   [ApiController]
   [Route("[controller]")]
   public class CharacterController : ControllerBase //since its just an API we use ControllerBase but if we were using a view we derive from controller
   {
      private static List<Character> characters = new List<Character> { 
         new Character(),
         new Character {Name = "Sam" },
      };

      [HttpGet]
      public ActionResult<List<Character>> Get()
      {
         return Ok(characters);
      }

      [HttpGet]
      public ActionResult<Character> GetSingleCharacter()
      {
         return Ok(characters[0]);
      }

   }
}