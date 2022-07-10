namespace SOLID_L.Models.Characters.Playable
{
    internal sealed class WindSpeedster : Speedster
    {
        private const double BattlePowerStrengthMultiplier = 0.20;
        private const double BattlePowerSpeedMultiplier = 1.20;
        private const double EvasionCapacitySpeedMultiplier = 4.00;
        private const double EvasionCapacityReflexesMultiplier = 0.05;
        public WindSpeedster(string nickname, double strength, double speed, double reflexes) : 
            base(nickname, strength, speed, reflexes, BattlePowerStrengthMultiplier, BattlePowerSpeedMultiplier, EvasionCapacitySpeedMultiplier, EvasionCapacityReflexesMultiplier)
        {
        }
    }
}
