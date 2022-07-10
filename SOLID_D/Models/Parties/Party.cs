using SOLID_D.Shared.Interfaces;

namespace SOLID_D.Models.Parties
{
    internal class Party: ITeam
    {
        private string _id;
        private List<IPlayableCharacter> _members;
        private IPlayableCharacter _leader;
        private string? _name;
        private DateTime _createdAt;

        public Party(List<IPlayableCharacter> members, IPlayableCharacter leader, string? name = null)
        {
            _id = Guid.NewGuid().ToString();
            _members = members;
            
            if (!_members.Contains(leader))
            {
                throw new ArgumentException("Leader not in member list");
            }

            _leader = leader;
            _name = name;
            _createdAt = DateTime.UtcNow;
        }

        public IPlayableCharacter Leader { get { return _leader; } }
        public List<IPlayableCharacter> Members { get { return _members; } }
        public void AddMember(IPlayableCharacter member)
        {
            _members.Add(member);
        }
    }
}
