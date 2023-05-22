using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;
using MaterialSkin;
using MaterialSkin.Controls;
using OutliveUrCode.Properties;

namespace OutliveUrCode
{
    public partial class FrmMain : MaterialForm
    {
        private readonly MaterialSkinManager materialSkinManager;

        private void LoadFromSettings()
        {
            #region 喝水相关
            txtDrinkingTarget.Text = Properties.Settings.Default.DrinkingTarget.ToString();
            txtDrinkingTimerInterval.Text = Properties.Settings.Default.DrinkingAlarmInterval.ToString();
            tmrDrink.Interval = Properties.Settings.Default.DrinkingAlarmInterval * 60 * 1000;
            if(Properties.Settings.Default.isDrinkingAlarmActive)
            {
                chkDrinkingAlarm.Checked = true;
                tmrDrink.Enabled = true;
            }
            else
            {
                chkDrinkingAlarm.Checked = false;
                tmrDrink.Enabled = false;
            }

            if (Properties.Settings.Default.SaveTime.Date == DateTime.Today)
            {
                txtDrinkingToday.Text = Properties.Settings.Default.DrinkToday.ToString();
            }
            else
            {
                txtDrinkingToday.Text = "0";    // 重置每日饮水
            }

            RefreshWater();

            #endregion
        }
        private void SaveToSettings()
        {
            #region 喝水相关
            Properties.Settings.Default.DrinkingTarget = int.Parse(txtDrinkingTarget.Text);
            Properties.Settings.Default.DrinkingAlarmInterval = tmrDrink.Interval / 60 / 1000;
            Properties.Settings.Default.isDrinkingAlarmActive = chkDrinkingAlarm.Checked;
            Properties.Settings.Default.DrinkToday = int.Parse(txtDrinkingToday.Text);
            Properties.Settings.Default.SaveTime = DateTime.Today;
            Properties.Settings.Default.Save();
            #endregion
        }

        public FrmMain()
        {
            InitializeComponent();
            LoadFromSettings();
            materialSkinManager = MaterialSkinManager.Instance; 
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.Cyan700,
                Primary.Cyan900,
                Primary.Cyan500,
                Accent.DeepOrange200,
                TextShade.WHITE);
            materialSkinManager.AddFormToManage(this);
        }

        private void RefreshWater()
        {
            if (int.Parse(txtDrinkingTarget.Text) == 0)
            {
                this.progrsWater.Progress = 0;
                return;
            }
            this.progrsWater.Progress = int.Parse(txtDrinkingToday.Text) * 100 / int.Parse(txtDrinkingTarget.Text);
            if (int.Parse(progrsWater.Percent)>=100)
            {
                lblDrinkingStatus.Text = Resources.FrmMain_DrinkingStatus100;
            }
            else if(int.Parse(progrsWater.Percent) == 0)
            {
                lblDrinkingStatus.Text = Resources.FrmMain_DrinkingStatus0;
            }
            else
            {
                lblDrinkingStatus.Text = Resources.FrmMain_DrinkingStatusNormal;
            }
        }

        private void DoDrink(int water)
        {
            txtDrinkingToday.Text = (int.Parse(txtDrinkingToday.Text) + water).ToString();
            Properties.Settings.Default.DrinkToday = int.Parse(txtDrinkingToday.Text);
            Properties.Settings.Default.Save();
            RefreshWater();
        }

        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveToSettings();
        }

        private void btnDrink150_Click(object sender, EventArgs e)
        {
            DoDrink(150);
        }

        private void btnDrink500_Click(object sender, EventArgs e)
        {
            DoDrink(500);
        }

        private void btnDrink250_Click(object sender, EventArgs e)
        {
            DoDrink(250);
        }

        private void btnDrink50_Click(object sender, EventArgs e)
        {
            DoDrink(50);
        }

        private void tmrDrink_Tick(object sender, EventArgs e)
        {
            //TODO 喝水提醒的代码
        }

        private void txtDrinkingToday_TextChanged(object sender, EventArgs e)
        {
            if (txtDrinkingToday.Text == "")
            {
                txtDrinkingToday.Text = "0";
            }
            DoDrink(0);
        }

        private void txtDrinkingTarget_TextChanged(object sender, EventArgs e)
        {
            if (txtDrinkingTarget.Text == "")
            {
                txtDrinkingTarget.Text = "0";
            }
            Properties.Settings.Default.DrinkingTarget = int.Parse(txtDrinkingTarget.Text);
            Properties.Settings.Default.Save();
            RefreshWater();
        }
    }
}
