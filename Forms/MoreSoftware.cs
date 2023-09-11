using Cities_Skylines_II___Launcher.Forms.Help;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cities_Skylines_II___Launcher.Forms
{
    public partial class MoreSoftware : Form
    {
        public MoreSoftware()
        {
            InitializeComponent();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox1 testDialog = new AboutBox1();
            testDialog.ShowDialog();
        }

        private void helpToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            GameHelp testDialog = new GameHelp();
            testDialog.ShowDialog();
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void radMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void radMenuItem2_Click(object sender, EventArgs e)
        {

        }
    }
}
