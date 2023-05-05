using System;
namespace MortalKombatApi.Services.CharacterService
{
	public interface ICharacterService
	{
        Task<List<Character>> GetAllCharacters();

        Task<Character?> GetSingleCharacter(int id);

        Task<List<Character>> AddCharacter(Character character);

        Task<List<Character>?> UpdateCharacter(int id, Character request);

        Task<List<Character>?> DeleteCharacter(int id);
    }
}

