using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryUnit
{
    class Mission
    {
        private string codename;
        private string location;
        private string description;
        private string target;

        public Mission(string codename, string location, string description, string target) 
        {
            this.codename = codename;
            this.location = location;
            this.description = description;
            this.target = target;
        }

        public string updateTarget(string update) => this.target = update;
        public string UpdateLocatioin(string update) => this.location = update; 
    }
}
