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
using System.Windows.Forms.VisualStyles;
using System.Windows.Input;
using System.Diagnostics;
using MaterialSkin;
using MaterialSkin.Controls;
using OutliveUrCode.Properties;
using System.Data.SQLite;
using System.Windows.Media.Media3D;
using MouseEventArgs = System.Windows.Forms.MouseEventArgs;

namespace OutliveUrCode
{
    public partial class FrmMain : MaterialForm
    {
        private readonly MaterialSkinManager materialSkinManager;   // 窗体的Material设计样式管理器
        private ComponentResourceManager resources = new ComponentResourceManager(typeof(FrmMain)); //窗体的资源管理,用于多语言
        private DateTime lastDrinkingAlarm;
        private DateTime lastSedentaryAlarm;
        private DateTime totalSedentaryToday;
        private Stopwatch stopwatchSedentary = new Stopwatch();

        /// <summary>
        /// 加载设置
        /// </summary>
        private void LoadFromSettings()
        {
            #region 喝水相关设置
            txtDrinkingTarget.Text = Properties.Settings.Default.DrinkingTarget.ToString();
            txtDrinkingTimerInterval.Text = Properties.Settings.Default.DrinkingAlarmInterval.ToString();
            chkDrinkingAlarm.Checked = Properties.Settings.Default.isDrinkingAlarmActive;

            if (Properties.Settings.Default.lastDrinkingTime.Date == DateTime.Today)    // 如果上次饮水是今天
            {
                txtDrinkingToday.Text = Properties.Settings.Default.DrinkToday.ToString();  // 读取今日饮水
                lastDrinkingAlarm= Properties.Settings.Default.lastDrinkingTime;    // 读取上次饮水时间
            }
            else
            {
                txtDrinkingToday.Text = "0";    // 重置每日饮水
                lastDrinkingAlarm=DateTime.Now; // 重置上次饮水时间
                SQLHelper.saveSQL(
                    Properties.Settings.Default.lastDrinkingTime.Date, 
                    Properties.Settings.Default.DrinkToday,
                    (int)Properties.Settings.Default.SedentaryToday.TotalSeconds);  // 将昨天喝水的记录存到数据库
            }
            RefreshWater();
            #endregion

            #region 久坐相关设置

            txtSedentaryTimerInterval.Text = Properties.Settings.Default.SedentaryAlarmInterval.ToString();
            txtSedentaryTimeRest.Text = Properties.Settings.Default.SedentaryRestTime.ToString();
            chkSedentaryStrongAlarm.Checked = Properties.Settings.Default.isSedentaryAlarmStrong;
            chkSedentaryAlarm.Checked = Properties.Settings.Default.isSedentaryAlarmActive;
            lastSedentaryAlarm = DateTime.Now;
            if (Properties.Settings.Default.lastSedentaryAlarm.Date == DateTime.Today)   // 如果上次久坐提醒是今天
            {
                totalSedentaryToday = DateTime.Today + Properties.Settings.Default.SedentaryToday;   // 读取今日久坐时间
                ledSedentary.Value = totalSedentaryToday; // 读取今日久坐时间
            }
            else
            {
                totalSedentaryToday = DateTime.Today;   // 重置今日久坐时间
                ledSedentary.Value = DateTime.Today; // 重置今日久坐时间
            }
            RefreshSed();

            #endregion  

            #region 应用设置
            chkStartup.Checked=Properties.Settings.Default.isStartup;
            chkTheme.Checked=Properties.Settings.Default.themeDark;
            if(Properties.Settings.Default.language.ToLower().Contains("en"))
            {
                lstLanguage.SelectedIndex = 1;
                Thread.CurrentThread.CurrentUICulture = new CultureInfo("en-US");
                Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture("en-US");
            }
            else
            {
                lstLanguage.SelectedIndex = 0;
                Thread.CurrentThread.CurrentUICulture = new CultureInfo("zh-CN");
                Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture("zh-CN");
            }
            AppLang(this,resources);
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

            #region 久坐相关设置

            Properties.Settings.Default.SedentaryToday = ledSedentary.Value.TimeOfDay;
            Properties.Settings.Default.SedentaryAlarmInterval = int.Parse(txtSedentaryTimerInterval.Text);
            Properties.Settings.Default.SedentaryRestTime = int.Parse(txtSedentaryTimeRest.Text);
            Properties.Settings.Default.isSedentaryAlarmActive = chkSedentaryAlarm.Checked;
            Properties.Settings.Default.isSedentaryAlarmStrong = chkSedentaryStrongAlarm.Checked;
            Properties.Settings.Default.lastSedentaryAlarm = DateTime.Now;

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
            ledSedentary.ForeColor = Color.Green;
            stopwatchSedentary.Start();
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
            if (DateTime.Now.Date>lastDrinkingAlarm.Date) // 判断是否跨天
            {
                lastDrinkingAlarm = DateTime.Today;
                txtDrinkingToday.Text = "0";
                RefreshWater();
            }

            if (DateTime.Now.Date>lastSedentaryAlarm.Date)
            {
                ledSedentary.Value=DateTime.Today;
                totalSedentaryToday=DateTime.Today;
                lastSedentaryAlarm=DateTime.Today;
                stopwatchSedentary.Restart();
                RefreshSed();
            }
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

            if (Thread.CurrentThread.CurrentUICulture.Name.ToLower().Contains("en"))
            {
                if (int.Parse(progrsWater.Percent) >= 100)
                {
                    lblDrinkingStatus.Text = "Well done! You've achieved goal today!";
                }
                else if (int.Parse(progrsWater.Percent) == 0)
                {
                    lblDrinkingStatus.Text = "Go for drinking now!";
                }
                else
                {
                    lblDrinkingStatus.Text = "Next alarm for drinking:"
                                             + (lastDrinkingAlarm
                                                + new TimeSpan(0, int.Parse(txtDrinkingTimerInterval.Text), 0)
                                             ).ToString("HH:mm");
                }
            }
            else
            {
                if (int.Parse(progrsWater.Percent) >= 100)
                {
                    lblDrinkingStatus.Text = "今天的喝水目标完成了!";
                }
                else if (int.Parse(progrsWater.Percent) == 0)
                {
                    lblDrinkingStatus.Text = "今天还没开始喝水呢,快去喝吧";
                }
                else
                {
                    lblDrinkingStatus.Text = "下一次喝水提醒:"
                                             + (lastDrinkingAlarm
                                                + new TimeSpan(0, int.Parse(txtDrinkingTimerInterval.Text), 0)
                                             ).ToString("HH:mm");
                }
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
            Properties.Settings.Default.lastDrinkingTime = DateTime.Now;
            Properties.Settings.Default.Save();
            DoDrink(150);
        }

        private void btnDrink500_Click(object sender, EventArgs e)
        {
            lastDrinkingAlarm = DateTime.Now;
            Properties.Settings.Default.lastDrinkingTime = DateTime.Now;
            Properties.Settings.Default.Save();
            DoDrink(500);
        }

        private void btnDrink250_Click(object sender, EventArgs e)
        {
            lastDrinkingAlarm = DateTime.Now;
            Properties.Settings.Default.lastDrinkingTime = DateTime.Now;
            Properties.Settings.Default.Save();
            DoDrink(250);
        }

        private void btnDrink50_Click(object sender, EventArgs e)
        {
            lastDrinkingAlarm = DateTime.Now;
            Properties.Settings.Default.lastDrinkingTime = DateTime.Now;
            Properties.Settings.Default.Save();
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

        private void chkDrinkingAlarm_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.isDrinkingAlarmActive = chkDrinkingAlarm.Checked;
            Properties.Settings.Default.Save();
        }

        private void btnShowDrinkData_Click(object sender, EventArgs e)
        {
            FrmData frmData = new FrmData();
            frmData.ShowDialog();
        }

        private void CheckDrinkingAlarm()
        {
            if (chkDrinkingAlarm.Checked 
                && (DateTime.Now-lastDrinkingAlarm).TotalMinutes>=int.Parse(txtDrinkingTimerInterval.Text)
                && int.Parse(txtDrinkingToday.Text) < int.Parse(txtDrinkingTarget.Text)
                )
            {
                notifyMain.ShowBalloonTip(
                    0,
                    "该喝水啦！",
                    "今日已喝："+txtDrinkingToday.Text+"mL\n"+"今日目标："+txtDrinkingTarget.Text + "mL",
                    ToolTipIcon.Info
                    );
            }
        }

        #endregion

        #region 久坐相关方法

        private void RefreshSed()
        {
            lblSedentaryNextAlarm.Text=(lastSedentaryAlarm+ new TimeSpan(0,int.Parse(txtSedentaryTimerInterval.Text),0)).ToString("HH:mm");
        }

        private void tmrSedn_Tick(object sender, EventArgs e)
        {
            ledSedentary.Value = totalSedentaryToday + stopwatchSedentary.Elapsed;
        }
        private void chkSedentaryAlarm_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.isSedentaryAlarmActive = chkSedentaryAlarm.Checked;
            Properties.Settings.Default.Save();
        }

        private void chkSedentaryStrongAlarm_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.isSedentaryAlarmStrong = chkSedentaryStrongAlarm.Checked;
            Properties.Settings.Default.Save();
        }

        private void txtSedentaryTimerInterval_TextChanged(object sender, EventArgs e)
        {
            if (txtSedentaryTimerInterval.Text == "")
            {
                txtSedentaryTimerInterval.Text = "1";
            }
            Properties.Settings.Default.SedentaryAlarmInterval = int.Parse(txtSedentaryTimerInterval.Text);
            Properties.Settings.Default.Save();
            RefreshSed();
        }
        private void txtSedentaryTimeRest_TextChanged(object sender, EventArgs e)
        {
            if (txtSedentaryTimeRest.Text == "")
            {
                txtSedentaryTimeRest.Text = "1";
            }
            Properties.Settings.Default.SedentaryRestTime = int.Parse(txtSedentaryTimeRest.Text);
            Properties.Settings.Default.Save();
        }
        private void btnResetSedentary_Click(object sender, EventArgs e)
        {
            lastSedentaryAlarm=DateTime.Now;
            totalSedentaryToday += stopwatchSedentary.Elapsed;
            RefreshSed();
            stopwatchSedentary.Restart();
        }
        private void btnShowSedentaryData_Click(object sender, EventArgs e)
        {
            FrmData frmData = new FrmData();
            frmData.ShowDialog();
        }
        private void CheckSedentaryAlarm()
        {
            if (chkSedentaryAlarm.Checked
                && DateTime.Now >= lastSedentaryAlarm + new TimeSpan(0, int.Parse(txtSedentaryTimerInterval.Text), 0)
               )
            {
                if (chkSedentaryStrongAlarm.Checked)
                {
                    stopwatchSedentary.Reset();
                    tmrMain.Enabled = false;
                    FrmLock frmlock = new FrmLock(1);
                    frmlock.ShowDialog(this);
                    frmlock.Close();
                    lastSedentaryAlarm =DateTime.Now;
                    stopwatchSedentary.Start();
                    tmrMain.Enabled = true;
                }
                else
                {
                    notifyMain.ShowBalloonTip(
                        0,
                        "该起来运动啦！",
                        "今日久坐总时长：" + ledSedentary.Value.ToString("HH:mm") + "\n" 
                        + "本次久坐时长：" + (new DateTime() + stopwatchSedentary.Elapsed).ToString("HH:mm"),
                        ToolTipIcon.Info
                    );
                }
            }
        }


        #endregion

        #region 应用设置相关

        /// <summary>
        /// 主题切换
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void chkTheme_CheckedChanged(object sender, EventArgs e)
        {
            materialSkinManager.Theme = chkTheme.Checked ? MaterialSkinManager.Themes.DARK : MaterialSkinManager.Themes.LIGHT;
            ledSedentary.ForeColor = chkTheme.Checked ? Color.LimeGreen : Color.Green;
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
                    Thread.CurrentThread.CurrentUICulture = new CultureInfo("zh-CN");
                    Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture("zh-CN");
                    break;
                case 1:
                    Thread.CurrentThread.CurrentUICulture = new CultureInfo("en-US");
                    Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture("en-US");
                    break;
            }
            AppLang(this, resources);
            //this.ResumeLayout(false);
            this.PerformLayout();
            resources.ApplyResources(this, "$this");
            Properties.Settings.Default.language = Thread.CurrentThread.CurrentUICulture.Name;
            Properties.Settings.Default.Save();
        }
        private static void AppLang(Control control, System.ComponentModel.ComponentResourceManager resources)
        {
            foreach (Control c in control.Controls)
            {
                if (c is MaterialLabel || c is MaterialButton || c is MaterialCheckbox || c is MaterialSwitch || c is TabPage)
                {
                    c.Text = resources.GetString(c.Name + ".Text"); // 从资源文件读取控件的多语言Text属性值
                }

                if (c is MaterialTextBox2)
                {
                    ((MaterialTextBox2)c).PrefixSuffixText = resources.GetString(c.Name + ".PrefixSuffixText");
                }
                
                AppLang(c, resources);
            }
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

        /// <summary>
        /// 显示开源信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnShowOpenSource_Click(object sender, EventArgs e)
        {
            if(Thread.CurrentThread.CurrentUICulture.Name.ToLower().Contains("en"))
                MaterialMessageBox.Show("Referenced open-source project:\r\nMaterialSkin(Application UI)\r\nHZH_Controls(Timer Control)\r\nMicrosoft.Data.Sqlite(SQLite Database IO)\r\n\r\nThis open-source project has been uploaded to GITHUB:\r\nhttp://github.com/0x00A0/OutliveUrCode");
            else
                MaterialMessageBox.Show("引用的开源项目:\r\nMaterialSkin(提供应用程序UI)\r\nHZH_Controls(提供数码管计时控件)\r\nMicrosoft.Data.Sqlite(提供SQLite数据库读写)\r\n本项目已开源至GITHUB:\r\nhttp://github.com/0x00A0/OutliveUrCode");

        }

        private void lblSedentaryStatus_Click(object sender, EventArgs e)
        {

        }
    }
}
//TODO 加入坐姿提醒之类的