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
            this.materialCard4 = new MaterialSkin.Controls.MaterialCard();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.tbPgSedentary = new System.Windows.Forms.TabPage();
            this.tbpgSetting = new System.Windows.Forms.TabPage();
            this.tbpgAbout = new System.Windows.Forms.TabPage();
            this.materialCard1 = new MaterialSkin.Controls.MaterialCard();
            this.MaterialIcons = new System.Windows.Forms.ImageList(this.components);
            this.elementHost1 = new System.Windows.Forms.Integration.ElementHost();
            this.waveProgress1 = new OutliveYourCode.UserControls.WaveProgress();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.txtDrinkingTarget = new MaterialSkin.Controls.MaterialTextBox2();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.txtDrinkingToday = new MaterialSkin.Controls.MaterialTextBox2();
            this.materialTabControl1.SuspendLayout();
            this.tbPgDrinking.SuspendLayout();
            this.materialCard2.SuspendLayout();
            this.materialCard3.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.materialCard4.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.tbpgAbout.SuspendLayout();
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
            this.tableLayoutPanel1.Controls.Add(this.btnDrink50, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnDrink250, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.elementHost1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnDrink500, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnDrink150, 1, 3);
            this.tableLayoutPanel1.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            // 
            // btnDrink50
            // 
            resources.ApplyResources(this.btnDrink50, "btnDrink50");
            this.btnDrink50.CharacterCasing = MaterialSkin.Controls.MaterialButton.CharacterCasingEnum.Normal;
            this.btnDrink50.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Dense;
            this.btnDrink50.Depth = 0;
            this.btnDrink50.HighEmphasis = true;
            this.btnDrink50.Icon = ((System.Drawing.Image)(resources.GetObject("btnDrink50.Icon")));
            this.btnDrink50.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnDrink50.Name = "btnDrink50";
            this.btnDrink50.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnDrink50.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnDrink50.UseAccentColor = false;
            this.btnDrink50.UseVisualStyleBackColor = true;
            // 
            // btnDrink250
            // 
            resources.ApplyResources(this.btnDrink250, "btnDrink250");
            this.btnDrink250.CharacterCasing = MaterialSkin.Controls.MaterialButton.CharacterCasingEnum.Normal;
            this.btnDrink250.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Dense;
            this.btnDrink250.Depth = 0;
            this.btnDrink250.HighEmphasis = true;
            this.btnDrink250.Icon = ((System.Drawing.Image)(resources.GetObject("btnDrink250.Icon")));
            this.btnDrink250.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnDrink250.Name = "btnDrink250";
            this.btnDrink250.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnDrink250.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnDrink250.UseAccentColor = false;
            this.btnDrink250.UseVisualStyleBackColor = true;
            // 
            // btnDrink500
            // 
            resources.ApplyResources(this.btnDrink500, "btnDrink500");
            this.btnDrink500.CharacterCasing = MaterialSkin.Controls.MaterialButton.CharacterCasingEnum.Normal;
            this.btnDrink500.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Dense;
            this.btnDrink500.Depth = 0;
            this.btnDrink500.HighEmphasis = true;
            this.btnDrink500.Icon = ((System.Drawing.Image)(resources.GetObject("btnDrink500.Icon")));
            this.btnDrink500.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnDrink500.Name = "btnDrink500";
            this.btnDrink500.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnDrink500.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnDrink500.UseAccentColor = false;
            this.btnDrink500.UseVisualStyleBackColor = true;
            // 
            // btnDrink150
            // 
            resources.ApplyResources(this.btnDrink150, "btnDrink150");
            this.btnDrink150.CharacterCasing = MaterialSkin.Controls.MaterialButton.CharacterCasingEnum.Normal;
            this.btnDrink150.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Dense;
            this.btnDrink150.Depth = 0;
            this.btnDrink150.HighEmphasis = true;
            this.btnDrink150.Icon = ((System.Drawing.Image)(resources.GetObject("btnDrink150.Icon")));
            this.btnDrink150.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnDrink150.Name = "btnDrink150";
            this.btnDrink150.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnDrink150.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnDrink150.UseAccentColor = false;
            this.btnDrink150.UseVisualStyleBackColor = true;
            // 
            // materialCard4
            // 
            resources.ApplyResources(this.materialCard4, "materialCard4");
            this.materialCard4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard4.Controls.Add(this.flowLayoutPanel1);
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
            resources.ApplyResources(this.flowLayoutPanel1, "flowLayoutPanel1");
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            // 
            // tbPgSedentary
            // 
            this.tbPgSedentary.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.tbPgSedentary, "tbPgSedentary");
            this.tbPgSedentary.Name = "tbPgSedentary";
            // 
            // tbpgSetting
            // 
            this.tbpgSetting.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.tbpgSetting, "tbpgSetting");
            this.tbpgSetting.Name = "tbpgSetting";
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
            // elementHost1
            // 
            resources.ApplyResources(this.elementHost1, "elementHost1");
            this.tableLayoutPanel1.SetColumnSpan(this.elementHost1, 4);
            this.elementHost1.Name = "elementHost1";
            this.tableLayoutPanel1.SetRowSpan(this.elementHost1, 2);
            this.elementHost1.Child = this.waveProgress1;
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
            this.txtDrinkingToday.MaxLength = 32767;
            this.txtDrinkingToday.MouseState = MaterialSkin.MouseState.OUT;
            this.txtDrinkingToday.Name = "txtDrinkingToday";
            this.txtDrinkingToday.PasswordChar = '\0';
            this.txtDrinkingToday.PrefixSuffix = MaterialSkin.Controls.MaterialTextBox2.PrefixSuffixTypes.Suffix;
            this.txtDrinkingToday.ReadOnly = true;
            this.txtDrinkingToday.SelectedText = "";
            this.txtDrinkingToday.SelectionLength = 0;
            this.txtDrinkingToday.SelectionStart = 0;
            this.txtDrinkingToday.ShortcutsEnabled = true;
            this.txtDrinkingToday.TabStop = false;
            this.txtDrinkingToday.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtDrinkingToday.TrailingIcon = null;
            this.txtDrinkingToday.UseSystemPasswordChar = false;
            this.txtDrinkingToday.UseTallSize = false;
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
            this.materialTabControl1.ResumeLayout(false);
            this.tbPgDrinking.ResumeLayout(false);
            this.materialCard2.ResumeLayout(false);
            this.materialCard3.ResumeLayout(false);
            this.materialCard3.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.materialCard4.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.tbpgAbout.ResumeLayout(false);
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
        private OutliveYourCode.UserControls.WaveProgress waveProgress1;
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
    }
}

