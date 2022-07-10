namespace SOLID_I.Models.Parties
{
    internal abstract class PartyManager
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
