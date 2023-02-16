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
            CreateMap<UpdateCharacterRequestDto, Character>() // This code creates a mapping from UpdateCharacterRequestDto to Character
                .ForMember(s => s.Name, opt => opt.MapFrom(c => c.Name)) //maps the name from UpdateCharacterRequestDto to Character
                .ForMember(s => s.HP, opt => opt.MapFrom(c => c.HP)) //maps the HP from UpdateCharacterRequestDto to Character
                .ForMember(s => s.Strength, opt => opt.MapFrom(c => c.Strength)) //maps the Strength from UpdateCharacterRequestDto to Character
                .ForMember(s => s.Defense, opt => opt.MapFrom(c => c.Defense)) //maps the Defense from UpdateCharacterRequestDto to Character
                .ForMember(s => s.Speed, opt => opt.MapFrom(c => c.Speed)) //maps the Speed from UpdateCharacterRequestDto to Character
                .ForMember(s => s.Stamina, opt => opt.MapFrom(c => c.Stamina)); //maps the Stamina from UpdateCharacterRequestDto to Character

            
        }
    }
}