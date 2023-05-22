namespace OutliveUrCode
{
    partial class FrmMain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            this.tbPgDrinking = new System.Windows.Forms.TabPage();
            this.materialCard2 = new MaterialSkin.Controls.MaterialCard();
            this.materialCard3 = new MaterialSkin.Controls.MaterialCard();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnDrink50 = new MaterialSkin.Controls.MaterialButton();
            this.btnDrink250 = new MaterialSkin.Controls.MaterialButton();
            this.btnDrink500 = new MaterialSkin.Controls.MaterialButton();
            this.btnDrink150 = new MaterialSkin.Controls.MaterialButton();
            this.lblDrinkingStatus = new MaterialSkin.Controls.MaterialLabel();
            this.materialCard4 = new MaterialSkin.Controls.MaterialCard();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.txtDrinkingTarget = new MaterialSkin.Controls.MaterialTextBox2();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.txtDrinkingToday = new MaterialSkin.Controls.MaterialTextBox2();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.txtDrinkingTimerInterval = new MaterialSkin.Controls.MaterialTextBox2();
            this.chkDrinkingAlarm = new MaterialSkin.Controls.MaterialCheckbox();
            this.materialButton1 = new MaterialSkin.Controls.MaterialButton();
            this.tbPgSedentary = new System.Windows.Forms.TabPage();
            this.materialCard6 = new MaterialSkin.Controls.MaterialCard();
            this.tbpgSetting = new System.Windows.Forms.TabPage();
            this.materialCard5 = new MaterialSkin.Controls.MaterialCard();
            this.tbpgAbout = new System.Windows.Forms.TabPage();
            this.materialCard1 = new MaterialSkin.Controls.MaterialCard();
            this.MaterialIcons = new System.Windows.Forms.ImageList(this.components);
            this.tmrMain = new System.Windows.Forms.Timer(this.components);
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.elementHost1 = new System.Windows.Forms.Integration.ElementHost();
            this.progrsWater = new OutliveYourCode.UserControls.WaveProgress();
            this.materialCard7 = new MaterialSkin.Controls.MaterialCard();
            this.materialCard8 = new MaterialSkin.Controls.MaterialCard();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.materialTabControl1.SuspendLayout();
            this.tbPgDrinking.SuspendLayout();
            this.materialCard2.SuspendLayout();
            this.materialCard3.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.materialCard4.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.tbPgSedentary.SuspendLayout();
            this.materialCard6.SuspendLayout();
            this.tbpgSetting.SuspendLayout();
            this.materialCard5.SuspendLayout();
            this.tbpgAbout.SuspendLayout();
            this.materialCard1.SuspendLayout();
            this.materialCard7.SuspendLayout();
            this.materialCard8.SuspendLayout();
            this.SuspendLayout();
            // 
            // materialTabControl1
            // 
            this.materialTabControl1.Controls.Add(this.tbPgDrinking);
            this.materialTabControl1.Controls.Add(this.tbPgSedentary);
            this.materialTabControl1.Controls.Add(this.tbpgSetting);
            this.materialTabControl1.Controls.Add(this.tbpgAbout);
            this.materialTabControl1.Depth = 0;
            resources.ApplyResources(this.materialTabControl1, "materialTabControl1");
            this.materialTabControl1.ImageList = this.MaterialIcons;
            this.materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl1.Multiline = true;
            this.materialTabControl1.Name = "materialTabControl1";
            this.materialTabControl1.SelectedIndex = 0;
            // 
            // tbPgDrinking
            // 
            this.tbPgDrinking.BackColor = System.Drawing.Color.White;
            this.tbPgDrinking.Controls.Add(this.materialCard2);
            resources.ApplyResources(this.tbPgDrinking, "tbPgDrinking");
            this.tbPgDrinking.Name = "tbPgDrinking";
            // 
            // materialCard2
            // 
            this.materialCard2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard2.Controls.Add(this.materialCard3);
            this.materialCard2.Controls.Add(this.materialCard4);
            this.materialCard2.Depth = 0;
            resources.ApplyResources(this.materialCard2, "materialCard2");
            this.materialCard2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard2.Name = "materialCard2";
            // 
            // materialCard3
            // 
            resources.ApplyResources(this.materialCard3, "materialCard3");
            this.materialCard3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard3.Controls.Add(this.tableLayoutPanel1);
            this.materialCard3.Depth = 0;
            this.materialCard3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard3.Name = "materialCard3";
            // 
            // tableLayoutPanel1
            // 
            resources.ApplyResources(this.tableLayoutPanel1, "tableLayoutPanel1");
            this.tableLayoutPanel1.Controls.Add(this.btnDrink50, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.btnDrink250, 5, 4);
            this.tableLayoutPanel1.Controls.Add(this.elementHost1, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnDrink500, 6, 3);
            this.tableLayoutPanel1.Controls.Add(this.btnDrink150, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.lblDrinkingStatus, 1, 0);
            this.tableLayoutPanel1.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            // 
            // btnDrink50
            // 
            resources.ApplyResources(this.btnDrink50, "btnDrink50");
            this.btnDrink50.CharacterCasing = MaterialSkin.Controls.MaterialButton.CharacterCasingEnum.Normal;
            this.tableLayoutPanel1.SetColumnSpan(this.btnDrink50, 3);
            this.btnDrink50.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnDrink50.Depth = 0;
            this.btnDrink50.HighEmphasis = true;
            this.btnDrink50.Icon = ((System.Drawing.Image)(resources.GetObject("btnDrink50.Icon")));
            this.btnDrink50.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnDrink50.Name = "btnDrink50";
            this.btnDrink50.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnDrink50.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnDrink50.UseAccentColor = false;
            this.btnDrink50.UseVisualStyleBackColor = true;
            this.btnDrink50.Click += new System.EventHandler(this.btnDrink50_Click);
            // 
            // btnDrink250
            // 
            resources.ApplyResources(this.btnDrink250, "btnDrink250");
            this.btnDrink250.CharacterCasing = MaterialSkin.Controls.MaterialButton.CharacterCasingEnum.Normal;
            this.tableLayoutPanel1.SetColumnSpan(this.btnDrink250, 3);
            this.btnDrink250.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnDrink250.Depth = 0;
            this.btnDrink250.HighEmphasis = true;
            this.btnDrink250.Icon = ((System.Drawing.Image)(resources.GetObject("btnDrink250.Icon")));
            this.btnDrink250.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnDrink250.Name = "btnDrink250";
            this.btnDrink250.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnDrink250.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnDrink250.UseAccentColor = false;
            this.btnDrink250.UseVisualStyleBackColor = true;
            this.btnDrink250.Click += new System.EventHandler(this.btnDrink250_Click);
            // 
            // btnDrink500
            // 
            resources.ApplyResources(this.btnDrink500, "btnDrink500");
            this.btnDrink500.CharacterCasing = MaterialSkin.Controls.MaterialButton.CharacterCasingEnum.Normal;
            this.tableLayoutPanel1.SetColumnSpan(this.btnDrink500, 3);
            this.btnDrink500.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnDrink500.Depth = 0;
            this.btnDrink500.HighEmphasis = true;
            this.btnDrink500.Icon = ((System.Drawing.Image)(resources.GetObject("btnDrink500.Icon")));
            this.btnDrink500.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnDrink500.Name = "btnDrink500";
            this.btnDrink500.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnDrink500.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnDrink500.UseAccentColor = false;
            this.btnDrink500.UseVisualStyleBackColor = true;
            this.btnDrink500.Click += new System.EventHandler(this.btnDrink500_Click);
            // 
            // btnDrink150
            // 
            resources.ApplyResources(this.btnDrink150, "btnDrink150");
            this.btnDrink150.CharacterCasing = MaterialSkin.Controls.MaterialButton.CharacterCasingEnum.Normal;
            this.tableLayoutPanel1.SetColumnSpan(this.btnDrink150, 3);
            this.btnDrink150.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnDrink150.Depth = 0;
            this.btnDrink150.HighEmphasis = true;
            this.btnDrink150.Icon = ((System.Drawing.Image)(resources.GetObject("btnDrink150.Icon")));
            this.btnDrink150.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnDrink150.Name = "btnDrink150";
            this.btnDrink150.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnDrink150.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnDrink150.UseAccentColor = false;
            this.btnDrink150.UseVisualStyleBackColor = true;
            this.btnDrink150.Click += new System.EventHandler(this.btnDrink150_Click);
            // 
            // lblDrinkingStatus
            // 
            resources.ApplyResources(this.lblDrinkingStatus, "lblDrinkingStatus");
            this.tableLayoutPanel1.SetColumnSpan(this.lblDrinkingStatus, 7);
            this.lblDrinkingStatus.Depth = 0;
            this.lblDrinkingStatus.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblDrinkingStatus.Name = "lblDrinkingStatus";
            // 
            // materialCard4
            // 
            resources.ApplyResources(this.materialCard4, "materialCard4");
            this.materialCard4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard4.Controls.Add(this.flowLayoutPanel1);
            this.materialCard4.Controls.Add(this.materialButton1);
            this.materialCard4.Depth = 0;
            this.materialCard4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard4.Name = "materialCard4";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.materialLabel1);
            this.flowLayoutPanel1.Controls.Add(this.txtDrinkingTarget);
            this.flowLayoutPanel1.Controls.Add(this.materialLabel2);
            this.flowLayoutPanel1.Controls.Add(this.txtDrinkingToday);
            this.flowLayoutPanel1.Controls.Add(this.materialLabel3);
            this.flowLayoutPanel1.Controls.Add(this.txtDrinkingTimerInterval);
            this.flowLayoutPanel1.Controls.Add(this.chkDrinkingAlarm);
            resources.ApplyResources(this.flowLayoutPanel1, "flowLayoutPanel1");
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            // 
            // materialLabel1
            // 
            resources.ApplyResources(this.materialLabel1, "materialLabel1");
            this.materialLabel1.Depth = 0;
            this.materialLabel1.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel1.HighEmphasis = true;
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            // 
            // txtDrinkingTarget
            // 
            this.txtDrinkingTarget.AnimateReadOnly = false;
            this.txtDrinkingTarget.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtDrinkingTarget.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            resources.ApplyResources(this.txtDrinkingTarget, "txtDrinkingTarget");
            this.txtDrinkingTarget.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtDrinkingTarget.Depth = 0;
            this.txtDrinkingTarget.HideSelection = true;
            this.txtDrinkingTarget.LeadingIcon = null;
            this.txtDrinkingTarget.LeaveOnEnterKey = true;
            this.txtDrinkingTarget.MaxLength = 32767;
            this.txtDrinkingTarget.MouseState = MaterialSkin.MouseState.OUT;
            this.txtDrinkingTarget.Name = "txtDrinkingTarget";
            this.txtDrinkingTarget.PasswordChar = '\0';
            this.txtDrinkingTarget.PrefixSuffix = MaterialSkin.Controls.MaterialTextBox2.PrefixSuffixTypes.Suffix;
            this.txtDrinkingTarget.ReadOnly = false;
            this.txtDrinkingTarget.SelectedText = "";
            this.txtDrinkingTarget.SelectionLength = 0;
            this.txtDrinkingTarget.SelectionStart = 0;
            this.txtDrinkingTarget.ShortcutsEnabled = true;
            this.txtDrinkingTarget.TabStop = false;
            this.txtDrinkingTarget.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtDrinkingTarget.TrailingIcon = null;
            this.txtDrinkingTarget.UseSystemPasswordChar = false;
            this.txtDrinkingTarget.UseTallSize = false;
            this.txtDrinkingTarget.TextChanged += new System.EventHandler(this.txtDrinkingTarget_TextChanged);
            // 
            // materialLabel2
            // 
            resources.ApplyResources(this.materialLabel2, "materialLabel2");
            this.materialLabel2.Depth = 0;
            this.materialLabel2.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel2.HighEmphasis = true;
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            // 
            // txtDrinkingToday
            // 
            this.txtDrinkingToday.AnimateReadOnly = false;
            this.txtDrinkingToday.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtDrinkingToday.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            resources.ApplyResources(this.txtDrinkingToday, "txtDrinkingToday");
            this.txtDrinkingToday.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtDrinkingToday.Depth = 0;
            this.txtDrinkingToday.HideSelection = true;
            this.txtDrinkingToday.LeadingIcon = null;
            this.txtDrinkingToday.LeaveOnEnterKey = true;
            this.txtDrinkingToday.MaxLength = 32767;
            this.txtDrinkingToday.MouseState = MaterialSkin.MouseState.OUT;
            this.txtDrinkingToday.Name = "txtDrinkingToday";
            this.txtDrinkingToday.PasswordChar = '\0';
            this.txtDrinkingToday.PrefixSuffix = MaterialSkin.Controls.MaterialTextBox2.PrefixSuffixTypes.Suffix;
            this.txtDrinkingToday.ReadOnly = false;
            this.txtDrinkingToday.SelectedText = "";
            this.txtDrinkingToday.SelectionLength = 0;
            this.txtDrinkingToday.SelectionStart = 0;
            this.txtDrinkingToday.ShortcutsEnabled = true;
            this.txtDrinkingToday.TabStop = false;
            this.txtDrinkingToday.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtDrinkingToday.TrailingIcon = null;
            this.txtDrinkingToday.UseSystemPasswordChar = false;
            this.txtDrinkingToday.UseTallSize = false;
            this.txtDrinkingToday.TextChanged += new System.EventHandler(this.txtDrinkingToday_TextChanged);
            // 
            // materialLabel3
            // 
            resources.ApplyResources(this.materialLabel3, "materialLabel3");
            this.materialLabel3.Depth = 0;
            this.materialLabel3.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel3.HighEmphasis = true;
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            // 
            // txtDrinkingTimerInterval
            // 
            this.txtDrinkingTimerInterval.AnimateReadOnly = false;
            this.txtDrinkingTimerInterval.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtDrinkingTimerInterval.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            resources.ApplyResources(this.txtDrinkingTimerInterval, "txtDrinkingTimerInterval");
            this.txtDrinkingTimerInterval.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtDrinkingTimerInterval.Depth = 0;
            this.txtDrinkingTimerInterval.HideSelection = true;
            this.txtDrinkingTimerInterval.LeadingIcon = ((System.Drawing.Image)(resources.GetObject("txtDrinkingTimerInterval.LeadingIcon")));
            this.txtDrinkingTimerInterval.LeaveOnEnterKey = true;
            this.txtDrinkingTimerInterval.MaxLength = 32767;
            this.txtDrinkingTimerInterval.MouseState = MaterialSkin.MouseState.OUT;
            this.txtDrinkingTimerInterval.Name = "txtDrinkingTimerInterval";
            this.txtDrinkingTimerInterval.PasswordChar = '\0';
            this.txtDrinkingTimerInterval.PrefixSuffix = MaterialSkin.Controls.MaterialTextBox2.PrefixSuffixTypes.Suffix;
            this.txtDrinkingTimerInterval.ReadOnly = false;
            this.txtDrinkingTimerInterval.SelectedText = "";
            this.txtDrinkingTimerInterval.SelectionLength = 0;
            this.txtDrinkingTimerInterval.SelectionStart = 0;
            this.txtDrinkingTimerInterval.ShortcutsEnabled = true;
            this.txtDrinkingTimerInterval.TabStop = false;
            this.txtDrinkingTimerInterval.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtDrinkingTimerInterval.TrailingIcon = null;
            this.txtDrinkingTimerInterval.UseSystemPasswordChar = false;
            this.txtDrinkingTimerInterval.UseTallSize = false;
            // 
            // chkDrinkingAlarm
            // 
            resources.ApplyResources(this.chkDrinkingAlarm, "chkDrinkingAlarm");
            this.chkDrinkingAlarm.Checked = true;
            this.chkDrinkingAlarm.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkDrinkingAlarm.Depth = 0;
            this.chkDrinkingAlarm.MouseLocation = new System.Drawing.Point(-1, -1);
            this.chkDrinkingAlarm.MouseState = MaterialSkin.MouseState.HOVER;
            this.chkDrinkingAlarm.Name = "chkDrinkingAlarm";
            this.chkDrinkingAlarm.ReadOnly = false;
            this.chkDrinkingAlarm.Ripple = true;
            this.chkDrinkingAlarm.UseVisualStyleBackColor = true;
            // 
            // materialButton1
            // 
            resources.ApplyResources(this.materialButton1, "materialButton1");
            this.materialButton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton1.Depth = 0;
            this.materialButton1.HighEmphasis = true;
            this.materialButton1.Icon = ((System.Drawing.Image)(resources.GetObject("materialButton1.Icon")));
            this.materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton1.Name = "materialButton1";
            this.materialButton1.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton1.UseAccentColor = false;
            this.materialButton1.UseVisualStyleBackColor = true;
            // 
            // tbPgSedentary
            // 
            this.tbPgSedentary.BackColor = System.Drawing.Color.White;
            this.tbPgSedentary.Controls.Add(this.materialCard6);
            resources.ApplyResources(this.tbPgSedentary, "tbPgSedentary");
            this.tbPgSedentary.Name = "tbPgSedentary";
            // 
            // materialCard6
            // 
            this.materialCard6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard6.Controls.Add(this.tableLayoutPanel2);
            this.materialCard6.Depth = 0;
            resources.ApplyResources(this.materialCard6, "materialCard6");
            this.materialCard6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard6.Name = "materialCard6";
            // 
            // tbpgSetting
            // 
            this.tbpgSetting.BackColor = System.Drawing.Color.White;
            this.tbpgSetting.Controls.Add(this.materialCard5);
            resources.ApplyResources(this.tbpgSetting, "tbpgSetting");
            this.tbpgSetting.Name = "tbpgSetting";
            // 
            // materialCard5
            // 
            this.materialCard5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard5.Controls.Add(this.materialCard7);
            this.materialCard5.Depth = 0;
            resources.ApplyResources(this.materialCard5, "materialCard5");
            this.materialCard5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard5.Name = "materialCard5";
            // 
            // tbpgAbout
            // 
            this.tbpgAbout.BackColor = System.Drawing.Color.White;
            this.tbpgAbout.Controls.Add(this.materialCard1);
            resources.ApplyResources(this.tbpgAbout, "tbpgAbout");
            this.tbpgAbout.Name = "tbpgAbout";
            // 
            // materialCard1
            // 
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.Controls.Add(this.materialCard8);
            this.materialCard1.Depth = 0;
            resources.ApplyResources(this.materialCard1, "materialCard1");
            this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            // 
            // MaterialIcons
            // 
            this.MaterialIcons.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("MaterialIcons.ImageStream")));
            this.MaterialIcons.TransparentColor = System.Drawing.Color.Transparent;
            this.MaterialIcons.Images.SetKeyName(0, "water-percent.png");
            this.MaterialIcons.Images.SetKeyName(1, "readability.png");
            this.MaterialIcons.Images.SetKeyName(2, "wrench.png");
            this.MaterialIcons.Images.SetKeyName(3, "information.png");
            this.MaterialIcons.Images.SetKeyName(4, "alarm.png");
            this.MaterialIcons.Images.SetKeyName(5, "alarm-check.png");
            this.MaterialIcons.Images.SetKeyName(6, "alarm-multiple.png");
            this.MaterialIcons.Images.SetKeyName(7, "alarm-off.png");
            this.MaterialIcons.Images.SetKeyName(8, "alarm-plus.png");
            this.MaterialIcons.Images.SetKeyName(9, "alarm-snooze.png");
            this.MaterialIcons.Images.SetKeyName(10, "alert.png");
            this.MaterialIcons.Images.SetKeyName(11, "alert-box.png");
            this.MaterialIcons.Images.SetKeyName(12, "alert-circle.png");
            this.MaterialIcons.Images.SetKeyName(13, "alert-circle-outline.png");
            this.MaterialIcons.Images.SetKeyName(14, "alert-octagon.png");
            this.MaterialIcons.Images.SetKeyName(15, "beaker.png");
            this.MaterialIcons.Images.SetKeyName(16, "beer.png");
            this.MaterialIcons.Images.SetKeyName(17, "bell.png");
            this.MaterialIcons.Images.SetKeyName(18, "bell-off.png");
            this.MaterialIcons.Images.SetKeyName(19, "bell-outline.png");
            this.MaterialIcons.Images.SetKeyName(20, "bell-plus.png");
            this.MaterialIcons.Images.SetKeyName(21, "bell-ring.png");
            this.MaterialIcons.Images.SetKeyName(22, "bell-ring-outline.png");
            this.MaterialIcons.Images.SetKeyName(23, "bell-sleep.png");
            this.MaterialIcons.Images.SetKeyName(24, "border-color.png");
            this.MaterialIcons.Images.SetKeyName(25, "brightness-.png");
            this.MaterialIcons.Images.SetKeyName(26, "brightness-1.png");
            this.MaterialIcons.Images.SetKeyName(27, "camera-iris.png");
            this.MaterialIcons.Images.SetKeyName(28, "chart-areaspline.png");
            this.MaterialIcons.Images.SetKeyName(29, "chart-line.png");
            this.MaterialIcons.Images.SetKeyName(30, "coffee.png");
            this.MaterialIcons.Images.SetKeyName(31, "coffee-outline.png");
            this.MaterialIcons.Images.SetKeyName(32, "cup.png");
            this.MaterialIcons.Images.SetKeyName(33, "cup-off.png");
            this.MaterialIcons.Images.SetKeyName(34, "cup-water.png");
            this.MaterialIcons.Images.SetKeyName(35, "delete.png");
            this.MaterialIcons.Images.SetKeyName(36, "delete-empty.png");
            this.MaterialIcons.Images.SetKeyName(37, "delete-forever.png");
            this.MaterialIcons.Images.SetKeyName(38, "delete-sweep.png");
            this.MaterialIcons.Images.SetKeyName(39, "do-not-disturb.png");
            this.MaterialIcons.Images.SetKeyName(40, "do-not-disturb-off.png");
            this.MaterialIcons.Images.SetKeyName(41, "email.png");
            this.MaterialIcons.Images.SetKeyName(42, "fingerprint.png");
            this.MaterialIcons.Images.SetKeyName(43, "food-apple.png");
            this.MaterialIcons.Images.SetKeyName(44, "food-fork-drink.png");
            this.MaterialIcons.Images.SetKeyName(45, "github-box.png");
            this.MaterialIcons.Images.SetKeyName(46, "github-circle.png");
            this.MaterialIcons.Images.SetKeyName(47, "glass-mug.png");
            this.MaterialIcons.Images.SetKeyName(48, "heart.png");
            this.MaterialIcons.Images.SetKeyName(49, "heart-broken.png");
            this.MaterialIcons.Images.SetKeyName(50, "informationoutline.png");
            this.MaterialIcons.Images.SetKeyName(51, "matrix.png");
            this.MaterialIcons.Images.SetKeyName(52, "opacity.png");
            this.MaterialIcons.Images.SetKeyName(53, "palette.png");
            this.MaterialIcons.Images.SetKeyName(54, "plus.png");
            this.MaterialIcons.Images.SetKeyName(55, "plus-box-outline.png");
            this.MaterialIcons.Images.SetKeyName(56, "plus-circle-outline.png");
            this.MaterialIcons.Images.SetKeyName(57, "shape-circle-plus.png");
            this.MaterialIcons.Images.SetKeyName(58, "sofa.png");
            this.MaterialIcons.Images.SetKeyName(59, "timer.png");
            this.MaterialIcons.Images.SetKeyName(60, "timer-off.png");
            this.MaterialIcons.Images.SetKeyName(61, "water.png");
            this.MaterialIcons.Images.SetKeyName(62, "wheelchair-accessibility.png");
            // 
            // tmrMain
            // 
            this.tmrMain.Enabled = true;
            this.tmrMain.Interval = 60000;
            this.tmrMain.Tick += new System.EventHandler(this.tmrMain_Tick);
            // 
            // tableLayoutPanel2
            // 
            resources.ApplyResources(this.tableLayoutPanel2, "tableLayoutPanel2");
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            // 
            // flowLayoutPanel2
            // 
            resources.ApplyResources(this.flowLayoutPanel2, "flowLayoutPanel2");
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            // 
            // elementHost1
            // 
            resources.ApplyResources(this.elementHost1, "elementHost1");
            this.tableLayoutPanel1.SetColumnSpan(this.elementHost1, 7);
            this.elementHost1.Name = "elementHost1";
            this.tableLayoutPanel1.SetRowSpan(this.elementHost1, 2);
            this.elementHost1.Child = this.progrsWater;
            // 
            // materialCard7
            // 
            resources.ApplyResources(this.materialCard7, "materialCard7");
            this.materialCard7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard7.Controls.Add(this.flowLayoutPanel2);
            this.materialCard7.Depth = 0;
            this.materialCard7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard7.Name = "materialCard7";
            // 
            // materialCard8
            // 
            resources.ApplyResources(this.materialCard8, "materialCard8");
            this.materialCard8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard8.Controls.Add(this.flowLayoutPanel3);
            this.materialCard8.Depth = 0;
            this.materialCard8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard8.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard8.Name = "materialCard8";
            // 
            // flowLayoutPanel3
            // 
            resources.ApplyResources(this.flowLayoutPanel3, "flowLayoutPanel3");
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            // 
            // FrmMain
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.Controls.Add(this.materialTabControl1);
            this.DrawerAutoShow = true;
            this.DrawerHighlightWithAccent = false;
            this.DrawerIndicatorWidth = 4;
            this.DrawerShowIconsWhenHidden = true;
            this.DrawerTabControl = this.materialTabControl1;
            this.FormStyle = MaterialSkin.Controls.MaterialForm.FormStyles.ActionBar_48;
            this.MaximizeBox = false;
            this.Name = "FrmMain";
            this.Sizable = false;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmMain_FormClosing);
            this.materialTabControl1.ResumeLayout(false);
            this.tbPgDrinking.ResumeLayout(false);
            this.materialCard2.ResumeLayout(false);
            this.materialCard3.ResumeLayout(false);
            this.materialCard3.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.materialCard4.ResumeLayout(false);
            this.materialCard4.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.tbPgSedentary.ResumeLayout(false);
            this.materialCard6.ResumeLayout(false);
            this.tbpgSetting.ResumeLayout(false);
            this.materialCard5.ResumeLayout(false);
            this.tbpgAbout.ResumeLayout(false);
            this.materialCard1.ResumeLayout(false);
            this.materialCard7.ResumeLayout(false);
            this.materialCard8.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
        private System.Windows.Forms.TabPage tbPgDrinking;
        private System.Windows.Forms.TabPage tbPgSedentary;
        private System.Windows.Forms.TabPage tbpgSetting;
        private System.Windows.Forms.TabPage tbpgAbout;
        private System.Windows.Forms.ImageList MaterialIcons;
        private MaterialSkin.Controls.MaterialCard materialCard1;
        private MaterialSkin.Controls.MaterialCard materialCard2;
        private MaterialSkin.Controls.MaterialCard materialCard3;
        private System.Windows.Forms.Integration.ElementHost elementHost1;
        private OutliveYourCode.UserControls.WaveProgress progrsWater;
        private MaterialSkin.Controls.MaterialCard materialCard4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private MaterialSkin.Controls.MaterialButton btnDrink250;
        private MaterialSkin.Controls.MaterialButton btnDrink500;
        private MaterialSkin.Controls.MaterialButton btnDrink50;
        private MaterialSkin.Controls.MaterialButton btnDrink150;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialTextBox2 txtDrinkingTarget;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialTextBox2 txtDrinkingToday;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialTextBox2 txtDrinkingTimerInterval;
        private MaterialSkin.Controls.MaterialCheckbox chkDrinkingAlarm;
        private MaterialSkin.Controls.MaterialButton materialButton1;
        private System.Windows.Forms.Timer tmrMain;
        private MaterialSkin.Controls.MaterialCard materialCard6;
        private MaterialSkin.Controls.MaterialCard materialCard5;
        private MaterialSkin.Controls.MaterialLabel lblDrinkingStatus;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private MaterialSkin.Controls.MaterialCard materialCard7;
        private MaterialSkin.Controls.MaterialCard materialCard8;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
    }
}

