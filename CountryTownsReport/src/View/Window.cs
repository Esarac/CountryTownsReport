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
        public Window(){
            InitializeComponent();
        }

        //Triggers
        private void Window_Load(object sender, EventArgs e){

        }

        private void Import_Click(object sender, EventArgs e){
            OpenFileDialog fileChooser = new OpenFileDialog();

            if (fileChooser.ShowDialog() == DialogResult.OK) {
                this.country = new Country(fileChooser.FileName);
                Console.WriteLine(country);
                CreateTable();
            }
        }

        //Methods
        private void CreateTable() {
            //DataGridView table = new DataGridView();
            //Config
            table.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            table.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllHeaders;
            //table.Size = new Size(1000, 1000);
            //...
            table.DataSource = country.GenerateTable();
            //this.Controls.Add(table);
        }
    }
}
