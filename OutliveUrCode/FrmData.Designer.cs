namespace OutliveUrCode
{
    partial class FrmData
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
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.Title title3 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.Title title4 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.chartMain = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chartMain)).BeginInit();
            this.SuspendLayout();
            // 
            // chartMain
            // 
            chartArea1.Area3DStyle.Inclination = 15;
            chartArea1.Area3DStyle.IsClustered = true;
            chartArea1.Area3DStyle.LightStyle = System.Windows.Forms.DataVisualization.Charting.LightStyle.Realistic;
            chartArea1.Area3DStyle.Rotation = 15;
            chartArea1.Area3DStyle.WallWidth = 0;
            chartArea1.AxisX.IsLabelAutoFit = false;
            chartArea1.AxisX.LabelStyle.Angle = 30;
            chartArea1.AxisX.LabelStyle.Format = "MMM.dd";
            chartArea1.Name = "ChartArea";
            this.chartMain.ChartAreas.Add(chartArea1);
            this.chartMain.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.chartMain.Legends.Add(legend1);
            this.chartMain.Location = new System.Drawing.Point(0, 0);
            this.chartMain.Name = "chartMain";
            series1.ChartArea = "ChartArea";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.SplineArea;
            series1.Legend = "Legend1";
            series1.LegendText = "喝水量";
            series1.Name = "SeriesDrinking";
            series1.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Date;
            series1.YValuesPerPoint = 4;
            series1.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
            series2.ChartArea = "ChartArea";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Legend = "Legend1";
            series2.LegendText = "久坐时长";
            series2.Name = "SeriesSed";
            series2.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Date;
            series2.YAxisType = System.Windows.Forms.DataVisualization.Charting.AxisType.Secondary;
            series2.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
            this.chartMain.Series.Add(series1);
            this.chartMain.Series.Add(series2);
            this.chartMain.Size = new System.Drawing.Size(800, 450);
            this.chartMain.TabIndex = 0;
            this.chartMain.Text = "chart1";
            title1.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            title1.Name = "Title1";
            title1.Text = "数据可视化";
            title2.DockedToChartArea = "ChartArea";
            title2.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Left;
            title2.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title2.IsDockedInsideChartArea = false;
            title2.Name = "Title2";
            title2.Text = "当日喝水量(mL)";
            title2.TextOrientation = System.Windows.Forms.DataVisualization.Charting.TextOrientation.Rotated90;
            title3.DockedToChartArea = "ChartArea";
            title3.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Right;
            title3.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title3.IsDockedInsideChartArea = false;
            title3.Name = "Title3";
            title3.Text = "久坐时长(min.)";
            title4.DockedToChartArea = "ChartArea";
            title4.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            title4.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title4.IsDockedInsideChartArea = false;
            title4.Name = "Title4";
            title4.Text = "日期";
            this.chartMain.Titles.Add(title1);
            this.chartMain.Titles.Add(title2);
            this.chartMain.Titles.Add(title3);
            this.chartMain.Titles.Add(title4);
            // 
            // FrmData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.chartMain);
            this.Name = "FrmData";
            this.Text = "图表数据";
            ((System.ComponentModel.ISupportInitialize)(this.chartMain)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartMain;
    }
}