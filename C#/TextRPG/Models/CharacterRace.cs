using System.Text.Json.Serialization;

namespace textrpg.Models
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    // JsonConverter is used to convert the enum to a string to be able to see the enum value in the JSON response
    // Enums are a special type of class that can only have a finite number of values (in this case, 6) and are used to represent a set of constants
    // These races are based on the Dragon Ball series
    public enum CharacterRace
    {
        Human = 0,
        Saiyan = 1,
        Namekian = 2,
        Majin = 3,
        Frieza = 4,
        Android = 5,

    }
}`