namespace dotNet7_RPG.Services.CharacterService
{
   public class CharacterService : ICharacterService
   {
      //Add Character List
      private static List<Character> characters = new List<Character> {
         new Character(),
         new Character {Id = 1, Name = "Sam" },
      };

      public async Task<ServiceResponse<List<Character>>> AddCharacter(Character newCharacter)
      {
         var serviceResponse = new ServiceResponse<List<Character>>();
         characters.Add(newCharacter);
         serviceResponse.Data = characters;
         return serviceResponse;
      }

      public async Task<ServiceResponse<List<Character>>> GetAllCharacters()
      {
         var serviceResponse = new ServiceResponse<List<Character>>();
         serviceResponse.Data = characters;
         return serviceResponse;
      }

      public async Task<ServiceResponse<Character>> GetCharacterById(int id)
      {
         //removed if(not null) statement since serviceResponse is of nullable type
         var serviceResponse = new ServiceResponse<Character>();
         var character = characters.FirstOrDefault(c => c.Id == id);
         serviceResponse.Data = character;
         return serviceResponse;
      }
   }
}