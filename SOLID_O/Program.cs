using SOLID_O.Models;
using SOLID_O.Models.Characters.Playable;
using SOLID_O.Models.Parties;

Player playerOne = new Player(username: "Dasher");
playerOne.AddCharacter(new Tank(nickname: "Yangus", strength: 100, speed: 25));
playerOne.AddCharacter(new Speedster(nickname: "Angelo", strength: 50, speed: 100));
Party party = new Party(
    members: playerOne.Characters,
    leader: playerOne.Characters.First(),
    name: "Some awesome party");

PartyManager centralizedParty = new CentralizedParty(party);
PartyManager decentralizedParty = new DecentralizedParty(party);

Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("Centralized party example");
Console.WriteLine($"The overall battle power of the party is {centralizedParty.OverallBattlePower:0.00}");
Console.WriteLine($"The average battle power of the party is {centralizedParty.AverageBattlePower:0.00}");
Console.WriteLine();
Console.WriteLine();
Console.WriteLine("Decentralized party example");
Console.WriteLine($"The overall battle power of the party is {decentralizedParty.OverallBattlePower:0.00}");
Console.WriteLine($"The average battle power of the party is {decentralizedParty.AverageBattlePower:0.00}");
Console.ResetColor();