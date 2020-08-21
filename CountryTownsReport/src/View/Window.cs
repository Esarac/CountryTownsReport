using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using CountryTownsReport.Model;

namespace CountryTownsReport.View
{
    public partial class Window : Form
    {
        //Attributes
        private Country country;

        //Constructor
        public Window()
        {
            InitializeComponent();
        }

        //Triggers
        private void Window_Load(object sender, EventArgs e)
        {

        }

        private void Import_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileChooser = new OpenFileDialog();

            if (fileChooser.ShowDialog() == DialogResult.OK)
            {
                this.country = new Country(fileChooser.FileName);
                Console.WriteLine(country);
                CreateTable();
                CreatePieChart();
            }
        }

        //Methods
        private void CreateTable()
        {
            //Config
            table.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            table.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllHeaders;
            //...
            table.DataSource = country.GenerateTable();
        }

        private void CreatePieChart() {
            //Config
            //chart.Size = new Size(1000, 1000);
            //...

            chart.Titles.Add("CHART LOL");
            double totalTowns = country.TotalTowns();
            for (int i = 0; i < country.Departments.Count; i++) {
                double percentage = country.Departments[i].Towns.Count / totalTowns;
                chart.Series["s"].Points.AddXY(country.Departments[i].Name, percentage);
            }


        }
    }
}
