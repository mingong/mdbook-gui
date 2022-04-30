using System.Windows.Forms;
using System.Diagnostics;

using mdbook_gui.Controls;

namespace mdbook_gui.Forms
{
    public partial class AboutForm : Form
    {
        public AboutForm()
        {
            InitializeComponent();
        }

        private void AboutForm_Load(object sender, System.EventArgs e)
        {
            versionLb.Text = "Version" + " " + Application.ProductVersion;
        }

        private void WebsiteLb_Click(object sender, System.EventArgs e)
        {
            _ = Process.Start(CONSTANTS.DOTNETCORE_EXPLORER, @"https://github.com/");
        }

        private void Author13Lb_Click(object sender, System.EventArgs e)
        {
            _ = Process.Start(CONSTANTS.DOTNETCORE_EXPLORER, CONSTANTS.AUTHOR_URL);
        }

        private void Author24Lb_Click(object sender, System.EventArgs e)
        {

        }
    }
}

/*
**  mdbook-gui\mdbook-gui\Forms\AboutForm.cs
*/
