using DevExpress.Drawing.Internal.Fonts.Interop;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media.Media3D;
using static DevExpress.XtraPrinting.Native.ExportOptionsPropertiesNames;

namespace Cities_Skylines_II___Launcher.Forms
{
    public partial class GameWiki : Form
    {
        public GameWiki()
        {
            InitializeComponent();
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            var embed = "<html><head>" +
            "<meta http-equiv=\"X-UA-Compatible\" content=\"IE=Edge\"/>" +
            "</head><body>" +
            "<iframe width=\"300\" src=\"{0}\"" +
            "frameborder = \"0\" allow = \"width=\"646\" height=\"190\"></iframe>" +
            "</body></html>";
            var url = "https://store.steampowered.com/widget/949230/308871/";
            this.webBrowser1.DocumentText = string.Format(embed, url);
        }
    }
}
