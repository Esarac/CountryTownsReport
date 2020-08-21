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
            chart.Titles.Add("CHART LOL");

            chart.Series["s"].Points.AddXY("johan", 33);
            chart.Series["s"].Points.AddXY("ariza", 34);
            chart.Series["s"].Points.AddXY("hola", 33);
        }
    }
}
