using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace textrpg.Models
{
    public class Character
    {
        public int Id { get; set; }

        // Adding '?' makes the field nullable
        public string? Name { get; set; } = "Goku";
        public int HP { get; set; } = 9500;
        public int Strength { get; set; } = 600;
        public int Defense { get; set; } = 400;
        public int Speed { get; set; } = 600;
        public int Intelligence { get; set; } = 100;
        public int Ki { get; set; } = 1000;
        public CharacterRace Race { get; set; } = CharacterRace.Saiyan;

        
    }
}