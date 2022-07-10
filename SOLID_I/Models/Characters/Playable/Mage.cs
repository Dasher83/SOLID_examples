using SOLID_I.Shared.Interfaces;

namespace SOLID_I.Models.Characters.Playable
{
    internal  class Mage : PlayableCharacter, IOfensiveMagical
    {
        private const double BattlePowerStrengthMultiplier = 0.20;
        private const double BattlePowerSpeedMultiplier = 0.40;
        private const double EvasionCapacitySpeedMultiplier = 0.50;
        private const double EvasionCapacityReflexesMultiplier = 0.80;
        private const double MagicalDefenseIntelligenceMultiplier = 2.00;
        private const double MagicalAttackIntelligenceMultiplier = 2.00;

        public Mage(string nickname, double strength,
            double speed, double reflexes, double intelligence) :
            base(nickname, strength, speed, reflexes, intelligence,
                BattlePowerStrengthMultiplier, BattlePowerSpeedMultiplier,
                EvasionCapacitySpeedMultiplier, EvasionCapacityReflexesMultiplier,
                MagicalDefenseIntelligenceMultiplier)
        {
        }

        public double MagicalAttack
        {
            get
            {
                return _intelligence * MagicalAttackIntelligenceMultiplier;
            }
        }

        public override double BattlePower
        {
            get
            {
                return base.BattlePower + MagicalAttack;
            }
        }
    }
}
