using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace textrpg.Services.CharacterService
{
    public interface ICharacterService
    {
        List<Character> GetAll();
        Character GetCharId(int id);
        List<Character> AddCharacter(Character newCharacter);
    }
}