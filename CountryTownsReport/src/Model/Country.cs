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
        private List<Department> departments;

        //Contructor
        public Country(string path) {
            this.departments = new List<Department>();
            Load(path);
        }

        //Methods
        public int TotalTowns() {
            int total = 0;

            for (int i = 0; i < departments.Count; i++) {
                total += departments[i].Towns.Count;
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

            for (int i = 0; i < departments.Count; i++){
                for (int j = 0; j < departments[i].Towns.Count; j++) {
                    DataRow row = table.NewRow();

                    row["REGION"] = departments[i].Region;
                    row["DEPARTMENT DANE ID"] = departments[i].Id;
                    row["DEPARTMENT"] = departments[i].Name;
                    row["TOWN DANE ID"] = departments[i].Towns[j].Id;
                    row["TOWN"] = departments[i].Towns[j].Name;

                    table.Rows.Add(row);
                }
            }

            return table;
        }

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

        //Properties
        public List<Department> Departments {
            get { return departments; }
            set { departments = value; }
        }

    }
}
