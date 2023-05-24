namespace OutliveUrCode
{
    partial class FrmLock
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLock));
            this.tmrLock = new System.Windows.Forms.Timer(this.components);
            this.materialButton1 = new MaterialSkin.Controls.MaterialButton();
            this.ledTime = new HZH_Controls.Controls.UCLEDTime();
            this.panel1 = new System.Windows.Forms.Panel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tmrLock
            // 
            this.tmrLock.Enabled = true;
            this.tmrLock.Interval = 1000;
            this.tmrLock.Tick += new System.EventHandler(this.tmrLock_Tick);
            // 
            // materialButton1
            // 
            this.materialButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.materialButton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton1.Depth = 0;
            this.materialButton1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.materialButton1.HighEmphasis = true;
            this.materialButton1.Icon = null;
            this.materialButton1.Location = new System.Drawing.Point(795, 410);
            this.materialButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton1.Name = "materialButton1";
            this.materialButton1.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton1.Size = new System.Drawing.Size(266, 36);
            this.materialButton1.TabIndex = 0;
            this.materialButton1.Text = "这是写代码测试时紧急逃出去用的按钮";
            this.materialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton1.UseAccentColor = false;
            this.materialButton1.UseVisualStyleBackColor = true;
            this.materialButton1.Click += new System.EventHandler(this.materialButton1_Click);
            // 
            // ledTime
            // 
            this.ledTime.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ledTime.BackColor = System.Drawing.Color.Black;
            this.ledTime.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ledTime.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.ledTime.LineWidth = 12;
            this.ledTime.Location = new System.Drawing.Point(0, 92);
            this.ledTime.Margin = new System.Windows.Forms.Padding(50);
            this.ledTime.Name = "ledTime";
            this.ledTime.Size = new System.Drawing.Size(642, 120);
            this.ledTime.TabIndex = 1;
            this.ledTime.Value = new System.DateTime(2023, 5, 24, 19, 15, 11, 819);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ledTime);
            this.panel1.Controls.Add(this.materialLabel1);
            this.panel1.Location = new System.Drawing.Point(124, 153);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(642, 212);
            this.panel1.TabIndex = 3;
            // 
            // materialLabel1
            // 
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.materialLabel1.Font = new System.Drawing.Font("思源黑体 CN Regular", 34F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.FontType = MaterialSkin.MaterialSkinManager.fontType.H4;
            this.materialLabel1.ForeColor = System.Drawing.Color.White;
            this.materialLabel1.HighEmphasis = true;
            this.materialLabel1.Image = ((System.Drawing.Image)(resources.GetObject("materialLabel1.Image")));
            this.materialLabel1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.materialLabel1.Location = new System.Drawing.Point(0, 0);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(642, 59);
            this.materialLabel1.TabIndex = 2;
            this.materialLabel1.Text = "    休息时间到,键盘鼠标已锁定,出去逛逛吧~";
            this.materialLabel1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // FrmLock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(1)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(1074, 461);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.materialButton1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmLock";
            this.Opacity = 0.9D;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmLock";
            this.TopMost = true;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmLock_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer tmrLock;
        private MaterialSkin.Controls.MaterialButton materialButton1;
        private HZH_Controls.Controls.UCLEDTime ledTime;
        private System.Windows.Forms.Panel panel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
    }
}