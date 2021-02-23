using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryUnit
{
    class Enlisted : Personnel
    {
        private string jobTitle;
        private int mos;
        protected EnlistedRank EnlistedRank;

        public Enlisted() : base() 
        {
            this.jobTitle = "Recruit";
            this.mos = 0;
            EnlistedRank = EnlistedRank.Pvt;
        }

        public Enlisted(string name, int age, double height, double weight, string jobTitle, int mos, EnlistedRank rank) : base(name,age,height, weight) 
        {
            this.jobTitle = jobTitle;
            this.mos = mos;
            this.EnlistedRank = rank;
        }   
    }
}
