namespace SOLID_I.Models.Parties
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
