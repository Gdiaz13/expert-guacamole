using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using textrpg.Models.CharacterClasses;

namespace textrpg.Models.Interfaces
{
    public interface ICharacter
    {

        public int Id { get; set; } 

        // Adding '?' makes the field nullable
        public string? Name { get; set; } 
        public int HP { get; set; } 
        public int Strength { get; set; } 
        public int Defense { get; set; } 
        public int Speed { get; set; }
        public int Intelligence { get; set; } 
        // public int Chakra { get; set; } 
        public int Stamina { get; set; } 
        // public int Taijustu { get; set; }
        // public int Ninjustu { get; set; } 
        // public int Genjustu { get; set; } 
        public CharacterRace Race { get; set; } 
        public CharacterClass Class { get; set; } 

        //thinking of adding a hidden abilities to the character class
        // public HiddenAbilities HiddenAbilities { get; set; } 
    }
}
