using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CefSharp.MinimalExample.WinForms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            chromiumWebBrowser1.Load("https://twitter.com");
            chromiumWebBrowser2.Load("https://m.facebook.com");
            chromiumWebBrowser3.Load("https://web.telegram.org");
            chromiumWebBrowser4.Load("https://instagram.com");
        }

        private void chromiumWebBrowser1_LoadingStateChanged(object sender, LoadingStateChangedEventArgs e)
        {

        }

        private void chromiumWebBrowser4_LoadingStateChanged(object sender, LoadingStateChangedEventArgs e)
        {

        }
    }
}
