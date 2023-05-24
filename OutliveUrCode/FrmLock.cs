﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace OutliveUrCode
{
    public partial class FrmLock : Form
    {
        [System.Runtime.InteropServices.DllImport("user32.dll", CharSet = System.Runtime.InteropServices.CharSet.Auto, ExactSpelling = true)]
        public static extern IntPtr GetForegroundWindow(); //获得本窗体的句柄
        [System.Runtime.InteropServices.DllImport("user32.dll", EntryPoint = "SetForegroundWindow")]
        public static extern bool SetForegroundWindow(IntPtr hWnd);//设置此窗体为活动窗体
        //定义变量,句柄类型
        public IntPtr myHandle;

        private Stopwatch sw = new Stopwatch();

        private int restTime;

        private FrmLock()
        {
            InitializeComponent();
        }
        public FrmLock(int restTime)
        {
            InitializeComponent();
            this.restTime = restTime;
            sw.Start();
            tmrLock.Enabled = true;
        }
        

        private void FrmLock_Load(object sender, EventArgs e)
        {
            myHandle = this.Handle;
            this.panel1.Left = (this.Width - panel1.Width) / 2;   // 使窗体居中
            this.panel1.Top = (this.Height - panel1.Height) / 2;
            ledTime.Value = new DateTime() + new TimeSpan(0, restTime, 0);
        }

        private void tmrLock_Tick(object sender, EventArgs e)
        {
            SetForegroundWindow(myHandle);
            if (new TimeSpan(0, restTime, 0) - sw.Elapsed <= new TimeSpan(0, 0, 1))
            {
                this.DialogResult = DialogResult.OK;
                tmrLock.Enabled = false;
                sw.Reset();
            }
            ledTime.Value = new DateTime() + (new TimeSpan(0,restTime,0) - sw.Elapsed);
        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK ;
        }
    }
}