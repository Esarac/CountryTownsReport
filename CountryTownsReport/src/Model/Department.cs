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
        private Dictionary<string, Town> towns;

        //Contructor
        public Department(string name, string id, string region) {
            this.name = name;
            this.id = id;
            this.region = region;
            this.towns = new Dictionary<string,Town>();
        }

        //Methods
        public void AddTown(Town town) {
            this.towns.Add(town.Id, town);
        }

        public override string ToString(){
            string toString = name +", "+id+", "+region+":";
            foreach(KeyValuePair<string, Town> townPair in towns) 
            {
                toString += "\n\t" + townPair.Value;
            }
            return toString;
        }

        //Properties
        public string Name {
            get { return name; }
            set { name = value; }
        }

        public string Id {
            get { return id; }
            set { id = value; }
        }

        public string Region {
            get { return region; }
            set { region = value; }
        }

        public Dictionary<string, Town> Towns {
            get { return towns; }
            set { towns = value; }
        }
    }
}
