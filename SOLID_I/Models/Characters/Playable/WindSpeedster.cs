namespace SOLID_I.Models.Characters.Playable
{
    internal sealed class WindSpeedster : Speedster
    {
        private const double BattlePowerStrengthMultiplier = 0.20;
        private const double BattlePowerSpeedMultiplier = 1.20;
        private const double EvasionCapacitySpeedMultiplier = 4.00;
        private const double EvasionCapacityReflexesMultiplier = 0.05;
        private const double MagicalDefenseIntelligenceMultiplier = 0.30;
        public WindSpeedster(string nickname, double strength, 
            double speed, double reflexes, double intelligence) : 
            base(nickname, strength, speed, reflexes, intelligence, 
                BattlePowerStrengthMultiplier, BattlePowerSpeedMultiplier, 
                EvasionCapacitySpeedMultiplier, EvasionCapacityReflexesMultiplier,
                MagicalDefenseIntelligenceMultiplier)
        {
        }
    }
}
