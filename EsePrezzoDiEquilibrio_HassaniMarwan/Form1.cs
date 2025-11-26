using System;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace EsePrezzoDiEquilibrio_HassaniMarwan
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            dataGridView1.Columns.Clear();
            dataGridView1.Columns.Add("quantità", "quantità");
            dataGridView1.Columns.Add("domanda", "domanda");
            dataGridView1.Columns.Add("offerta", "offerta");

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

            this.Font = new Font("Segoe UI", 10F);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();

            if (!double.TryParse(textBoxDomanda.Text, out double D0)) return;
            if (!double.TryParse(textBoxOfferta.Text, out double O0)) return;
            if (!double.TryParse(textBoxA.Text, out double a)) return;
            if (!double.TryParse(textBoxB.Text, out double b)) return;
            if (!double.TryParse(textBoxDeltaQ.Text, out double deltaQ)) return;

            chart1.Series["Domanda"].Points.Clear();
            chart1.Series["Offerta"].Points.Clear();
            if (chart1.Series.IndexOf("Equilibrio") != -1)
                chart1.Series["Equilibrio"].Points.Clear();

            double q = 0;
            double step = 0.1;
            double eqQ = 0, eqD = 0, eqO = 0;
            bool trovatoEquilibrio = false;

            double prevQ = 0, prevD = D0, prevO = O0;

            while (q <= deltaQ)
            {
                double Dq = D0 + a * q;
                double Oq = O0 + b * Math.Pow(q, 3) / 100.0;

                dataGridView1.Rows.Add(q, Dq, Oq);
                chart1.Series["Domanda"].Points.AddXY(q, Dq);
                chart1.Series["Offerta"].Points.AddXY(q, Oq);

                // controllo equilibrio con interpolazione
                if (!trovatoEquilibrio && Oq >= Dq)
                {
                    // interpolazione lineare tra prev e q corrente
                    double t = (prevD - prevO) / ((Oq - Dq) - (prevO - prevD));
                    eqQ = prevQ + t * (q - prevQ);
                    eqD = D0 + a * eqQ;
                    eqO = O0 + b * Math.Pow(eqQ, 3) / 100.0;
                    trovatoEquilibrio = true;
                }

                prevQ = q;
                prevD = Dq;
                prevO = Oq;

                q += step;
            }

            chart1.ChartAreas[0].AxisX.Title = "Quantità";
            chart1.ChartAreas[0].AxisY.Title = "Prezzo";
            chart1.Titles.Clear();
            chart1.Titles.Add("Domanda e Offerta");
            chart1.ChartAreas[0].RecalculateAxesScale();

            if (trovatoEquilibrio)
            {
                Series serieEquilibrio;
                if (chart1.Series.IndexOf("Equilibrio") == -1)
                {
                    serieEquilibrio = chart1.Series.Add("Equilibrio");
                    serieEquilibrio.ChartType = SeriesChartType.Point;
                    serieEquilibrio.MarkerStyle = MarkerStyle.Circle;
                    serieEquilibrio.MarkerSize = 10;
                    serieEquilibrio.Color = Color.Red;
                }
                else
                    serieEquilibrio = chart1.Series["Equilibrio"];

                serieEquilibrio.Points.AddXY(eqQ, eqD);
                serieEquilibrio.Points[0].Label = $"q={Math.Round(eqQ, 3)}\nd={Math.Round(eqD, 3)}\no={Math.Round(eqO, 3)}";
                serieEquilibrio.Points[0].LabelForeColor = Color.Black;
            }
        }

    }
}
