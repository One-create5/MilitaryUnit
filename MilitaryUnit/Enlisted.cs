using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryUnit
{
    class Enlisted : Personnel
    {
 
        private EnlistedRank enlistedRank;

        public Enlisted(string name, EnlistedRank rank) : base(name) 
        {
            this.enlistedRank = rank;
        }

        public EnlistedRank getRank() 
        {
            return enlistedRank;
        }
    }
}
