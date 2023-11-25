using System.Text.Json.Serialization;

namespace textrpg.Models
{
     [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum CharacterVillage
    {
        HiddenLeaf = 0,
        HiddenSand = 1,
        HiddenCloud = 2,
        HiddenMist = 3,
    }
}