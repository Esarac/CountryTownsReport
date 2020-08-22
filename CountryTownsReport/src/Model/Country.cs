using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Linq;
using System.Data;

namespace CountryTownsReport.Model
{
    public class Country
    {
        //Attributes
        private Dictionary<string, Department> departments;

        //Contructor
        public Country(string path) {
            this.departments = new Dictionary<string, Department>();
            Load(path);
        }

        //Methods
        public int TotalTowns() {
            int total = 0;
            foreach (KeyValuePair<string, Department> departmentPair in departments)
            {
                total += departmentPair.Value.Towns.Count;
            }
            return total;
        }

        public DataTable GenerateTable() {
            DataTable table = new DataTable();

            //Region
            DataColumn region = new DataColumn();
            region.DataType = Type.GetType("System.String");
            region.ColumnName = "REGION";
            table.Columns.Add(region);
            //DepartmentId
            DataColumn departmentId = new DataColumn();
            departmentId.DataType = Type.GetType("System.String");
            departmentId.ColumnName = "DEPARTMENT DANE ID";
            table.Columns.Add(departmentId);
            //Department
            DataColumn department = new DataColumn();
            department.DataType = Type.GetType("System.String");
            department.ColumnName = "DEPARTMENT";
            table.Columns.Add(department);
            //TownId
            DataColumn townId = new DataColumn();
            townId.DataType = Type.GetType("System.String");
            townId.ColumnName = "TOWN DANE ID";
            table.Columns.Add(townId);
            //Town
            DataColumn town = new DataColumn();
            town.DataType = Type.GetType("System.String");
            town.ColumnName = "TOWN";
            table.Columns.Add(town);

            foreach (KeyValuePair<string, Department> departmentPair in departments)
            {
                foreach (KeyValuePair<string, Town> townPair in departmentPair.Value.Towns) 
                {
                    DataRow row = table.NewRow();

                    row["REGION"] = departmentPair.Value.Region;
                    row["DEPARTMENT DANE ID"] = departmentPair.Value.Id;
                    row["DEPARTMENT"] = departmentPair.Value.Name;
                    row["TOWN DANE ID"] = townPair.Value.Id;
                    row["TOWN"] = townPair.Value.Name;

                    table.Rows.Add(row);
                }
            }

            return table;
        }

        public void Load(string path) {
            string[] info = Read(path).Split('\n'); ;

            for (int i = 1; i < info.Length; i++) {

                string[] townInfo = info[i].Split(',');
                if (townInfo.Length > 5) {
                    string[] townInfoPro = new string[5];

                    int infoIndex = 0;
                    bool open = false;

                    for (int j = 0; j < townInfo.Length; j++) {

                        if (townInfo[j][0] == '"') {

                            open = true;
                            townInfoPro[infoIndex] = townInfo[j].Substring(1, townInfo[j].Length - 1)+",";

                        }
                        else {

                            if (open){

                                if (townInfo[j][townInfo[j].Length - 1] == '"'){

                                    open = false;
                                    townInfoPro[infoIndex] += townInfo[j].Substring(0, townInfo[j].Length - 1);
                                    infoIndex++;

                                }
                                else{

                                    townInfoPro[infoIndex] += townInfo[j]+",";

                                }

                            }
                            else{

                                townInfoPro[infoIndex] = townInfo[j];
                                infoIndex++;

                            }

                        }

                    }

                    townInfo = townInfoPro;
                }

                try
                {
                    departments[townInfo[1]].AddTown(new Town(townInfo[4], townInfo[3]));
                }
                catch (KeyNotFoundException)
                {
                    Department newDepartment = new Department(townInfo[2], townInfo[1], townInfo[0]);
                    newDepartment.AddTown(new Town(townInfo[4], townInfo[3]));
                    departments.Add(newDepartment.Id, newDepartment);
                }
            }
        }

        public string Read(string path) {
            string info = "";

            StreamReader streamReader = File.OpenText(path);
            string currentLine = "";
            bool first = true;
            while ((currentLine = streamReader.ReadLine()) != null)
            {
                if (first)
                    first = false;
                else
                    info += "\n";

                info += currentLine;
            }
            streamReader.Close();

            return info;
        }

        public override string ToString(){
            string toString = "--Country--";
            foreach (KeyValuePair<string, Department> departmentPair in departments) 
            {
                toString += "\n" + departmentPair.Value;
            }
            return toString;
        }

        //Properties
        public Dictionary<string, Department> Departments {
            get { return departments; }
            set { departments = value; }
        }

    }
}
