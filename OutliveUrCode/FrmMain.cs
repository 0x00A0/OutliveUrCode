using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;

namespace OutliveUrCode
{
    public partial class FrmMain : MaterialForm
    {
        private readonly MaterialSkinManager materialSkinManager;
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
        }
    }
}
