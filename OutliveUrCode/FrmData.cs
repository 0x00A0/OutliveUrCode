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
using Microsoft.Data.Sqlite;

namespace OutliveUrCode
{
    public partial class FrmData : Form
    {
        public FrmData()
        {
            InitializeComponent();
        }
        private void DealData(DataTable data)
        {
            for (int j = 0; j < data.Rows.Count; j++)
            {
                chartMain.Series[0].Points.AddXY(data.Rows[j]["Time"].ToString(), data.Rows[j]["Drinking"].ToString());
                chartMain.Series[1].Points.AddXY(data.Rows[j]["Time"].ToString(), data.Rows[j]["Sedentary"].ToString());
            }
        }
    }
}
