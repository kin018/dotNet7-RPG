namespace dotNet7_RPG.Services.CharacterService
{
   public interface ICharacterService
   {
      //Interface gets these 3 methods in essence the methods in character controller
      Task<ServiceResponse<List<Character>>> GetAllCharacters(); //return a list of characters

      Task<ServiceResponse<List<Character>>> AddCharacter(Character newCharacter);//Return the list of characters

      Task<ServiceResponse<Character>> GetCharacterById(int id);//return single character
   }
}