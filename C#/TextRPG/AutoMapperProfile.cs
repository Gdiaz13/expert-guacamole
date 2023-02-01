using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace textrpg
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Character, GetCharacterResponseDto>(); // Map from Character to GetCharacterResponseDto
            CreateMap<AddCharacterRequestDto, Character>(); // Map from AddCharacterRequestDto to Character
        }
    }
}