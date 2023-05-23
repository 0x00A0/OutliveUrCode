using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;
using MaterialSkin;
using MaterialSkin.Controls;
using OutliveUrCode.Properties;
using Sunny.UI.Win32;
using MouseEventArgs = System.Windows.Forms.MouseEventArgs;

namespace OutliveUrCode
{
    public partial class FrmMain : MaterialForm
    {
        private readonly MaterialSkinManager materialSkinManager;   // 窗体的Material设计样式管理器
        private ComponentResourceManager resources = new ComponentResourceManager(typeof(FrmMain)); //窗体的资源管理,用于多语言
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

            #region 应用设置
            chkStartup.Checked=Properties.Settings.Default.isStartup;
            chkTheme.Checked=Properties.Settings.Default.themeDark;
            switch (Properties.Settings.Default.language)
            {
                case "zh-cn":
                    lstLanguage.SelectedIndex = 0;
                    break;
                case "en-us":
                    lstLanguage.SelectedIndex = 1;
                    break;
                default:
                    lstLanguage.SelectedIndex = 0;
                    break;
            }
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
            #endregion

            #region 应用设置
            Properties.Settings.Default.isStartup = chkStartup.Checked;
            Properties.Settings.Default.themeDark = chkTheme.Checked;
            Properties.Settings.Default.language = Thread.CurrentThread.CurrentCulture.Name;
            #endregion

            Properties.Settings.Default.Save(); // 保存设置
        }

        /// <summary>
        /// 窗体的构造函数
        /// </summary>
        public FrmMain()
        {
            InitializeComponent();
            materialSkinManager = MaterialSkinManager.Instance; 
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.Cyan700,
                Primary.Cyan900,
                Primary.Cyan500,
                Accent.DeepOrange200,
                TextShade.WHITE);
            materialSkinManager.AddFormToManage(this);
            LoadFromSettings();
        }
        /// <summary>
        /// 窗体缩小至托盘
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmMain_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                this.Visible = false;
                notifyMain.Visible = true;
                ///托盘气泡提示
                string tipTitle = "OutliveUrCode";
                string tipContent = "程序已缩小到托盘";
                ToolTipIcon tipType = ToolTipIcon.None;
                notifyMain.ShowBalloonTip(0, tipTitle, tipContent, tipType);
            }
        }
        /// <summary>
        /// 托盘图标双击还原窗口
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void notifyMain_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Visible = true;
            this.WindowState = FormWindowState.Normal;
        }
        private void menuOpen_Click(object sender, EventArgs e)
        {
            this.Visible = true;
            this.WindowState = FormWindowState.Normal;
        }
        private void menuExit_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(System.Environment.ExitCode);
        }
        private void FrmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            notifyMain.Dispose();
            System.Environment.Exit(System.Environment.ExitCode);
            this.Dispose();
        }

        /// <summary>
        /// 主计时器Tick
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tmrMain_Tick(object sender, EventArgs e)
        {
            CheckDrinkingAlarm();
            CheckSedentaryAlarm();
        }

        /// <summary>
        /// 判断文本框输入内容
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e">KeyPressEventArgs对象</param>
        private void CheckNumber(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 0x20) e.KeyChar = (char)0; //禁止空格键  
            if ((e.KeyChar == 0x2D) && (((TextBox)sender).Text.Length == 0))
            {
                return; //处理负数  
            }

            if (e.KeyChar > 0x20)
            {
                try
                {
                    double.Parse(((TextBox)sender).Text + e.KeyChar.ToString());
                }
                catch
                {
                    e.KeyChar = (char)0; //处理非法字符
                }

            }
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
                lblDrinkingStatus.Text = Resources.FrmMain_DrinkingStatusNormal 
                                         + (lastDrinkingAlarm
                                             + new TimeSpan(0,int.Parse(txtDrinkingTimerInterval.Text),0)
                                           ).ToString("HH:mm");
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
            lastDrinkingAlarm = DateTime.Now;
            DoDrink(150);
        }

        private void btnDrink500_Click(object sender, EventArgs e)
        {
            lastDrinkingAlarm = DateTime.Now;
            DoDrink(500);
        }

        private void btnDrink250_Click(object sender, EventArgs e)
        {
            lastDrinkingAlarm = DateTime.Now;
            DoDrink(250);
        }

        private void btnDrink50_Click(object sender, EventArgs e)
        {
            lastDrinkingAlarm = DateTime.Now;
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

        private void txtDrinkingTimerInterval_TextChanged(object sender, EventArgs e)
        {

            if (txtDrinkingTimerInterval.Text == "")
            {
                txtDrinkingTimerInterval.Text = "1";
            }
            Properties.Settings.Default.DrinkingAlarmInterval = int.Parse(txtDrinkingTimerInterval.Text);
            Properties.Settings.Default.Save();
            RefreshWater();
        }

        private void CheckDrinkingAlarm()
        {
            //TODO 喝水提醒
            if (chkDrinkingAlarm.Checked 
                && (DateTime.Now-lastDrinkingAlarm).TotalMinutes>=int.Parse(txtDrinkingTimerInterval.Text)
                && int.Parse(txtDrinkingToday.Text) < int.Parse(txtDrinkingTarget.Text)
                )
            {
                //MessageBox.Show("喝水提醒");
                notifyMain.ShowBalloonTip(
                    0,
                    "该喝水啦！",
                    "今日已喝："+txtDrinkingToday.Text+"\n"+"今日目标："+txtDrinkingTarget.Text,
                    ToolTipIcon.Info
                    );
                Properties.Settings.Default.lastDrinkingTime = lastDrinkingAlarm;
                Properties.Settings.Default.Save();
                RefreshWater();
            }
        }

        #endregion

        private void CheckSedentaryAlarm()
        {
            //TODO 久坐提醒
            //MessageBox.Show("久坐提醒");
        }

        #region 应用设置相关
        
        /// <summary>
        /// 主题切换
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void chkTheme_CheckedChanged(object sender, EventArgs e)
        {
            materialSkinManager.Theme = chkTheme.Checked ? MaterialSkinManager.Themes.DARK : MaterialSkinManager.Themes.LIGHT;
            Properties.Settings.Default.themeDark = chkTheme.Checked;
            Properties.Settings.Default.Save();
        }
        /// <summary>
        /// 多语言切换
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="selectedItem"></param>
        private void lstLanguage_SelectedIndexChanged(object sender, MaterialListBoxItem selectedItem)
        {
            switch (lstLanguage.SelectedIndex)
            {
                case 0:
                    Thread.CurrentThread.CurrentUICulture = new CultureInfo("zh-cn");
                    break;
                case 1:
                    Thread.CurrentThread.CurrentUICulture = new CultureInfo("en-us");
                    break;
            }
            foreach (Control ctl in this.Controls)
            {
                resources.ApplyResources(ctl, ctl.Name);
            }
            this.ResumeLayout(false);
            this.PerformLayout();
            resources.ApplyResources(this, "$this");
            Properties.Settings.Default.language = Thread.CurrentThread.CurrentUICulture.Name;
            Properties.Settings.Default.Save();
        }

        private void chkStartup_CheckedChanged(object sender, EventArgs e)
        {
            if (chkStartup.Checked)
            {
                Startup.SetMeAutoStart(true);
            }
            else
            {
                Startup.SetMeAutoStart(false);
            }

        }

        #endregion

        private void btnShowOpenSource_Click(object sender, EventArgs e)
        {

        }

    }
}
