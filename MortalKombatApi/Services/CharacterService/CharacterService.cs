using System;
using Microsoft.AspNetCore.Mvc;
using MortalKombatApi.Models;

namespace MortalKombatApi.Services.CharacterService
{
    public class CharacterService : ICharacterService
    {
        private static List<Character> characters = new List<Character>
        { 
           new Character
           {
              Id = 1,
              Name = "Subzero",
              FirstName = "Kuai",
              LastName = "Liang",
              Sex = "Male",
              Skill = "Ice"

           },
           new Character
           {
              Id = 2,
              Name = "Scorpion",
              FirstName = "Hanzo",
              LastName = "Hasashi",
              Sex = "Male",
              Skill = "Snake"

           }
         };

        public List<Character> AddCharacter(Character character)
        {
            characters.Add(character);
            return characters;
        }

        public List<Character>? DeleteCharacter(int id)
        {
            var character = characters.Find(x => x.Id == id);
            if (character is null)
                return null;

            characters.Remove(character);
            return characters;
        }

        public List<Character> GetAllCharacters()
        {
            return characters;
        }

        public Character? GetSingleCharacter(int id)
        {
            var character = characters.Find(x => x.Id == id);
            if (character is null)
                return null;

            return character;

        }

        public List<Character>? UpdateCharacter(int id, Character request)
        {
            var character = characters.Find(x => x.Id == id);
            if (character is null)
                return null;

                character.Name = request.Name;
                character.FirstName = request.FirstName;
                character.LastName = request.LastName;
                character.Sex = request.Sex;
                character.Skill = request.Skill;

            return characters;
        }
    }
}

