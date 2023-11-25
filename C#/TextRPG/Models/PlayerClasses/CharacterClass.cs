using System.Text.Json.Serialization;

namespace textrpg.Models.CharacterClasses
{
     [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum CharacterClass
    {
        Knight = 0,
        Mage = 1,
        Archer = 2,
        Cleric = 3,
        Ninja = 4,
    }
}