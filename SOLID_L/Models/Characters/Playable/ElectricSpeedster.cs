namespace SOLID_L.Models.Characters.Playable
{
    internal sealed class ElectricSpeedster : Speedster
    {
        private const double BattlePowerStrengthMultiplier = 0.20;
        private const double BattlePowerSpeedMultiplier = 2.00;
        private const double EvasionCapacitySpeedMultiplier = 2.00;
        private const double EvasionCapacityReflexesMultiplier = 1.00;
        public ElectricSpeedster(string nickname, double strength, double speed, double reflexes) : 
            base(nickname, strength, speed, reflexes, BattlePowerStrengthMultiplier, BattlePowerSpeedMultiplier, EvasionCapacitySpeedMultiplier, EvasionCapacityReflexesMultiplier)
        {
        }
    }
}
