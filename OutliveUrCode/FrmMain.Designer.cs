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
            this.uiStyleManager1 = new Sunny.UI.UIStyleManager(this.components);
            this.materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            this.tbPgDrinking = new System.Windows.Forms.TabPage();
            this.tbPgSedentary = new System.Windows.Forms.TabPage();
            this.tbpgSetting = new System.Windows.Forms.TabPage();
            this.tbpgAbout = new System.Windows.Forms.TabPage();
            this.ImgList4Tab = new System.Windows.Forms.ImageList(this.components);
            this.materialTabControl1.SuspendLayout();
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
            this.materialTabControl1.Location = new System.Drawing.Point(0, 140);
            this.materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl1.Name = "materialTabControl1";
            this.materialTabControl1.SelectedIndex = 0;
            this.materialTabControl1.Size = new System.Drawing.Size(1016, 449);
            this.materialTabControl1.TabIndex = 0;
            // 
            // tbPgDrinking
            // 
            this.tbPgDrinking.Location = new System.Drawing.Point(4, 22);
            this.tbPgDrinking.Name = "tbPgDrinking";
            this.tbPgDrinking.Padding = new System.Windows.Forms.Padding(3);
            this.tbPgDrinking.Size = new System.Drawing.Size(1008, 423);
            this.tbPgDrinking.TabIndex = 0;
            this.tbPgDrinking.Text = "饮水";
            this.tbPgDrinking.UseVisualStyleBackColor = true;
            // 
            // tbPgSedentary
            // 
            this.tbPgSedentary.Location = new System.Drawing.Point(4, 22);
            this.tbPgSedentary.Name = "tbPgSedentary";
            this.tbPgSedentary.Padding = new System.Windows.Forms.Padding(3);
            this.tbPgSedentary.Size = new System.Drawing.Size(1008, 528);
            this.tbPgSedentary.TabIndex = 1;
            this.tbPgSedentary.Text = "久坐";
            this.tbPgSedentary.UseVisualStyleBackColor = true;
            // 
            // tbpgSetting
            // 
            this.tbpgSetting.Location = new System.Drawing.Point(4, 22);
            this.tbpgSetting.Name = "tbpgSetting";
            this.tbpgSetting.Size = new System.Drawing.Size(1008, 528);
            this.tbpgSetting.TabIndex = 2;
            this.tbpgSetting.Text = "设置";
            this.tbpgSetting.UseVisualStyleBackColor = true;
            // 
            // tbpgAbout
            // 
            this.tbpgAbout.Location = new System.Drawing.Point(4, 22);
            this.tbpgAbout.Name = "tbpgAbout";
            this.tbpgAbout.Size = new System.Drawing.Size(1008, 528);
            this.tbpgAbout.TabIndex = 3;
            this.tbpgAbout.Text = "关于";
            this.tbpgAbout.UseVisualStyleBackColor = true;
            // 
            // ImgList4Tab
            // 
            this.ImgList4Tab.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.ImgList4Tab.ImageSize = new System.Drawing.Size(16, 16);
            this.ImgList4Tab.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // FrmMain
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1016, 589);
            this.Controls.Add(this.materialTabControl1);
            this.MaximizeBox = false;
            this.Name = "FrmMain";
            this.Text = "OutliveUrCode";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.materialTabControl1.ResumeLayout(false);
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
    }
}

