using SOLID_L.Models.Characters.Playable;

List<Speedster> speedsters = new List<Speedster>();
speedsters.Add(new Speedster(nickname: "Yangus", strength: 100, speed: 25, reflexes: 50));
speedsters.Add(new ElectricSpeedster(nickname: "Yangus", strength: 100, speed: 25, reflexes: 50));
speedsters.Add(new WindSpeedster(nickname: "Yangus", strength: 100, speed: 25, reflexes: 50));

Console.ForegroundColor = ConsoleColor.Green;
foreach(var speedster in speedsters)
{
    Console.WriteLine($"Speedster's battle power is {speedster.BattlePower:0.00}");
    Console.WriteLine($"Speedster's evasion capacity is {speedster.EvasionCapacity:0.00}");
    Console.WriteLine();
}
Console.ForegroundColor = ConsoleColor.Cyan;
Console.WriteLine("No matter if we use the base class or any of it's sub-classes, the program does not break");
Console.WriteLine();
Console.ResetColor();