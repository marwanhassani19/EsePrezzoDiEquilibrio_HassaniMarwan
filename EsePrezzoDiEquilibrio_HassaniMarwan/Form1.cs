using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            dataGridView1.Columns.Add("ddomanda", "domanda");
            dataGridView1.Columns.Add("offerta", "offerta");

            // Imposto il font generale della form
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            // Pulisco eventuali dati precedenti nella tabella
            dataGridView1.Rows.Clear();

            // 1) Valori iniziali
            double q = 0.0;
            double d = 90 - 4 * q;
            double o = 10 + Math.Pow(q, 3) / 100.0;
            double dIniziale = 90;
            double oIniziale = 10;
            dataGridView1.Rows.Add(q, d, o);

            // 2) Ricerca approssimativa del punto di equilibrio
            double step = 1.0;
            double minStep = 0.0001;
            bool superato = false;
            int safetyLimit = 500000;
            int counter = 0;

            while (!superato && counter < safetyLimit)
            {
                counter++;
                q += step;
                d = 90 - 4 * q;
                o = 10 + Math.Pow(q, 3) / 100.0;
                dataGridView1.Rows.Add(q, d, o);

                double diff = o - d;

                if (Math.Abs(diff) < 10) step = 0.1;
                if (Math.Abs(diff) < 1) step = 0.01;
                if (Math.Abs(diff) < 0.1) step = 0.001;
                if (Math.Abs(diff) < 0.01) step = minStep;

                if (o >= d) superato = true;
            }

            // 3) Avvicinamento al punto critico
            double qLimit = 13.9;
            double qTarget = Math.Ceiling(q);

            while (q < qLimit && counter < safetyLimit)
            {
                counter++;
                q += 0.1;
                d = 90 - 4 * q;
                o = 10 + Math.Pow(q, 3) / 100.0;
                dataGridView1.Rows.Add(q, d, o);
            }

            // 4) Salto al numero intero e incremento regolare
            q = qTarget;
            d = 90 - 4 * q;
            o = 10 + Math.Pow(q, 3) / 100.0;
            dataGridView1.Rows.Add(q, d, o);

            while (d > oIniziale && counter < safetyLimit)
            {
                counter++;
                q += 1;
                d = 90 - 4 * q;
                o = 10 + Math.Pow(q, 3) / 100.0;
                dataGridView1.Rows.Add(q, d, o);
            }

            // 5) Aggiornamento del grafico
            chart1.Series["Domanda"].Points.Clear();
            chart1.Series["Offerta"].Points.Clear();

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells[0].Value == null) continue;

                double qVal = Convert.ToDouble(row.Cells[0].Value);
                double dVal = Convert.ToDouble(row.Cells[1].Value);
                double oVal = Convert.ToDouble(row.Cells[2].Value);

                chart1.Series["Domanda"].Points.AddXY(qVal, dVal);
                chart1.Series["Offerta"].Points.AddXY(qVal, oVal);

                chart1.ChartAreas[0].AxisX.LabelStyle.Format = "0";
                chart1.ChartAreas[0].AxisY.LabelStyle.Format = "0.##";
            }

            chart1.ChartAreas[0].AxisX.Title = "quantità";
            chart1.ChartAreas[0].AxisY.Title = "prezzo";
            chart1.Titles.Clear();
            chart1.Titles.Add("Aggiornamento automatico");
            chart1.ChartAreas[0].RecalculateAxesScale();

            // 6) Calcolo del punto di equilibrio
            double equilibrioQ = 0, equilibrioD = 0, equilibrioO = 0;
            bool trovato = false;

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells[0].Value == null) continue;

                double qVal = Convert.ToDouble(row.Cells[0].Value);
                double dVal = Convert.ToDouble(row.Cells[1].Value);
                double oVal = Convert.ToDouble(row.Cells[2].Value);

                if (oVal >= dVal && !trovato)
                {
                    equilibrioQ = qVal;
                    equilibrioD = dVal;
                    equilibrioO = oVal;
                    trovato = true;
                }
            }

            // 7) Evidenziazione grafica del punto di equilibrio
            if (trovato)
            {
                var serieEquilibrio = chart1.Series.Add("Equilibrio");
                serieEquilibrio.ChartType = SeriesChartType.Point;
                serieEquilibrio.MarkerStyle = MarkerStyle.Circle;
                serieEquilibrio.MarkerSize = 7;
                serieEquilibrio.Color = Color.Red;

                serieEquilibrio.Points.AddXY(equilibrioQ, equilibrioD);
                serieEquilibrio.Points[0].Label = $"q={Math.Round(equilibrioQ, 5)}\nd={Math.Round(equilibrioD, 5)}\no={Math.Round(equilibrioO, 5)}";
                serieEquilibrio.Points[0].LabelForeColor = Color.Black;
            }
        }
    }
}
