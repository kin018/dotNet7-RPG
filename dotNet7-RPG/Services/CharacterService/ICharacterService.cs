namespace dotNet7_RPG.Services.CharacterService
{
   public interface ICharacterService
   {
      //Interface gets these 3 methods in essence the methods in character controller
      Task<ServiceResponse<List<GetCharacterDTO>>> GetAllCharacters(); //return a list of characters

      Task<ServiceResponse<GetCharacterDTO>> GetCharacterById(int id);//return single character

      Task<ServiceResponse<List<GetCharacterDTO>>> AddCharacter(AddCharacterDTO newCharacter);//Return the list of characters

      Task<ServiceResponse<GetCharacterDTO>> UpdateCharacter(UpdateCharacterDTO updatedCharacter);//return single character
   }
}