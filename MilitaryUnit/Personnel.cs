using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryUnit
{
    class Personnel
    {
        private string name;
        protected int age;
        protected double heightInch;
        protected double weightLbs;

        public string Name 
        {
            get 
            {
                return this.name;
            }
        }

        public Personnel() 
        {
            this.name = "This Recruit";
            this.age = 18;
            this.heightInch = 58.0;
            this.weightLbs = 132.0;
        }

        public Personnel(string name, int age, double height, double weight) 
        {
            this.name = name;
            this.age = age;
            this.heightInch = height;
            this.weightLbs = weight;
        }

 

    }
}
