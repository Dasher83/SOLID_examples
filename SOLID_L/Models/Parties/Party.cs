using SOLID_L.Shared.Interfaces;

namespace SOLID_L.Models.Parties
{
    internal class Party
    {
        private string _id;
        private List<IFighter> _members;
        private IFighter _leader;
        private string? _name;
        private DateTime _createdAt;

        public Party(List<IFighter> members, IFighter leader, string? name = null)
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

        public IFighter Leader { get { return _leader; } }
        public List<IFighter> Members { get { return _members; } }
        public void AddMember(IFighter member)
        {
            _members.Add(member);
        }
    }
}
