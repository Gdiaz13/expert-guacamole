using textrpg.Models.CharacterClasses;
using textrpg.Models.Interfaces;

namespace textrpg.Models
{
    public class Character : ICharacter
    {
        public int Id { get; set; }
        public string? Name { get; set; } = "Goku";
        public int HP { get; set; } = 9500;
        public int Strength { get; set; } = 600;
        public int Defense { get; set; } = 400;
        public int Speed { get; set; } = 600;
        public int Intelligence { get; set; } = 100;
        public int Stamina { get; set; } = 1000;
        public CharacterRace Race { get; set; } = CharacterRace.Saiyan;
        public CharacterClass Class { get; set; } = CharacterClass.Knight;
        public User? User { get; set; }
    }
}