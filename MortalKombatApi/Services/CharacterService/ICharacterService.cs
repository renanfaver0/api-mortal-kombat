using System;
namespace MortalKombatApi.Services.CharacterService
{
	public interface ICharacterService
	{
        List<Character> GetAllCharacters();

        Character? GetSingleCharacter(int id);

        List<Character> AddCharacter(Character character);

        List<Character>? UpdateCharacter(int id, Character request);

        List<Character>? DeleteCharacter(int id);
    }
}

