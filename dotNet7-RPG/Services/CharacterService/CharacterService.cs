﻿namespace dotNet7_RPG.Services.CharacterService
{
   public class CharacterService : ICharacterService
   {
      //Add Character List
      private static List<Character> characters = new List<Character> {
         new Character(),
         new Character {Id = 1, Name = "Sam" },
      };

      public async Task<List<Character>> AddCharacter(Character newCharacter)
      {
         characters.Add(newCharacter);
         return characters;
      }

      public async Task<List<Character>> GetAllCharacters()
      {
         return characters;
      }

      public async Task<Character> GetCharacterById(int id)
      {
         var character = characters.FirstOrDefault(c => c.Id == id);
         if (character != null)
         {
            return character;
         }
         else
         {
            throw new Exception("Hey man... say man... Character not found man...");
         }
      }
   }
}