using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace textrpg.Services.CharacterService
{
    public interface ICharacterService
    {
        Task<List<Character>> GetAll();
        Task<Character> GetCharId(int id);
        Task<List<Character>> AddCharacter(Character newCharacter);
    }
}