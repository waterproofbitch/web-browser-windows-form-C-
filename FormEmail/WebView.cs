using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormEmail
{
    public partial class WebView : Form
    {
        public WebView()
        {
            InitializeComponent();
            WebBrowser webBrowser = new WebBrowser();
            Controls.Add(webBrowser);
            webBrowser.Size = Size;
            webBrowser.Dock = DockStyle.Fill;
            webBrowser.Navigate("ya.ru");
            
        }

        private void WebView_Load(object sender, EventArgs e)
        {

        }
    }
}
