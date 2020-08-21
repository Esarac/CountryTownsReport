using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace CountryTownsReport.Model
{
    public class Department
    {
        //Attributes
        private string name;
        private string id;
        private string region;
        private List<Town> towns;

        //Contructor
        public Department(string name, string id, string region) {
            this.name = name;
            this.id = id;
            this.region = region;
            this.towns = new List<Town>();
        }

        //Methods
        public void AddTown(Town town) {
            this.towns.Add(town);
        }

        public override string ToString(){
            string toString = name +", "+id+", "+region+":";
            for (int i = 0; i < towns.Count; i++){
                toString += "\n\t" + towns[i];
            }
            return toString;
        }

        //Properties
        public string Id {
            get { return id; }
            set { id = value; }
        }

        public List<Town> Towns {
            get { return towns; }
            set { towns = value; }
        }
    }
}
