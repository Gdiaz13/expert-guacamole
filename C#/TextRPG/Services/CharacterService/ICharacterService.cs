using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using textrpg.DTOs;
using textrpg.DTOs.Character;

namespace textrpg.Services.CharacterService
{
    public interface ICharacterService
    {
        Task<ServiceResponse<List<GetCharacterResponseDto>>> GetAll();
        Task<ServiceResponse<GetCharacterResponseDto>> GetCharId(int id);
        Task<ServiceResponse<List<GetCharacterResponseDto>>> AddCharacter(AddCharacterRequestDto newCharacter);

        Task<ServiceResponse<GetCharacterResponseDto>> UpdateCharacter(UpdateCharacterRequestDto updatedCharacter);
    }
}