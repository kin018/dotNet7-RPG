﻿using dotNet7_RPG.Models;

namespace dotNet7_RPG.Services.CharacterService
{
   public class CharacterService : ICharacterService
   {
      //Add Character List
      private static List<Character> characters = new List<Character> {
         new Character(),
         new Character {Id = 1, Name = "Sam" },
      };
      public List<Character> AddCharacter(Character newCharacter)
      {
         characters.Add(newCharacter);
         return characters;
      }

      public List<Character> GetAllCharacters()
      {
         return characters;
      }

      public Character GetCharacterById(int id)
      {
         return characters.FirstOrDefault(c => c.Id == id); //returns a character where the 1st Character id == given id
      }
   }
}
