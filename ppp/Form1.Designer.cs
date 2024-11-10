namespace ppp
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend6 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart3 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart4 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.txtInitialPressure = new System.Windows.Forms.TextBox();
            this.txtFinalPressure = new System.Windows.Forms.TextBox();
            this.txtFinalVolume = new System.Windows.Forms.TextBox();
            this.txtInitialTemperature = new System.Windows.Forms.TextBox();
            this.txtInitialVolume = new System.Windows.Forms.TextBox();
            this.txtFinalTemperature = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart4)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(81, 219);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(147, 69);
            this.btnCalculate.TabIndex = 0;
            this.btnCalculate.Text = "button1";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click_1);
            // 
            // chart2
            // 
            chartArea4.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.chart2.Legends.Add(legend4);
            this.chart2.Location = new System.Drawing.Point(330, 28);
            this.chart2.Name = "chart2";
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            this.chart2.Series.Add(series4);
            this.chart2.Size = new System.Drawing.Size(300, 300);
            this.chart2.TabIndex = 1;
            this.chart2.Text = "chart2";
            // 
            // chart3
            // 
            chartArea5.Name = "ChartArea1";
            this.chart3.ChartAreas.Add(chartArea5);
            legend5.Name = "Legend1";
            this.chart3.Legends.Add(legend5);
            this.chart3.Location = new System.Drawing.Point(707, 28);
            this.chart3.Name = "chart3";
            series5.ChartArea = "ChartArea1";
            series5.Legend = "Legend1";
            series5.Name = "Series1";
            this.chart3.Series.Add(series5);
            this.chart3.Size = new System.Drawing.Size(300, 300);
            this.chart3.TabIndex = 2;
            this.chart3.Text = "chart3";
            // 
            // chart4
            // 
            chartArea6.Name = "ChartArea1";
            this.chart4.ChartAreas.Add(chartArea6);
            legend6.Name = "Legend1";
            this.chart4.Legends.Add(legend6);
            this.chart4.Location = new System.Drawing.Point(1098, 28);
            this.chart4.Name = "chart4";
            series6.ChartArea = "ChartArea1";
            series6.Legend = "Legend1";
            series6.Name = "Series1";
            this.chart4.Series.Add(series6);
            this.chart4.Size = new System.Drawing.Size(300, 300);
            this.chart4.TabIndex = 3;
            // 
            // txtInitialPressure
            // 
            this.txtInitialPressure.Location = new System.Drawing.Point(13, 28);
            this.txtInitialPressure.Name = "txtInitialPressure";
            this.txtInitialPressure.Size = new System.Drawing.Size(100, 22);
            this.txtInitialPressure.TabIndex = 4;
            // 
            // txtFinalPressure
            // 
            this.txtFinalPressure.Location = new System.Drawing.Point(158, 28);
            this.txtFinalPressure.Name = "txtFinalPressure";
            this.txtFinalPressure.Size = new System.Drawing.Size(100, 22);
            this.txtFinalPressure.TabIndex = 5;
            // 
            // txtFinalVolume
            // 
            this.txtFinalVolume.Location = new System.Drawing.Point(158, 73);
            this.txtFinalVolume.Name = "txtFinalVolume";
            this.txtFinalVolume.Size = new System.Drawing.Size(100, 22);
            this.txtFinalVolume.TabIndex = 6;
            // 
            // txtInitialTemperature
            // 
            this.txtInitialTemperature.Location = new System.Drawing.Point(13, 123);
            this.txtInitialTemperature.Name = "txtInitialTemperature";
            this.txtInitialTemperature.Size = new System.Drawing.Size(100, 22);
            this.txtInitialTemperature.TabIndex = 7;
            // 
            // txtInitialVolume
            // 
            this.txtInitialVolume.Location = new System.Drawing.Point(13, 73);
            this.txtInitialVolume.Name = "txtInitialVolume";
            this.txtInitialVolume.Size = new System.Drawing.Size(100, 22);
            this.txtInitialVolume.TabIndex = 8;
            // 
            // txtFinalTemperature
            // 
            this.txtFinalTemperature.Location = new System.Drawing.Point(158, 123);
            this.txtFinalTemperature.Name = "txtFinalTemperature";
            this.txtFinalTemperature.Size = new System.Drawing.Size(100, 22);
            this.txtFinalTemperature.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1481, 631);
            this.Controls.Add(this.txtFinalTemperature);
            this.Controls.Add(this.txtInitialVolume);
            this.Controls.Add(this.txtInitialTemperature);
            this.Controls.Add(this.txtFinalVolume);
            this.Controls.Add(this.txtFinalPressure);
            this.Controls.Add(this.txtInitialPressure);
            this.Controls.Add(this.chart4);
            this.Controls.Add(this.chart3);
            this.Controls.Add(this.chart2);
            this.Controls.Add(this.btnCalculate);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart3;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart4;
        private System.Windows.Forms.TextBox txtInitialPressure;
        private System.Windows.Forms.TextBox txtFinalPressure;
        private System.Windows.Forms.TextBox txtFinalVolume;
        private System.Windows.Forms.TextBox txtInitialTemperature;
        private System.Windows.Forms.TextBox txtInitialVolume;
        private System.Windows.Forms.TextBox txtFinalTemperature;
    }
}

