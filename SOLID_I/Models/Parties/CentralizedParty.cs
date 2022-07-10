namespace SOLID_I.Models.Parties
{
    internal sealed class CentralizedParty : PartyManager
    {
        private const double LeaderMultiplier = 0.70;

        public CentralizedParty(Party party) : base(party) { }

        public override double OverallBattlePower { 
            get {
                double overallBattlePower = 0;
                overallBattlePower += this._party.Leader.BattlePower * LeaderMultiplier;
                overallBattlePower += this._party.Members.Where(
                    member => member.Id != this._party.Leader.Id).Sum(
                    member => member.BattlePower) * (1 - LeaderMultiplier);
                return overallBattlePower;
            } 
        }
    }
}
