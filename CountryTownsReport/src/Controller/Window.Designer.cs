namespace CountryTownsReport.Controller
{
    partial class Window
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Window));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.panelGroup = new System.Windows.Forms.SplitContainer();
            this.idPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.townInfo = new System.Windows.Forms.Label();
            this.textfield = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.chartLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel = new System.Windows.Forms.SplitContainer();
            this.table = new System.Windows.Forms.DataGridView();
            this.bar = new System.Windows.Forms.MenuStrip();
            this.file = new System.Windows.Forms.ToolStripMenuItem();
            this.import = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.panelGroup)).BeginInit();
            this.panelGroup.Panel1.SuspendLayout();
            this.panelGroup.Panel2.SuspendLayout();
            this.panelGroup.SuspendLayout();
            this.idPanel.SuspendLayout();
            this.chartLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panel)).BeginInit();
            this.panel.Panel1.SuspendLayout();
            this.panel.Panel2.SuspendLayout();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.table)).BeginInit();
            this.bar.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelGroup
            // 
            resources.ApplyResources(this.panelGroup, "panelGroup");
            this.panelGroup.BackColor = System.Drawing.Color.White;
            this.panelGroup.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelGroup.Name = "panelGroup";
            // 
            // panelGroup.Panel1
            // 
            resources.ApplyResources(this.panelGroup.Panel1, "panelGroup.Panel1");
            this.panelGroup.Panel1.Controls.Add(this.idPanel);
            // 
            // panelGroup.Panel2
            // 
            resources.ApplyResources(this.panelGroup.Panel2, "panelGroup.Panel2");
            this.panelGroup.Panel2.Controls.Add(this.chartLayoutPanel);
            // 
            // idPanel
            // 
            resources.ApplyResources(this.idPanel, "idPanel");
            this.idPanel.BackColor = System.Drawing.Color.White;
            this.idPanel.Controls.Add(this.textfield);
            this.idPanel.Controls.Add(this.searchButton);
            this.idPanel.Controls.Add(this.townInfo);
            this.idPanel.Name = "idPanel";
            // 
            // townInfo
            // 
            resources.ApplyResources(this.townInfo, "townInfo");
            this.townInfo.Name = "townInfo";
            // 
            // textfield
            // 
            resources.ApplyResources(this.textfield, "textfield");
            this.textfield.Name = "textfield";
            // 
            // searchButton
            // 
            resources.ApplyResources(this.searchButton, "searchButton");
            this.searchButton.Name = "searchButton";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // chartLayoutPanel
            // 
            resources.ApplyResources(this.chartLayoutPanel, "chartLayoutPanel");
            this.chartLayoutPanel.BackColor = System.Drawing.Color.White;
            this.chartLayoutPanel.Controls.Add(this.chart);
            this.chartLayoutPanel.Name = "chartLayoutPanel";
            // 
            // chart
            // 
            resources.ApplyResources(this.chart, "chart");
            this.chart.BackImageAlignment = System.Windows.Forms.DataVisualization.Charting.ChartImageAlignmentStyle.Center;
            this.chart.BackImageTransparentColor = System.Drawing.Color.Transparent;
            this.chart.BackSecondaryColor = System.Drawing.Color.Transparent;
            this.chart.BorderSkin.BackColor = System.Drawing.Color.Transparent;
            this.chart.BorderSkin.PageColor = System.Drawing.Color.Transparent;
            chartArea1.Name = "ChartArea1";
            this.chart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart.Legends.Add(legend1);
            this.chart.Name = "chart";
            this.chart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            series1.BackSecondaryColor = System.Drawing.Color.Transparent;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series1.IsValueShownAsLabel = true;
            series1.LabelBackColor = System.Drawing.Color.White;
            series1.LabelBorderColor = System.Drawing.Color.Black;
            series1.Legend = "Legend1";
            series1.Name = "s";
            series1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Chocolate;
            this.chart.Series.Add(series1);
            title1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title1.Name = "Title";
            title1.Text = "TOWNS PER DEPARTMENT";
            this.chart.Titles.Add(title1);
            // 
            // panel
            // 
            resources.ApplyResources(this.panel, "panel");
            this.panel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel.Name = "panel";
            // 
            // panel.Panel1
            // 
            resources.ApplyResources(this.panel.Panel1, "panel.Panel1");
            this.panel.Panel1.Controls.Add(this.table);
            // 
            // panel.Panel2
            // 
            resources.ApplyResources(this.panel.Panel2, "panel.Panel2");
            this.panel.Panel2.Controls.Add(this.panelGroup);
            // 
            // table
            // 
            resources.ApplyResources(this.table, "table");
            this.table.BackgroundColor = System.Drawing.Color.White;
            this.table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.table.Name = "table";
            this.table.ReadOnly = true;
            // 
            // bar
            // 
            resources.ApplyResources(this.bar, "bar");
            this.bar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bar.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.bar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.file});
            this.bar.Name = "bar";
            // 
            // file
            // 
            resources.ApplyResources(this.file, "file");
            this.file.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.import});
            this.file.Name = "file";
            // 
            // import
            // 
            resources.ApplyResources(this.import, "import");
            this.import.Name = "import";
            this.import.Click += new System.EventHandler(this.Import_Click);
            // 
            // Window
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel);
            this.Controls.Add(this.bar);
            this.Name = "Window";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Window_Load);
            this.panelGroup.Panel1.ResumeLayout(false);
            this.panelGroup.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelGroup)).EndInit();
            this.panelGroup.ResumeLayout(false);
            this.idPanel.ResumeLayout(false);
            this.idPanel.PerformLayout();
            this.chartLayoutPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
            this.panel.Panel1.ResumeLayout(false);
            this.panel.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panel)).EndInit();
            this.panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.table)).EndInit();
            this.bar.ResumeLayout(false);
            this.bar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip bar;
        private System.Windows.Forms.ToolStripMenuItem file;
        private System.Windows.Forms.ToolStripMenuItem import;
        private System.Windows.Forms.SplitContainer panel;
        private System.Windows.Forms.DataGridView table;
        private System.Windows.Forms.SplitContainer panelGroup;
        private System.Windows.Forms.FlowLayoutPanel idPanel;
        private System.Windows.Forms.TextBox textfield;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.FlowLayoutPanel chartLayoutPanel;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart;
        private System.Windows.Forms.Label townInfo;
    }
}

