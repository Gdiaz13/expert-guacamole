using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace textrpg.Services.CharacterService
{
    public interface ICharacterService
    {
        Task<ServiceResponse<List<Character>>> GetAll();
        Task<ServiceResponse<Character>> GetCharId(int id);
        Task<ServiceResponse<List<Character>>> AddCharacter(Character newCharacter);
    }
}