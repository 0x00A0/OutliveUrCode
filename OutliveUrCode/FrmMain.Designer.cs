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
            this.uiStyleManager1 = new Sunny.UI.UIStyleManager(this.components);
            this.materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            this.tbPgDrinking = new System.Windows.Forms.TabPage();
            this.materialCard2 = new MaterialSkin.Controls.MaterialCard();
            this.materialCard3 = new MaterialSkin.Controls.MaterialCard();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.materialButton2 = new MaterialSkin.Controls.MaterialButton();
            this.btnDrink250mL = new MaterialSkin.Controls.MaterialButton();
            this.elementHost1 = new System.Windows.Forms.Integration.ElementHost();
            this.waveProgress1 = new OutliveYourCode.UserControls.WaveProgress();
            this.btnDrink500 = new MaterialSkin.Controls.MaterialButton();
            this.materialButton1 = new MaterialSkin.Controls.MaterialButton();
            this.materialCard4 = new MaterialSkin.Controls.MaterialCard();
            this.tbPgSedentary = new System.Windows.Forms.TabPage();
            this.tbpgSetting = new System.Windows.Forms.TabPage();
            this.tbpgAbout = new System.Windows.Forms.TabPage();
            this.materialCard1 = new MaterialSkin.Controls.MaterialCard();
            this.ImgList4Tab = new System.Windows.Forms.ImageList(this.components);
            this.materialTabControl1.SuspendLayout();
            this.tbPgDrinking.SuspendLayout();
            this.materialCard2.SuspendLayout();
            this.materialCard3.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tbpgAbout.SuspendLayout();
            this.SuspendLayout();
            // 
            // uiStyleManager1
            // 
            this.uiStyleManager1.Style = Sunny.UI.UIStyle.LayuiGreen;
            // 
            // materialTabControl1
            // 
            this.materialTabControl1.Controls.Add(this.tbPgDrinking);
            this.materialTabControl1.Controls.Add(this.tbPgSedentary);
            this.materialTabControl1.Controls.Add(this.tbpgSetting);
            this.materialTabControl1.Controls.Add(this.tbpgAbout);
            this.materialTabControl1.Depth = 0;
            resources.ApplyResources(this.materialTabControl1, "materialTabControl1");
            this.materialTabControl1.ImageList = this.ImgList4Tab;
            this.materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl1.Multiline = true;
            this.materialTabControl1.Name = "materialTabControl1";
            this.materialTabControl1.SelectedIndex = 0;
            // 
            // tbPgDrinking
            // 
            this.tbPgDrinking.Controls.Add(this.materialCard2);
            resources.ApplyResources(this.tbPgDrinking, "tbPgDrinking");
            this.tbPgDrinking.Name = "tbPgDrinking";
            this.tbPgDrinking.UseVisualStyleBackColor = true;
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
            this.tableLayoutPanel1.Controls.Add(this.materialButton2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnDrink250mL, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.elementHost1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnDrink500, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.materialButton1, 1, 3);
            this.tableLayoutPanel1.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            // 
            // materialButton2
            // 
            resources.ApplyResources(this.materialButton2, "materialButton2");
            this.materialButton2.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Dense;
            this.materialButton2.Depth = 0;
            this.materialButton2.HighEmphasis = true;
            this.materialButton2.Icon = ((System.Drawing.Image)(resources.GetObject("materialButton2.Icon")));
            this.materialButton2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton2.Name = "materialButton2";
            this.materialButton2.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton2.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton2.UseAccentColor = false;
            this.materialButton2.UseVisualStyleBackColor = true;
            // 
            // btnDrink250mL
            // 
            resources.ApplyResources(this.btnDrink250mL, "btnDrink250mL");
            this.btnDrink250mL.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Dense;
            this.btnDrink250mL.Depth = 0;
            this.btnDrink250mL.HighEmphasis = true;
            this.btnDrink250mL.Icon = ((System.Drawing.Image)(resources.GetObject("btnDrink250mL.Icon")));
            this.btnDrink250mL.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnDrink250mL.Name = "btnDrink250mL";
            this.btnDrink250mL.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnDrink250mL.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnDrink250mL.UseAccentColor = false;
            this.btnDrink250mL.UseVisualStyleBackColor = true;
            // 
            // elementHost1
            // 
            resources.ApplyResources(this.elementHost1, "elementHost1");
            this.tableLayoutPanel1.SetColumnSpan(this.elementHost1, 4);
            this.elementHost1.Name = "elementHost1";
            this.tableLayoutPanel1.SetRowSpan(this.elementHost1, 2);
            this.elementHost1.Child = this.waveProgress1;
            // 
            // btnDrink500
            // 
            resources.ApplyResources(this.btnDrink500, "btnDrink500");
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
            // materialButton1
            // 
            resources.ApplyResources(this.materialButton1, "materialButton1");
            this.materialButton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Dense;
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
            // materialCard4
            // 
            this.materialCard4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard4.Depth = 0;
            resources.ApplyResources(this.materialCard4, "materialCard4");
            this.materialCard4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard4.Name = "materialCard4";
            // 
            // tbPgSedentary
            // 
            resources.ApplyResources(this.tbPgSedentary, "tbPgSedentary");
            this.tbPgSedentary.Name = "tbPgSedentary";
            this.tbPgSedentary.UseVisualStyleBackColor = true;
            // 
            // tbpgSetting
            // 
            resources.ApplyResources(this.tbpgSetting, "tbpgSetting");
            this.tbpgSetting.Name = "tbpgSetting";
            this.tbpgSetting.UseVisualStyleBackColor = true;
            // 
            // tbpgAbout
            // 
            this.tbpgAbout.Controls.Add(this.materialCard1);
            resources.ApplyResources(this.tbpgAbout, "tbpgAbout");
            this.tbpgAbout.Name = "tbpgAbout";
            this.tbpgAbout.UseVisualStyleBackColor = true;
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
            // ImgList4Tab
            // 
            this.ImgList4Tab.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ImgList4Tab.ImageStream")));
            this.ImgList4Tab.TransparentColor = System.Drawing.Color.Transparent;
            this.ImgList4Tab.Images.SetKeyName(0, "water-percent.png");
            this.ImgList4Tab.Images.SetKeyName(1, "readability.png");
            this.ImgList4Tab.Images.SetKeyName(2, "wrench.png");
            this.ImgList4Tab.Images.SetKeyName(3, "information.png");
            this.ImgList4Tab.Images.SetKeyName(4, "alarm.png");
            this.ImgList4Tab.Images.SetKeyName(5, "alarm-check.png");
            this.ImgList4Tab.Images.SetKeyName(6, "alarm-multiple.png");
            this.ImgList4Tab.Images.SetKeyName(7, "alarm-off.png");
            this.ImgList4Tab.Images.SetKeyName(8, "alarm-plus.png");
            this.ImgList4Tab.Images.SetKeyName(9, "alarm-snooze.png");
            this.ImgList4Tab.Images.SetKeyName(10, "alert.png");
            this.ImgList4Tab.Images.SetKeyName(11, "alert-box.png");
            this.ImgList4Tab.Images.SetKeyName(12, "alert-circle.png");
            this.ImgList4Tab.Images.SetKeyName(13, "alert-circle-outline.png");
            this.ImgList4Tab.Images.SetKeyName(14, "alert-octagon.png");
            this.ImgList4Tab.Images.SetKeyName(15, "beaker.png");
            this.ImgList4Tab.Images.SetKeyName(16, "beer.png");
            this.ImgList4Tab.Images.SetKeyName(17, "bell.png");
            this.ImgList4Tab.Images.SetKeyName(18, "bell-off.png");
            this.ImgList4Tab.Images.SetKeyName(19, "bell-outline.png");
            this.ImgList4Tab.Images.SetKeyName(20, "bell-plus.png");
            this.ImgList4Tab.Images.SetKeyName(21, "bell-ring.png");
            this.ImgList4Tab.Images.SetKeyName(22, "bell-ring-outline.png");
            this.ImgList4Tab.Images.SetKeyName(23, "bell-sleep.png");
            this.ImgList4Tab.Images.SetKeyName(24, "border-color.png");
            this.ImgList4Tab.Images.SetKeyName(25, "brightness-.png");
            this.ImgList4Tab.Images.SetKeyName(26, "brightness-1.png");
            this.ImgList4Tab.Images.SetKeyName(27, "camera-iris.png");
            this.ImgList4Tab.Images.SetKeyName(28, "chart-areaspline.png");
            this.ImgList4Tab.Images.SetKeyName(29, "chart-line.png");
            this.ImgList4Tab.Images.SetKeyName(30, "coffee.png");
            this.ImgList4Tab.Images.SetKeyName(31, "coffee-outline.png");
            this.ImgList4Tab.Images.SetKeyName(32, "cup.png");
            this.ImgList4Tab.Images.SetKeyName(33, "cup-off.png");
            this.ImgList4Tab.Images.SetKeyName(34, "cup-water.png");
            this.ImgList4Tab.Images.SetKeyName(35, "delete.png");
            this.ImgList4Tab.Images.SetKeyName(36, "delete-empty.png");
            this.ImgList4Tab.Images.SetKeyName(37, "delete-forever.png");
            this.ImgList4Tab.Images.SetKeyName(38, "delete-sweep.png");
            this.ImgList4Tab.Images.SetKeyName(39, "do-not-disturb.png");
            this.ImgList4Tab.Images.SetKeyName(40, "do-not-disturb-off.png");
            this.ImgList4Tab.Images.SetKeyName(41, "email.png");
            this.ImgList4Tab.Images.SetKeyName(42, "fingerprint.png");
            this.ImgList4Tab.Images.SetKeyName(43, "food-apple.png");
            this.ImgList4Tab.Images.SetKeyName(44, "food-fork-drink.png");
            this.ImgList4Tab.Images.SetKeyName(45, "github-box.png");
            this.ImgList4Tab.Images.SetKeyName(46, "github-circle.png");
            this.ImgList4Tab.Images.SetKeyName(47, "glass-mug.png");
            this.ImgList4Tab.Images.SetKeyName(48, "heart.png");
            this.ImgList4Tab.Images.SetKeyName(49, "heart-broken.png");
            this.ImgList4Tab.Images.SetKeyName(50, "informationoutline.png");
            this.ImgList4Tab.Images.SetKeyName(51, "matrix.png");
            this.ImgList4Tab.Images.SetKeyName(52, "opacity.png");
            this.ImgList4Tab.Images.SetKeyName(53, "palette.png");
            this.ImgList4Tab.Images.SetKeyName(54, "plus.png");
            this.ImgList4Tab.Images.SetKeyName(55, "plus-box-outline.png");
            this.ImgList4Tab.Images.SetKeyName(56, "plus-circle-outline.png");
            this.ImgList4Tab.Images.SetKeyName(57, "shape-circle-plus.png");
            this.ImgList4Tab.Images.SetKeyName(58, "sofa.png");
            this.ImgList4Tab.Images.SetKeyName(59, "timer.png");
            this.ImgList4Tab.Images.SetKeyName(60, "timer-off.png");
            this.ImgList4Tab.Images.SetKeyName(61, "water.png");
            this.ImgList4Tab.Images.SetKeyName(62, "wheelchair-accessibility.png");
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
            this.tbpgAbout.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Sunny.UI.UIStyleManager uiStyleManager1;
        private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
        private System.Windows.Forms.TabPage tbPgDrinking;
        private System.Windows.Forms.TabPage tbPgSedentary;
        private System.Windows.Forms.TabPage tbpgSetting;
        private System.Windows.Forms.TabPage tbpgAbout;
        private System.Windows.Forms.ImageList ImgList4Tab;
        private MaterialSkin.Controls.MaterialCard materialCard1;
        private MaterialSkin.Controls.MaterialCard materialCard2;
        private MaterialSkin.Controls.MaterialCard materialCard3;
        private System.Windows.Forms.Integration.ElementHost elementHost1;
        private OutliveYourCode.UserControls.WaveProgress waveProgress1;
        private MaterialSkin.Controls.MaterialCard materialCard4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private MaterialSkin.Controls.MaterialButton btnDrink250mL;
        private MaterialSkin.Controls.MaterialButton btnDrink500;
        private MaterialSkin.Controls.MaterialButton materialButton2;
        private MaterialSkin.Controls.MaterialButton materialButton1;
    }
}

