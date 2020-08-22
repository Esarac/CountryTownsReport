namespace CountryTownsReport.View
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.bar = new System.Windows.Forms.MenuStrip();
            this.file = new System.Windows.Forms.ToolStripMenuItem();
            this.import = new System.Windows.Forms.ToolStripMenuItem();
            this.panel = new System.Windows.Forms.SplitContainer();
            this.table = new System.Windows.Forms.DataGridView();
            this.panelGroup = new System.Windows.Forms.SplitContainer();
            this.idPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.textfield = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.chartLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.bar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panel)).BeginInit();
            this.panel.Panel1.SuspendLayout();
            this.panel.Panel2.SuspendLayout();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.table)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelGroup)).BeginInit();
            this.panelGroup.Panel1.SuspendLayout();
            this.panelGroup.Panel2.SuspendLayout();
            this.panelGroup.SuspendLayout();
            this.idPanel.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.chartLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
            this.SuspendLayout();
            // 
            // bar
            // 
            this.bar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bar.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.bar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.file});
            this.bar.Location = new System.Drawing.Point(0, 0);
            this.bar.Name = "bar";
            this.bar.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.bar.Size = new System.Drawing.Size(1426, 24);
            this.bar.TabIndex = 0;
            // 
            // file
            // 
            this.file.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.import});
            this.file.Name = "file";
            this.file.Size = new System.Drawing.Size(37, 20);
            this.file.Text = "&File";
            // 
            // import
            // 
            this.import.Name = "import";
            this.import.Size = new System.Drawing.Size(110, 22);
            this.import.Text = "&Import";
            this.import.Click += new System.EventHandler(this.Import_Click);
            // 
            // panel
            // 
            this.panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel.Location = new System.Drawing.Point(0, 24);
            this.panel.Name = "panel";
            // 
            // panel.Panel1
            // 
            this.panel.Panel1.Controls.Add(this.table);
            // 
            // panel.Panel2
            // 
            this.panel.Panel2.Controls.Add(this.panelGroup);
            this.panel.Size = new System.Drawing.Size(1426, 815);
            this.panel.SplitterDistance = 688;
            this.panel.SplitterWidth = 3;
            this.panel.TabIndex = 1;
            this.panel.Text = "splitContainer1";
            // 
            // table
            // 
            this.table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.table.Dock = System.Windows.Forms.DockStyle.Fill;
            this.table.Location = new System.Drawing.Point(0, 0);
            this.table.Name = "table";
            this.table.RowHeadersWidth = 51;
            this.table.Size = new System.Drawing.Size(688, 815);
            this.table.TabIndex = 0;
            this.table.Text = "dataGridView1";
            // 
            // panelGroup
            // 
            this.panelGroup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelGroup.Location = new System.Drawing.Point(0, 0);
            this.panelGroup.Name = "panelGroup";
            this.panelGroup.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // panelGroup.Panel1
            // 
            this.panelGroup.Panel1.Controls.Add(this.idPanel);
            this.panelGroup.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            // 
            // panelGroup.Panel2
            // 
            this.panelGroup.Panel2.Controls.Add(this.chartLayoutPanel);
            this.panelGroup.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.panelGroup.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.panelGroup.Size = new System.Drawing.Size(735, 815);
            this.panelGroup.SplitterDistance = 78;
            this.panelGroup.SplitterWidth = 3;
            this.panelGroup.TabIndex = 0;
            this.panelGroup.Text = "splitContainer1";
            // 
            // idPanel
            // 
            this.idPanel.Controls.Add(this.flowLayoutPanel1);
            this.idPanel.FlowDirection = System.Windows.Forms.FlowDirection.BottomUp;
            this.idPanel.Location = new System.Drawing.Point(0, 0);
            this.idPanel.Name = "idPanel";
            this.idPanel.Padding = new System.Windows.Forms.Padding(112, 32, 38, 0);
            this.idPanel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.idPanel.Size = new System.Drawing.Size(785, 84);
            this.idPanel.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.textfield);
            this.flowLayoutPanel1.Controls.Add(this.searchButton);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(114, 26);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(112, 0, 0, 0);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(623, 24);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // textfield
            // 
            this.textfield.Location = new System.Drawing.Point(115, 3);
            this.textfield.Name = "textfield";
            this.textfield.Size = new System.Drawing.Size(218, 20);
            this.textfield.TabIndex = 0;
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(339, 3);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(80, 20);
            this.searchButton.TabIndex = 1;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            // 
            // chartLayoutPanel
            // 
            this.chartLayoutPanel.AutoScroll = true;
            this.chartLayoutPanel.Controls.Add(this.chart);
            this.chartLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chartLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.chartLayoutPanel.Margin = new System.Windows.Forms.Padding(2);
            this.chartLayoutPanel.Name = "chartLayoutPanel";
            this.chartLayoutPanel.Padding = new System.Windows.Forms.Padding(38, 0, 0, 0);
            this.chartLayoutPanel.Size = new System.Drawing.Size(735, 734);
            this.chartLayoutPanel.TabIndex = 0;
            // 
            // chart
            // 
            this.chart.BackImageAlignment = System.Windows.Forms.DataVisualization.Charting.ChartImageAlignmentStyle.Center;
            chartArea1.Name = "ChartArea1";
            this.chart.ChartAreas.Add(chartArea1);
            this.chart.Dock = System.Windows.Forms.DockStyle.Bottom;
            legend1.Name = "Legend1";
            this.chart.Legends.Add(legend1);
            this.chart.Location = new System.Drawing.Point(41, 3);
            this.chart.Name = "chart";
            this.chart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SemiTransparent;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.IsValueShownAsLabel = true;
            series1.Legend = "Legend1";
            series1.Name = "s";
            this.chart.Series.Add(series1);
            this.chart.Size = new System.Drawing.Size(704, 650);
            this.chart.TabIndex = 1;
            this.chart.Text = "chart";
            title1.Name = "Title";
            title1.Text = "Towns per Department";
            this.chart.Titles.Add(title1);
            // 
            // Window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1426, 839);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.bar);
            this.Name = "Window";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Colombia Manager";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Window_Load);
            this.bar.ResumeLayout(false);
            this.bar.PerformLayout();
            this.panel.Panel1.ResumeLayout(false);
            this.panel.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panel)).EndInit();
            this.panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.table)).EndInit();
            this.panelGroup.Panel1.ResumeLayout(false);
            this.panelGroup.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelGroup)).EndInit();
            this.panelGroup.ResumeLayout(false);
            this.idPanel.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.chartLayoutPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
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
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}

