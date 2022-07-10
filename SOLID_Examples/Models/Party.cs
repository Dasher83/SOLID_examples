using SOLID_S.Shared.Interfaces;

namespace SOLID_S.Models
{
    internal class Party
    {
        private string id;
        private List<IFighter> members;
        private string? name;
        private DateTime createdAt;

        public Party(List<IFighter> members, string? name = null)
        {
            id = Guid.NewGuid().ToString();
            this.members = members;
            this.name = name;
            createdAt = DateTime.UtcNow;
        }

        public void AddMember(IFighter member)
        {
            members.Add(member);
        }

        public double OverallBattlePower
        {
            get
            {
                return members.Sum(m => m.BattlePower);
            }
        }

        public double AverageBattlePower
        {
            get
            {
                return OverallBattlePower / members.Count;
            }
        }
    }
}
