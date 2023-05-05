using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MortalKombatApi.Models;

namespace MortalKombatApi.Services.CharacterService
{
    public class CharacterService : ICharacterService
    {
        private readonly DataContext _context;

        public CharacterService(DataContext context)
        {
            _context = context;
        }


        public async Task<List<Character>> AddCharacter(Character character)
        {
            _context.Characters.Add(character);
            await _context.SaveChangesAsync();

            return await _context.Characters.ToListAsync();
        }

        public async Task<List<Character>?> DeleteCharacter(int id)
        {
            var character = await _context.Characters.FindAsync(id);
            if (character is null)
                return null;

            _context.Characters.Remove(character);
            await _context.SaveChangesAsync();

            return await _context.Characters.ToListAsync();
        }

        public async Task <List<Character>> GetAllCharacters()
        {
            var characters = await _context.Characters.ToListAsync();

            return characters;
        }

        public async Task<Character?> GetSingleCharacter(int id)
        {
            var character = await _context.Characters.FindAsync(id);
            if (character is null)
                return null;

            return character;

        }

        public async Task<List<Character>?> UpdateCharacter(int id, Character request)
        {
            var character = await _context.Characters.FindAsync(id);
            if (character is null)
                return null;

                character.Name = request.Name;
                character.FirstName = request.FirstName;
                character.LastName = request.LastName;
                character.Sex = request.Sex;
                character.Skill = request.Skill;

                await _context.SaveChangesAsync();

            return await _context.Characters.ToListAsync();
        }
    }
}

