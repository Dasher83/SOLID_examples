using SOLID_D.Shared.Interfaces;

namespace SOLID_D.Models.Parties
{
    internal abstract class PartyManager: ICollectivePower
    {
        protected Party _party;

        public PartyManager(Party party)
        {
            _party = party;
        }
        public abstract double OverallBattlePower { get; }

        public double AverageBattlePower
        {
            get
            {
                double averageBattlePower = OverallBattlePower / this._party.Members.Count;
                return averageBattlePower;
            }
        }
    }
}
