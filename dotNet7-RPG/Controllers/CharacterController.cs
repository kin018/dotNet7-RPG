//global using dotNet7_RPG.Models;  Could also be here for global usings or could simply do using dotNet7_RPG.Models; for each controller etc. Like previously
using dotNet7_RPG.Services.CharacterService;

namespace dotNet7_RPG.Controllers
{
   [ApiController]
   [Route("[controller]")]
   public class CharacterController : ControllerBase //since its just an API we use ControllerBase but if we were using a view we derive from controller
   {     
      private readonly ICharacterService _characterService;

      //Constructor
      public CharacterController(ICharacterService characterService) //Icharacter chracterService instance  is the injectable dependency
      {
         _characterService = characterService;
      }

      //[HttpGet]
      //[Route("[id]")] can do this or the below for routing
      [HttpGet("GetAll")]
      public ActionResult<List<Character>> Get()
      {
         return Ok(_characterService.GetAllCharacters());
      }

      [HttpGet("{id}")]
      public ActionResult<Character> GetSingleCharacter(int id)
      {
         return Ok(_characterService.GetCharacterById(id));
      }

      [HttpPost]
      public ActionResult<List<Character>> AddCharacter(Character newCharacter) { 
      
         
         return Ok(_characterService.AddCharacter(newCharacter));  
      }
   }
}