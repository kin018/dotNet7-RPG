namespace dotNet7_RPG.Services.CharacterService
{
   public interface ICharacterService
   {
      //Interface gets these 3 methods in essence the methods in character controller 
      List<Character> GetAllCharacters(); //return a list of characters
      List<Character> AddCharacter(Character newCharacter);//Return the list of characters
      Character GetCharacterById(int id);//return single character 
      
   }
}
