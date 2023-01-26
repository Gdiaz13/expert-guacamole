using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace textrpg.Services.CharacterService
{
    public class CharacterService : ICharacterService // CharacterService implements the ICharacterService interface
    {
         private static List<Character> _characters = new List<Character>
         {
            new Character(),
            new Character { Id = 1 ,Name = "Vegeta", HP = 9000, Strength = 500, Defense = 500, Speed = 500, Intelligence = 500, Race = CharacterRace.Saiyan },
        };
        public async Task<List<Character>> AddCharacter(Character newCharacter)
        {
            _characters.Add(newCharacter);
            return (_characters);
        }

        public async Task<List<Character>> GetAll()
        {
            return _characters;
        }

        public async Task<Character> GetCharId(int id)
        {
            var character = _characters.FirstOrDefault(c => c.Id == id);
            if(character == null)
                return character;


             throw new Exception("Character not found");
            
           
        }
    }
}