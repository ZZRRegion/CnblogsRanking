using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CnblogsRanking
{
    public partial class FrmWebBrowser : FrmBaseDocument
    {
        public string Url { get; set; }
        public FrmWebBrowser()
        {
            InitializeComponent();
        }

        private void FrmWebBrowser_Load(object sender, EventArgs e)
        {
            this.webBrowser1.ScriptErrorsSuppressed = true;
            this.webBrowser1.AllowNavigation = false;
            this.webBrowser1.Navigate(this.Url);
        }
    }
}
