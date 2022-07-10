using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_O.Models.Parties
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
