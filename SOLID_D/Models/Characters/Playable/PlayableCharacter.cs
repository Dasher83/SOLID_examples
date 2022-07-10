using SOLID_D.Models.Parties;
using SOLID_D.Shared.Interfaces;

namespace SOLID_D.Models.Characters.Playable
{
    internal abstract class PlayableCharacter : IFighter, IDefensiveMagical, IEvader
    {
        private string _id;
        private string _nickname;
        protected double _strength;
        protected double _speed;
        protected double _reflexes;
        protected double _intelligence;
        private DateTime _createdAt;
        private Party? _party;

        protected readonly double _battlePowerStrengthMultiplier;
        protected readonly double _battlePowerSpeedMultiplier;
        protected readonly double _evasionCapacitySpeedMultiplier;
        protected readonly double _evasionCapacityReflexesMultiplier;
        protected readonly double _magicalDefenseIntelligenceMultiplier;

        public PlayableCharacter(
            string nickname, double strength, double speed, double reflexes, double intelligence,
            double battlePowerStrengthMultiplier, double battlePowerSpeedMultiplier, 
            double evasionCapacitySpeedMultiplier, double evasionCapacityReflexesMultiplier,
            double magicalDefenseIntelligenceMultiplier)
        {
            _id = Guid.NewGuid().ToString();
            _nickname = nickname;
            _strength = strength;
            _speed = speed;
            _createdAt = DateTime.UtcNow;
            _reflexes = reflexes;
            _intelligence = intelligence;
            _battlePowerStrengthMultiplier = battlePowerStrengthMultiplier;
            _battlePowerSpeedMultiplier = battlePowerSpeedMultiplier;
            _evasionCapacitySpeedMultiplier = evasionCapacitySpeedMultiplier;
            _evasionCapacityReflexesMultiplier = evasionCapacityReflexesMultiplier;
            _magicalDefenseIntelligenceMultiplier = magicalDefenseIntelligenceMultiplier;
        }

        public virtual double BattlePower
        {
            get
            {
                double battlePower = 0;
                battlePower += _strength * _battlePowerStrengthMultiplier;
                battlePower += _speed * _battlePowerSpeedMultiplier;
                return battlePower;
            }
        }

        public double EvasionCapacity
        {
            get
            {
                double evasionCapacity = 0;
                evasionCapacity += _reflexes * _evasionCapacityReflexesMultiplier;
                evasionCapacity += _speed * _evasionCapacitySpeedMultiplier;
                return evasionCapacity;
            }
        }

        public double MagicalDefense
        {
            get
            {
                double magicalDefense = 0;
                magicalDefense += _intelligence * _magicalDefenseIntelligenceMultiplier; 
                return magicalDefense;
            }
        }

        public string Id { get { return this._id; } }
    }
}
