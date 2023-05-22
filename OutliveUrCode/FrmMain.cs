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
using Sunny.UI.Win32;

namespace OutliveUrCode
{
    public partial class FrmMain : MaterialForm
    {
        private readonly MaterialSkinManager materialSkinManager;
        private DateTime lastDrinkingAlarm;

        /// <summary>
        /// 加载设置
        /// </summary>
        private void LoadFromSettings()
        {
            #region 喝水相关设置
            txtDrinkingTarget.Text = Properties.Settings.Default.DrinkingTarget.ToString();
            txtDrinkingTimerInterval.Text = Properties.Settings.Default.DrinkingAlarmInterval.ToString();
            if(Properties.Settings.Default.isDrinkingAlarmActive)
            {
                chkDrinkingAlarm.Checked = true;
                tmrMain.Enabled = true;
            }
            else
            {
                chkDrinkingAlarm.Checked = false;
                tmrMain.Enabled = false;
            }

            if (Properties.Settings.Default.lastDrinkingTime.Date == DateTime.Today)
            {
                txtDrinkingToday.Text = Properties.Settings.Default.DrinkToday.ToString();
                lastDrinkingAlarm= Properties.Settings.Default.lastDrinkingTime;
            }
            else
            {
                txtDrinkingToday.Text = "0";    // 重置每日饮水
                lastDrinkingAlarm=DateTime.Now;
            }

            RefreshWater();

            #endregion
        }

        /// <summary>
        /// 保存设置
        /// </summary>
        private void SaveToSettings()
        {
            #region 喝水相关设置
            Properties.Settings.Default.DrinkingTarget = int.Parse(txtDrinkingTarget.Text);
            Properties.Settings.Default.DrinkingAlarmInterval = int.Parse(txtDrinkingTimerInterval.Text);
            Properties.Settings.Default.isDrinkingAlarmActive = chkDrinkingAlarm.Checked;
            Properties.Settings.Default.DrinkToday = int.Parse(txtDrinkingToday.Text);
            Properties.Settings.Default.lastDrinkingTime = lastDrinkingAlarm;
            Properties.Settings.Default.Save();
            #endregion
        }

        /// <summary>
        /// 窗体的构造函数
        /// </summary>
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

        /// <summary>
        /// 主计时器Tick
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tmrMain_Tick(object sender, EventArgs e)
        {
            CheckDrinkingAlarm();
        }
        #region 喝水相关方法
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

        private void CheckDrinkingAlarm()
        {
            //TODO 喝水提醒
            if (chkDrinkingAlarm.Checked && (DateTime.Now-lastDrinkingAlarm).TotalMinutes>=int.Parse(txtDrinkingTimerInterval.Text))
            {
                MessageBox.Show("喝水提醒");
                lastDrinkingAlarm = DateTime.Now;
                Properties.Settings.Default.lastDrinkingTime = lastDrinkingAlarm;
                Properties.Settings.Default.Save();
            }
        }

        #endregion

        private void CheckSedentaryAlarm()
        {
            //TODO 久坐提醒
            MessageBox.Show("久坐提醒");
        }

    }
}
