namespace SOLID_D.Models.Characters.Playable
{
    internal  class Tank : PlayableCharacter
    {
        private const double BattlePowerStrengthMultiplier = 0.80;
        private const double BattlePowerSpeedMultiplier = 0.20;
        private const double EvasionCapacitySpeedMultiplier = 0.20;
        private const double EvasionCapacityReflexesMultiplier = 0.70;
        private const double MagicalDefenseIntelligenceMultiplier = 0.10;
        public Tank(string nickname, double strength,
            double speed, double reflexes, double intelligence) :
            base(nickname, strength, speed, reflexes, intelligence,
                BattlePowerStrengthMultiplier, BattlePowerSpeedMultiplier,
                EvasionCapacitySpeedMultiplier, EvasionCapacityReflexesMultiplier,
                MagicalDefenseIntelligenceMultiplier)
        {
        }
    }
}
