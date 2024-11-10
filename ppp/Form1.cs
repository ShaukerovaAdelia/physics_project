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

namespace ppp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            SetupCharts();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void SetupCharts()
        {
            SetupChart(chart2, "Давление от Объёма", "Объем", "Давление");
            SetupChart(chart3, "Давление от Температуры", "Температура", "Давление");
            SetupChart(chart4, "Объем от Температуры", "Температура", "Объем");
        }

        private void SetupChart(Chart chart, string title, string xTitle, string yTitle)
        {
            chart.Titles.Add(title);
            chart.ChartAreas.Add(new ChartArea());
            chart.Series.Clear();
            chart.Series.Add("Series1");
            chart.Series["Series1"].ChartType = SeriesChartType.Line;
            chart.ChartAreas[0].AxisX.Title = xTitle;
            chart.ChartAreas[0].AxisY.Title = yTitle;
            chart.Series["Series1"].Points.Clear();
        }

        private string DetermineProcessType(double p1, double p2, double v1, double v2, double t1, double t2)
        {
            if (v1 == v2)
                return "Изохорный";  // Объем постоянный
            else if (p1 == p2)
                return "Изобарный";  // Давление постоянное
            else if (t1 == t2)
                return "Изотермический";  // Температура постоянная
            return "Неизвестный процесс";
        }

        private void ClearCharts()
        {
            chart2.Series["Series1"].Points.Clear();
            chart3.Series["Series1"].Points.Clear();
            chart4.Series["Series1"].Points.Clear();
        }

        private void BuildGraphs(string processType, double p1, double p2, double v1, double v2, double t1, double t2)
        {
            switch (processType)
            {
                case "Изохорный":
                    DrawIsochoricProcess(p1, t1, t2);
                    break;
                case "Изобарный":
                    DrawIsobaricProcess(v1, t1, t2);
                    break;
                case "Изотермический":
                    DrawIsothermalProcess(p1, v1);
                    break;
            }
        }

        private void DrawIsochoricProcess(double pressure, double t1, double t2)
        {
            for (double T = t1; T <= t2; T += 1)
            {
                double P = pressure * (T / t1); // Уравнение состояния для изохорного процесса
                chart2.Series["Series1"].Points.AddXY(1, P);
                chart3.Series["Series1"].Points.AddXY(T, P);
                chart4.Series["Series1"].Points.AddXY(T, 1); // Объем постоянный
            }
        }

        private void DrawIsobaricProcess(double volume, double t1, double t2)
        {
            for (double T = t1; T <= t2; T += 1)
            {
                double V = volume * (T / t1); // Уравнение состояния для изобарного процесса
                chart2.Series["Series1"].Points.AddXY(V, 1);
                chart3.Series["Series1"].Points.AddXY(T, 1);
                chart4.Series["Series1"].Points.AddXY(T, V); // Давление постоянное
            }
        }

        private void DrawIsothermalProcess(double pressure, double volume)
        {
            for (double V = 0.1; V <= volume; V += 0.1)
            {
                double P = (pressure * volume) / V; // Уравнение состояния для изотермического процесса
                chart2.Series["Series1"].Points.AddXY(V, P);
                chart3.Series["Series1"].Points.AddXY(1, P);
                chart4.Series["Series1"].Points.AddXY(1, V); // Температура постоянная
            }
        }

        private void btnCalculate_Click_1(object sender, EventArgs e)
        {
            double initialPressure = Convert.ToDouble(txtInitialPressure.Text);
            double finalPressure = Convert.ToDouble(txtFinalPressure.Text);
            double initialVolume = Convert.ToDouble(txtInitialVolume.Text);
            double finalVolume = Convert.ToDouble(txtFinalVolume.Text);
            double initialTemperature = Convert.ToDouble(txtInitialTemperature.Text);
            double finalTemperature = Convert.ToDouble(txtFinalTemperature.Text);

            string processType = DetermineProcessType(initialPressure, finalPressure, initialVolume, finalVolume, initialTemperature, finalTemperature);
            MessageBox.Show($"Это {processType} процесс.");

            ClearCharts();
            BuildGraphs(processType, initialPressure, finalPressure, initialVolume, finalVolume, initialTemperature, finalTemperature);
        }
    }
}