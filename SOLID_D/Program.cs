using SOLID_D.Models.Characters.Playable;
using SOLID_D.Shared.Interfaces;


List<IDefensiveMagical> characters = new List<IDefensiveMagical>();
characters.Add(new ElectricSpeedster(
    nickname: "Angelo", strength: 100, speed: 25, reflexes: 50, intelligence: 100));
characters.Add(new WindSpeedster(
    nickname: "Gub", strength: 100, speed: 25, reflexes: 50, intelligence: 100));
characters.Add(new Mage(nickname: "Jessica", strength: 20, speed: 75, reflexes: 150, intelligence: 380));
Console.ForegroundColor = ConsoleColor.Green;
foreach(IDefensiveMagical character in characters)
{
    Console.WriteLine($"Character's magical defense is {character.MagicalDefense:0.00}");
    Console.WriteLine();
}
IOfensiveMagical mage = (IOfensiveMagical)characters.Last();
Console.WriteLine($"Mage's magical attack is {mage.MagicalAttack:0.00}");
Console.WriteLine();
Console.ForegroundColor = ConsoleColor.Cyan;
Console.WriteLine("All models in this program depend on abstractions.");
Console.WriteLine("You may notice that altough we are only using iterface complient objects...");
Console.WriteLine("this program works just the same as the one in the SOLID_I project.");
Console.WriteLine();
Console.ResetColor();