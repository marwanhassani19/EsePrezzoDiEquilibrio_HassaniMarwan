namespace EsePrezzoDiEquilibrio_HassaniMarwan
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        // 🔹 DICHIARAZIONI CONTROLLI
        private System.Windows.Forms.Label labelDomanda;
        private System.Windows.Forms.Label labelOfferta;
        private System.Windows.Forms.Label labelA;
        private System.Windows.Forms.Label labelB;
        private System.Windows.Forms.Label labelDeltaQ;

        private System.Windows.Forms.TextBox textBoxDomanda;
        private System.Windows.Forms.TextBox textBoxOfferta;
        private System.Windows.Forms.TextBox textBoxA;
        private System.Windows.Forms.TextBox textBoxB;
        private System.Windows.Forms.TextBox textBoxDeltaQ;

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;


        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }


        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.labelDomanda = new System.Windows.Forms.Label();
            this.textBoxDomanda = new System.Windows.Forms.TextBox();
            this.labelOfferta = new System.Windows.Forms.Label();
            this.textBoxOfferta = new System.Windows.Forms.TextBox();
            this.labelA = new System.Windows.Forms.Label();
            this.textBoxA = new System.Windows.Forms.TextBox();
            this.labelB = new System.Windows.Forms.Label();
            this.textBoxB = new System.Windows.Forms.TextBox();
            this.labelDeltaQ = new System.Windows.Forms.Label();
            this.textBoxDeltaQ = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(480, 30);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "Domanda";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Legend = "Legend1";
            series2.Name = "Offerta";
            this.chart1.Series.Add(series1);
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(630, 380);
            this.chart1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.Location = new System.Drawing.Point(20, 30);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(450, 380);
            this.dataGridView1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(350, 500);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(300, 60);
            this.button1.TabIndex = 12;
            this.button1.Text = "Calcola";
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // labelDomanda
            // 
            this.labelDomanda.AutoSize = true;
            this.labelDomanda.Location = new System.Drawing.Point(20, 430);
            this.labelDomanda.Name = "labelDomanda";
            this.labelDomanda.Size = new System.Drawing.Size(143, 19);
            this.labelDomanda.TabIndex = 2;
            this.labelDomanda.Text = "Domanda iniziale (D₀):";
            // 
            // textBoxDomanda
            // 
            this.textBoxDomanda.Location = new System.Drawing.Point(200, 427);
            this.textBoxDomanda.Name = "textBoxDomanda";
            this.textBoxDomanda.Size = new System.Drawing.Size(100, 25);
            this.textBoxDomanda.TabIndex = 3;
            this.textBoxDomanda.Text = "90";
            // 
            // labelOfferta
            // 
            this.labelOfferta.AutoSize = true;
            this.labelOfferta.Location = new System.Drawing.Point(350, 430);
            this.labelOfferta.Name = "labelOfferta";
            this.labelOfferta.Size = new System.Drawing.Size(127, 19);
            this.labelOfferta.TabIndex = 4;
            this.labelOfferta.Text = "Offerta iniziale (O₀):";
            // 
            // textBoxOfferta
            // 
            this.textBoxOfferta.Location = new System.Drawing.Point(500, 427);
            this.textBoxOfferta.Name = "textBoxOfferta";
            this.textBoxOfferta.Size = new System.Drawing.Size(100, 25);
            this.textBoxOfferta.TabIndex = 5;
            this.textBoxOfferta.Text = "10";
            // 
            // labelA
            // 
            this.labelA.AutoSize = true;
            this.labelA.Location = new System.Drawing.Point(20, 470);
            this.labelA.Name = "labelA";
            this.labelA.Size = new System.Drawing.Size(164, 19);
            this.labelA.TabIndex = 6;
            this.labelA.Text = "Coefficiente domanda (a):";
            // 
            // textBoxA
            // 
            this.textBoxA.Location = new System.Drawing.Point(200, 467);
            this.textBoxA.Name = "textBoxA";
            this.textBoxA.Size = new System.Drawing.Size(100, 25);
            this.textBoxA.TabIndex = 7;
            this.textBoxA.Text = "-1";
            // 
            // labelB
            // 
            this.labelB.AutoSize = true;
            this.labelB.Location = new System.Drawing.Point(350, 470);
            this.labelB.Name = "labelB";
            this.labelB.Size = new System.Drawing.Size(147, 19);
            this.labelB.TabIndex = 8;
            this.labelB.Text = "Coefficiente offerta (b):";
            // 
            // textBoxB
            // 
            this.textBoxB.Location = new System.Drawing.Point(500, 467);
            this.textBoxB.Name = "textBoxB";
            this.textBoxB.Size = new System.Drawing.Size(100, 25);
            this.textBoxB.TabIndex = 9;
            this.textBoxB.Text = "1";
            // 
            // labelDeltaQ
            // 
            this.labelDeltaQ.AutoSize = true;
            this.labelDeltaQ.Location = new System.Drawing.Point(20, 510);
            this.labelDeltaQ.Name = "labelDeltaQ";
            this.labelDeltaQ.Size = new System.Drawing.Size(161, 19);
            this.labelDeltaQ.TabIndex = 10;
            this.labelDeltaQ.Text = "Variazione quantità (ΔQ):";
            // 
            // textBoxDeltaQ
            // 
            this.textBoxDeltaQ.Location = new System.Drawing.Point(200, 507);
            this.textBoxDeltaQ.Name = "textBoxDeltaQ";
            this.textBoxDeltaQ.Size = new System.Drawing.Size(100, 25);
            this.textBoxDeltaQ.TabIndex = 11;
            this.textBoxDeltaQ.Text = "10";
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(1169, 659);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.labelDomanda);
            this.Controls.Add(this.textBoxDomanda);
            this.Controls.Add(this.labelOfferta);
            this.Controls.Add(this.textBoxOfferta);
            this.Controls.Add(this.labelA);
            this.Controls.Add(this.textBoxA);
            this.Controls.Add(this.labelB);
            this.Controls.Add(this.textBoxB);
            this.Controls.Add(this.labelDeltaQ);
            this.Controls.Add(this.textBoxDeltaQ);
            this.Controls.Add(this.button1);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.Name = "Form1";
            this.Text = "Prezzo di Equilibrio";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
