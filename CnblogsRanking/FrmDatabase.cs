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
    public partial class FrmDatabase : FrmBaseDocument
    {
        public CBRank CBRank { get; set; }
        public FrmDatabase()
        {
            InitializeComponent();
        }

        private void FrmDatabase_Load(object sender, EventArgs e)
        {
            List<string> lst = this.CBRank.GetCollectionNames();
            Action action = () => {
                foreach(string item in lst)
                {
                    this.lstBlog.Items.Add(item);
                }
            };
            this.BeginInvoke(action);
        }
    }
}
