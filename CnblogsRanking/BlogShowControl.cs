using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CnblogsRanking
{
    public partial class BlogShowControl : UserControl
    {
        public CBRank CBRank { get; set; }
        public BlogModel BlogModel { get; set; }
        public BlogShowControl()
        {
            InitializeComponent();
        }

        private void BlogShowControl_Load(object sender, EventArgs e)
        {
            this.lblTitle.Text = this.BlogModel.PostTitle;
            this.lblCon.Text = this.BlogModel.PostCon;
            this.lblPost.Text = this.BlogModel.Post;
            this.llblUrl.Text = this.BlogModel.PostUrl;
        }

        private void LlblUrl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(this.llblUrl.Text);
        }

        private void BtnLook_Click(object sender, EventArgs e)
        {
            FrmWebBrowser frmWebBrowser = new FrmWebBrowser();
            frmWebBrowser.Url = this.llblUrl.Text;
            if(frmWebBrowser.ShowDialog(this) == DialogResult.OK)
            {

            }
        }
    }
}
