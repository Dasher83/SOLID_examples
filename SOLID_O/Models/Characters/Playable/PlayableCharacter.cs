using SOLID_O.Models.Parties;
using SOLID_O.Shared.Interfaces;

namespace SOLID_O.Models.Characters.Playable
{
    internal abstract class PlayableCharacter : IFighter, IIdeable
    {
        private string _id;
        private string _nickname;
        protected double _strength;
        protected double _speed;
        private DateTime _createdAt;
        private Party? _party;

        public PlayableCharacter(string nickname, double strength, double speed)
        {
            _id = Guid.NewGuid().ToString();
            _nickname = nickname;
            _strength = strength;
            _speed = speed;
            _createdAt = DateTime.UtcNow;
        }

        public Party? Party { get { return _party; } }

        public abstract double BattlePower { get; }

        public string Id { get { return this._id; } }
    }
}
