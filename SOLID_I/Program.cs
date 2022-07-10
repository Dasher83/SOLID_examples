using SOLID_I.Models.Characters.Playable;
using SOLID_I.Shared.Interfaces;

Mage mage = new Mage(nickname: "Jessica", strength: 20, speed: 75, reflexes: 150, intelligence: 380);
List<IDefensiveMagical> characters = new List<IDefensiveMagical>();
characters.Add(new ElectricSpeedster(
    nickname: "Angelo", strength: 100, speed: 25, reflexes: 50, intelligence: 100));
characters.Add(new WindSpeedster(
    nickname: "Gub", strength: 100, speed: 25, reflexes: 50, intelligence: 100));
characters.Add(mage);
Console.ForegroundColor = ConsoleColor.Green;
foreach(IDefensiveMagical character in characters)
{
    Console.WriteLine($"Character's magical defense is {character.MagicalDefense:0.00}");
    Console.WriteLine();
}
Console.WriteLine($"Mage's magical attack is {mage.MagicalAttack:0.00}");
Console.WriteLine();
Console.ForegroundColor = ConsoleColor.Cyan;
Console.WriteLine("All instances of classes subclassing 'PlayableCharacter' have some degree of inherent magical defense.");
Console.WriteLine("However, only mages can actually use magical attacks.");
Console.WriteLine("This is why instead of a single IMagical interface, we have two separate interfaces: one for magical attacks and another for magical defense.");
Console.WriteLine();
Console.ResetColor();