using SOLID_L.Models.Parties;
using SOLID_L.Shared.Interfaces;

namespace SOLID_L.Models.Characters.Playable
{
    internal abstract class PlayableCharacter : IFighter, IIdeable
    {
        private string _id;
        private string _nickname;
        protected double _strength;
        protected double _speed;
        protected double _reflexes;
        private DateTime _createdAt;
        private Party? _party;

        protected readonly double _battlePowerStrengthMultiplier;
        protected readonly double _battlePowerSpeedMultiplier;
        protected readonly double _evasionCapacitySpeedMultiplier;
        protected readonly double _evasionCapacityReflexesMultiplier;

        public PlayableCharacter(
            string nickname, double strength, double speed, double reflexes, 
            double battlePowerStrengthMultiplier, double battlePowerSpeedMultiplier, 
            double evasionCapacitySpeedMultiplier, double evasionCapacityReflexesMultiplier)
        {
            _id = Guid.NewGuid().ToString();
            _nickname = nickname;
            _strength = strength;
            _speed = speed;
            _createdAt = DateTime.UtcNow;
            _reflexes = reflexes;
            _battlePowerStrengthMultiplier = battlePowerStrengthMultiplier;
            _battlePowerSpeedMultiplier = battlePowerSpeedMultiplier;
            _evasionCapacitySpeedMultiplier = evasionCapacitySpeedMultiplier;
            _evasionCapacityReflexesMultiplier = evasionCapacityReflexesMultiplier;
        }

        public Party? Party { get { return _party; } }

        public double BattlePower
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

        public string Id { get { return this._id; } }
    }
}
