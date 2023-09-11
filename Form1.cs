using Cities_Skylines_II___Launcher.Forms;
using Cities_Skylines_II___Launcher.Forms.Help;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cities_Skylines_II___Launcher
{
    public partial class Form1 : DevExpress.XtraEditors.XtraForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void runAsAdminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.ProcessStartInfo StartInfo = new System.Diagnostics.ProcessStartInfo
            {
                UseShellExecute = true, //<- for elevation
                Verb = "runas",  //<- for elevation
                WorkingDirectory = Environment.CurrentDirectory,
                FileName = "Cities Skylines II - Launcher.exe",
                Arguments = @"\D -FF"
            };
            System.Diagnostics.Process p = System.Diagnostics.Process.Start(StartInfo);
        }

        private void playGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("steam://rungameid/949230");
        }

        private void radMenuItem1_Click(object sender, EventArgs e)
        {
            Process.Start("steam://rungameid/949230");
        }

        private void uninstallGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("steam://uninstall/949230");
        }

        private void radMenuItem7_Click(object sender, EventArgs e)
        {
            Process.Start("steam://uninstall/949230");
        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void radButton3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void settingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("steam://overview/949230");
        }

        private void showMenubarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.showMenubarToolStripMenuItem.Checked = !this.showMenubarToolStripMenuItem.Checked;
            this.menuStrip1.Visible = this.showMenubarToolStripMenuItem.Checked;
        }

        private void installSteamToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("https://store.steampowered.com/about/download");
        }

        private void gameWikiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GameWiki testDialog = new GameWiki();
            testDialog.ShowDialog();
        }

        private void radButton1_Click(object sender, EventArgs e)
        {
            GameWiki testDialog = new GameWiki();
            testDialog.ShowDialog();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox1 testDialog = new AboutBox1();
            testDialog.ShowDialog();
        }

        private void checkForUpdatesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.ProcessStartInfo StartInfo = new System.Diagnostics.ProcessStartInfo
            {
                UseShellExecute = true, //<- for elevation
                Verb = "runas",  //<- for elevation
                WorkingDirectory = Environment.CurrentDirectory,
                FileName = "Cities Skylines ll - Louncher Updater.exe",
            };
            System.Diagnostics.Process p = System.Diagnostics.Process.Start(StartInfo);
        }

        private void helpToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            GameHelp testDialog = new GameHelp();
            testDialog.ShowDialog();
        }

        private void radButton4_Click(object sender, EventArgs e)
        {
            GameHelp testDialog = new GameHelp();
            testDialog.ShowDialog();
        }

        private void radMenuItem3_Click(object sender, EventArgs e)
        {
            Process.Start("https://cities-mods.com/xlex/categories/cities-skylines-ii.291/");
        }

        private void radMenuItem4_Click(object sender, EventArgs e)
        {
            Process.Start("https://cities-mods.com/xlex/categories/map.292/");
        }

        private void getMoreMapsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("https://cities-mods.com/xlex/categories/map.292/");
        }

        private void getMoreModsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("https://cities-mods.com/xlex/categories/cities-skylines-ii.291/");
        }

        private void getMoreToolsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("https://cities-mods.com/xlex/categories/buildings.294/");
        }

        private void radMenuItem5_Click(object sender, EventArgs e)
        {
            Process.Start("https://cities-mods.com/xlex/categories/buildings.294/");
        }

        private void downloadCountriesXLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("https://cities-mods.com/xlex/countriesxl.317/");
        }

        private void launchCountriesXLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (File.Exists(@"C:\Program Files\GameTopic\CountriesXL\CountriesXL.exe"))
            {
                Process.Start(@"C:\Program Files\GameTopic\CountriesXL\CountriesXL.exe");
                base.Close();
            }
        }

        private void radButton2_Click(object sender, EventArgs e)
        {

        }
    }
}
