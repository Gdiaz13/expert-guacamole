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

        private readonly IMapper _mapper;
        public CharacterService(IMapper mapper)
        {
            _mapper = mapper;
        }
        public async Task<ServiceResponse<List<GetCharacterResponseDto>>> AddCharacter(AddCharacterRequestDto newCharacter)
        {
            var serviceResponse = new ServiceResponse<List<GetCharacterResponseDto>>();
            var character = _mapper.Map<Character>(newCharacter); // Map newCharacter to a Character
            character.Id = _characters.Max(c => c.Id) + 1; // Set the Id of the new character to the max Id + 1
            _characters.Add(character); // Add the new character to the list of characters
            serviceResponse.Data = _characters.Select(c => _mapper.Map<GetCharacterResponseDto>(c)).ToList(); // Map each character to a GetCharacterResponseDto
            return serviceResponse;
        }

        public async Task<ServiceResponse<List<GetCharacterResponseDto>>> GetAll()
        {
            var serviceResponse = new ServiceResponse<List<GetCharacterResponseDto>>();
            serviceResponse.Data = _characters.Select(c => _mapper.Map<GetCharacterResponseDto>(c)).ToList();
            return serviceResponse;
        }

        public async Task<ServiceResponse<GetCharacterResponseDto>> GetCharId(int id)
        {
            var serviceResponse = new ServiceResponse<GetCharacterResponseDto>();
            var character = _characters.FirstOrDefault(c => c.Id == id);
            serviceResponse.Data = _mapper.Map<GetCharacterResponseDto>(character);
            return serviceResponse;
           /* var character = _characters.FirstOrDefault(c => c.Id == id);
            if(character == null)
                return character;


             throw new Exception("Character not found"); */   
           
        }
    }
}