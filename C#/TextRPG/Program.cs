global using textrpg.Models; // This is a global using statement that allows us to use the Models namespace without having to import it in every file
global using textrpg.Services.CharacterService; 
global using textrpg.DTOs.Character; // This is a global using statement that allows us to use the DTOs namespace without having to import it in every file
global using AutoMapper; // This is a global using statement that allows us to use the AutoMapper namespace without having to import it in every file

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddAutoMapper(typeof(Program).Assembly); // This is a dependency injection service that allows us to use the AutoMapper class in the Program class
builder.Services.AddScoped<ICharacterService, CharacterService>(); // This is a dependency injection service that allows us to use the CharacterService class in the ICharacterService interfaced

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();


/*
 mother gave idea to make a game where you search for a lost woman finding clues throughout the area was very specific about adding references to sunflowers. 
 Will come back to this idea later.
Features to add
- connect to a database
- Have a player created an account using their email/username and password (maybe have a way to verify the email)
- Add a way to save the character to a database
- Change setting from DBZ to Naruto Ninjas
- Add a way to add items to the character
- Add a way to add skills to the character
- Add a way to add quests to the character
- Add a way to add to join a party
- Add a way to add to join a guild
- Add a way to have a random chance of being born with a special ability/clan
- Add different Villages to choose from
- Add a feature to be able to challenge other players to a duel
- Have NPCs that can be challenged to a duel
- NPCS will react differently to the player depending on their village (and maybe clan...)
- Attacking players from other villages in alliance with their village will cause the player to lose reputation
- Village leaders will have a way to challenge other village leaders to a duel or a war
- Using a skill will cause the player to lose chakra/ stamina
- Using a skill will increase the player's chakra/stamina
- Using a skill will let the skill gain experience
- Using a skill will let the skill level up
- Using a skill will let the skill gain a new ability or get stronger
- add different types of skills
- add different types of items
- add different types of quests
- add different weather conditions


*/
