namespace dotNet7_RPG.Services.CharacterService
{
   public interface ICharacterService
   {
      Task<ServiceResponse<List<GetCharacterDTO>>> GetAllCharacters(); //return a list of characters

      Task<ServiceResponse<GetCharacterDTO>> GetCharacterById(int id);//return single character

      Task<ServiceResponse<List<GetCharacterDTO>>> AddCharacter(AddCharacterDTO newCharacter);//Return the list of characters

      Task<ServiceResponse<GetCharacterDTO>> UpdateCharacter(UpdateCharacterDTO updatedCharacter);//return single character

      Task<ServiceResponse<List<GetCharacterDTO>>> DeleteCharacterById(int id);
   }
}