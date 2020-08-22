using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
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
                //Console.WriteLine(country);
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
            chart.Series["s"].XValueMember = "REGION";
            chart.Series["s"].YValueMembers = "TOWNS";
            //...
            chart.DataSource = country.GenerateChart();
            chart.DataBind();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            string code = textfield.Text;
            string info = country.SearchTown(code);
            townInfo.Text = info;
        }
    }
}
