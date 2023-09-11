using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cities_Skylines_II___Launcher.Forms.Help
{
    public partial class GameHelp : Form
    {
        public GameHelp()
        {
            InitializeComponent();
        }

        private void radButton4_Click(object sender, EventArgs e)
        {
            AboutBox1 testDialog = new AboutBox1();
            testDialog.ShowDialog();
            base.Close();
        }

        private void radButton5_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void radButton1_Click(object sender, EventArgs e)
        {
            Process.Start("https://cities-mods.com/xlex/cities-skylines-ll-launcher.337/");
            base.Close();
        }

        private void radButton2_Click(object sender, EventArgs e)
        {

        }
    }
}
