using SOLID_S.Shared.Interfaces;

namespace SOLID_S.Models.Characters.Playable
{
    internal abstract class PlayableCharacter : IFighter
    {
        private string id;
        private string nickname;
        protected double strength;
        protected double speed;
        private DateTime createdAt;
        private Party? party;

        public PlayableCharacter(string nickname, double strength, double speed)
        {
            id = Guid.NewGuid().ToString();
            this.nickname = nickname;
            this.strength = strength;
            this.speed = speed;
            createdAt = DateTime.UtcNow;
        }

        public Party? Party { get { return party; } }

        public abstract double BattlePower { get; }
    }
}
