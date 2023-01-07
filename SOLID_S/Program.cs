using SOLID_S.Models;
using SOLID_S.Models.Characters.Playable;

Player playerOne = new Player(username: "Dasher");
playerOne.AddCharacter(new Tank(nickname: "Yangus", strength: 100, speed: 25));
playerOne.AddCharacter(new Speedster(nickname: "Angelo", strength: 50, speed: 100));
Party party = new Party(members: playerOne.Characters, name: "Some awesome party");
Console.WriteLine($"The overall battle power of the party is {party.OverallBattlePower:0.00}");
Console.WriteLine($"The average battle power of the party is {party.AverageBattlePower:0.00}");
