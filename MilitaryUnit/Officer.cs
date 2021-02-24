using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryUnit
{
    class Officer : Personnel
    {

        private OfficerRank officerRank;


        public Officer(string name, OfficerRank rank) : base(name)
        {
            this.officerRank = rank;
        }

        public OfficerRank getRank()
        {
            return officerRank;
        }
    }
}

