namespace SOLID_D.Models.Characters.Playable
{
    internal class Speedster : PlayableCharacter
    {
        private const double BattlePowerStrengthMultiplier = 0.20;
        private const double BattlePowerSpeedMultiplier = 0.80;
        private const double EvasionCapacitySpeedMultiplier = 2.00;
        private const double EvasionCapacityReflexesMultiplier = 0.20;
        private const double MagicalDefenseIntelligenceMultiplier = 0.30;

        public Speedster(
            string nickname, double strength, double speed, double reflexes, double intelligence,
            double battlePowerStrengthMultiplier = BattlePowerStrengthMultiplier,
            double battlePowerSpeedMultiplier = BattlePowerSpeedMultiplier,
            double evasionCapacitySpeedMultiplier = EvasionCapacitySpeedMultiplier,
            double evasionCapacityReflexesMultiplier = EvasionCapacityReflexesMultiplier,
            double magicalDefenseIntelligenceMultiplier = MagicalDefenseIntelligenceMultiplier) : 
            base(nickname, strength, speed, reflexes, intelligence, 
                battlePowerStrengthMultiplier, battlePowerSpeedMultiplier, 
                evasionCapacitySpeedMultiplier, evasionCapacityReflexesMultiplier,
                magicalDefenseIntelligenceMultiplier)
        {
        }
    }
}
