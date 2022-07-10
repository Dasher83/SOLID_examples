namespace SOLID_L.Models.Parties
{
    internal class DecentralizedParty: PartyManager
    {
        public DecentralizedParty(Party party) : base(party) { }

        public override double OverallBattlePower
        {
            get
            {
                double overallBattlePower = this._party.Members.Sum(member => member.BattlePower);
                return overallBattlePower;
            }
        }
    }
}
