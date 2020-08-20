using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Linq;

namespace CountryTownsReport.Model
{
    public class Country
    {
        //Attributes
        private List<Department> departments;

        //Contructor
        public Country(string path) {
            this.departments = new List<Department>();
            Load(path);
        }

        //Methods
        public void Load(string path) {
            string[] info = Read(path).Split('\n'); ;

            for (int i = 1; i < info.Length; i++) {
                string[] townInfo = info[i].Split(',');

                bool found = false;
                for (int j = 0; (j < departments.Count) && (!found); j++){
                    if (townInfo[1].Equals(departments[j].Id)) {
                        departments[j].AddTown(new Town(townInfo[4], townInfo[3]));
                        found = true;
                    }
                }                   
                if(!found){
                    Department newDepartment = new Department(townInfo[2], townInfo[1], townInfo[0]);
                    newDepartment.AddTown(new Town(townInfo[4], townInfo[3]));
                    departments.Add(newDepartment);
                }
            }
        }

        public string Read(string path) {
            string info = "";

            StreamReader streamReader = File.OpenText(path);
            string currentLine = "";
            while ((currentLine = streamReader.ReadLine()) != null)
            {
                info += "\n" + currentLine;
            }
            streamReader.Close();

            return info;
        }

        public override string ToString(){
            string toString = "--Country--";
            for (int i = 0; i < departments.Count; i++) {
                toString += "\n" + departments[i];
            }
            return toString;
        }

    }
}
