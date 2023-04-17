using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using textrpg.DTOs;

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

        public async Task<ServiceResponse<List<GetCharacterResponseDto>>> DeleteCharacter(int id)
        {
            var serviceResponse = new ServiceResponse<List<GetCharacterResponseDto>>();
            try
            {
                var character = _characters.First(c => c.Id == id);
                if (character is null)
                      throw new Exception($"Character with id {id} not found.");

                _characters.Remove(character); // Remove the character from the list of characters

                serviceResponse.Data = _characters.Select(c => _mapper.Map<GetCharacterResponseDto>(c)).ToList(); // Map each character to a GetCharacterResponseDto
               
            }
            catch (Exception ex)
            {
                serviceResponse.Success = false;
                serviceResponse.Message = ex.Message;
            }

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

        public async Task<ServiceResponse<GetCharacterResponseDto>> UpdateCharacter(UpdateCharacterRequestDto updatedCharacter)
        {
            var serviceResponse = new ServiceResponse<GetCharacterResponseDto>();
            try
            {
                
                var character = _characters.FirstOrDefault(c => c.Id == updatedCharacter.Id);
                if (character is null)
                      throw new Exception($"Character with id {updatedCharacter.Id} not found.");

                    _mapper.Map(updatedCharacter,character); // Map the properties from updatedCharacter to character 

                    /* character.Name = updatedCharacter.Name; // Assign Name property manually
                    character.HP = updatedCharacter.HP; // Assign HP property manually
                    character.Strength = updatedCharacter.Strength; // Assign Strength property manually
                    character.Defense = updatedCharacter.Defense; // Assign Defense property manually
                    character.Speed = updatedCharacter.Speed; // Assign Speed property manually
                    character.Stamina = updatedCharacter.Stamina; // Assign Stamina property manually
               
                    serviceResponse.Success = false;
                    serviceResponse.Message = "Character not found.";
                    return Task.FromResult(serviceResponse);*/
                

              

                serviceResponse.Data = _mapper.Map<GetCharacterResponseDto>(character); // Map character to a GetCharacterResponseDto
               
            }
            catch (Exception ex)
            {
                serviceResponse.Success = false;
                serviceResponse.Message = ex.Message;
            }

            return serviceResponse;
          
        }
    }
}