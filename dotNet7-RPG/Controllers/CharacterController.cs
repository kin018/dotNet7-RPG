﻿//global using dotNet7_RPG.Models;  Could also be here for global usings or could simply do using dotNet7_RPG.Models; for each controller etc. Like previously

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
      public async Task<ActionResult<ServiceResponse<List<GetCharacterDTO>>>> Get()
      {
         return Ok(await _characterService.GetAllCharacters());
      }

      [HttpGet("{id}")]
      public async Task<ActionResult<ServiceResponse<GetCharacterDTO>>> GetSingleCharacter(int id)
      {
         return Ok(await _characterService.GetCharacterById(id));
      }

      [HttpPost]
      public async Task<ActionResult<ServiceResponse<List<GetCharacterDTO>>>> AddCharacter(AddCharacterDTO newCharacter)
      {
         return Ok(await _characterService.AddCharacter(newCharacter));
      }

      [HttpPut]
      public async Task<ActionResult<ServiceResponse<List<GetCharacterDTO>>>> UpdateCharacter(UpdateCharacterDTO updateCharacter)
      {
         var response = await _characterService.UpdateCharacter(updateCharacter);
         if (response.Data is null)
         {
            return NotFound(response);
         }
         else
         {
            return Ok(response);
         }
      }

      [HttpDelete("{id}")]
      public async Task<ActionResult<ServiceResponse<GetCharacterDTO>>> DeleteCharacterById(int id)
      {
         var response = await _characterService.DeleteCharacterById(id);
         if (response.Data is null)
         {
            return NotFound(response);
         }
         else
         {
            return Ok(response);
         }
      }
   }
}