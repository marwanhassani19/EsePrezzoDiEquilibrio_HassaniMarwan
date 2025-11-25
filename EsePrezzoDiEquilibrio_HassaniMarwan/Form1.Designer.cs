namespace EsePrezzoDiEquilibrio_HassaniMarwan
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();

            // FONT GENERALE FORM
            this.Font = new System.Drawing.Font("Segoe UI", 10F);

            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            chartArea1.BackColor = System.Drawing.Color.WhiteSmoke;
            chartArea1.AxisX.MajorGrid.LineColor = System.Drawing.Color.Gainsboro;
            chartArea1.AxisY.MajorGrid.LineColor = System.Drawing.Color.Gainsboro;
            chartArea1.AxisX.LabelStyle.Font = new System.Drawing.Font("Segoe UI", 9F);
            chartArea1.AxisY.LabelStyle.Font = new System.Drawing.Font("Segoe UI", 9F);

            this.chart1.ChartAreas.Add(chartArea1);

            legend1.Name = "Legend1";
            legend1.Font = new System.Drawing.Font("Segoe UI", 9F);
            legend1.BackColor = System.Drawing.Color.Transparent;

            this.chart1.Legends.Add(legend1);

            this.chart1.Location = new System.Drawing.Point(489, 30);
            this.chart1.Name = "chart1";
            this.chart1.Size = new System.Drawing.Size(491, 379);

            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;

            // Serie DOMANDA
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Color = System.Drawing.Color.RoyalBlue;
            series1.BorderWidth = 3;
            series1.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
            series1.MarkerSize = 8;
            series1.Name = "Domanda";

            // Serie OFFERTA
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Color = System.Drawing.Color.OrangeRed;
            series2.BorderWidth = 3;
            series2.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
            series2.MarkerSize = 8;
            series2.Name = "Offerta";

            this.chart1.Series.Add(series1);
            this.chart1.Series.Add(series2);

            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;

            this.dataGridView1.Location = new System.Drawing.Point(31, 30);
            this.dataGridView1.Size = new System.Drawing.Size(452, 379);

            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.GridColor = System.Drawing.Color.LightGray;

            this.dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.DimGray;
            this.dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.dataGridView1.EnableHeadersVisualStyles = false;

            this.dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(245, 245, 245);
            this.dataGridView1.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dataGridView1.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.LightSteelBlue;
            this.dataGridView1.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;

            this.dataGridView1.RowTemplate.Height = 28;

            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(31, 415);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(949, 94);

            this.button1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.button1.BackColor = System.Drawing.Color.SteelBlue;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.Text = "Calcola";
            this.button1.UseVisualStyleBackColor = false;

            this.button1.Click += new System.EventHandler(this.button1_Click_1);

            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1010, 573);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Prezzo di Equilibrio";

            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
    }
}
