using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MortalKombatApi.Services.CharacterService;

namespace MortalKombatApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class CharacterController : ControllerBase
    {
        private readonly ICharacterService  _characterService;

        public CharacterController(ICharacterService characterService)
        {
            _characterService = characterService;
        }

        // GET: api/all characters
        [HttpGet]

        public async Task<ActionResult<List<Character>>> GetAllCharacters()
        {
            return _characterService.GetAllCharacters();
        }

        // GET: api/characters by id
        [HttpGet("{id}")]

        public async Task<ActionResult<Character>> GetSingleCharacter(int id)
        {
            var result = _characterService.GetSingleCharacter(id);
            if (result is null)
                return NotFound("Character not found");

            return Ok(result);
        }

        [HttpPost]

        public async Task<ActionResult<List<Character>>> AddCharacter(Character character)
        {
            var result = _characterService.AddCharacter(character);
            return Ok(result);
        }

        [HttpPut("{id}")]

        public async Task<ActionResult<List<Character>>> UpdateCharacter(int id, Character request)
        {
            var result = _characterService.UpdateCharacter(id, request);
            if (result is null)
                return NotFound("Character not found");

            return Ok(result);
        }

        [HttpDelete("{id}")]

        public async Task<ActionResult<List<Character>>> DeleteCharacter(int id)
        {
            var result = _characterService.DeleteCharacter(id);
            if (result is null)
                return NotFound("Character not found!");

            return Ok(result);
        }
    }
}
















    