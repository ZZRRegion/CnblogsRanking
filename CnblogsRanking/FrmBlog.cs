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
    public partial class FrmBlog : FrmBaseDocument
    {
        public CBRank CBRank { get; set; }
        public RankModel RankModel { get; set; }
        public FrmBlog()
        {
            InitializeComponent();
        }

        private async void FrmBlog_Load(object sender, EventArgs e)
        {
            List<BlogModel> lst = await this.CBRank.LookBlog(this.RankModel.Url);
            this.LoadBlog(lst);
            await Task.Run(() => {
                this.CBRank.SaveBlogModel(lst, this.RankModel.Name);
            });
        }
        private void LoadBlog(List<BlogModel> lst)
        {
            int height = 10;
            foreach(BlogModel blogModel in lst)
            {
                BlogShowControl blogShowControl = new BlogShowControl();
                blogShowControl.BlogModel = blogModel;
                this.Controls.Add(blogShowControl);
                blogShowControl.Location = new Point(20, height);
                height += blogShowControl.Height + 10;
            }
        }
    }
}
