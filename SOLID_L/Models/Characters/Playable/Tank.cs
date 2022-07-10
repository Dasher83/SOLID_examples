namespace SOLID_L.Models.Characters.Playable
{
    internal sealed class Tank : PlayableCharacter
    {
        private const double BattlePowerStrengthMultiplier = 0.80;
        private const double BattlePowerSpeedMultiplier = 0.20;
        private const double EvasionCapacitySpeedMultiplier = 0.20;
        private const double EvasionCapacityReflexesMultiplier = 0.70;
        public Tank(string nickname, double strength, double speed, double reflexes) : 
            base(nickname, strength, speed, reflexes, BattlePowerStrengthMultiplier, BattlePowerSpeedMultiplier, EvasionCapacitySpeedMultiplier, EvasionCapacityReflexesMultiplier)
        {
        }
    }
}
