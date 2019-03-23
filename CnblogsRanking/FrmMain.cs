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
    public partial class FrmMain : FrmBaseDocument
    {
        public Dictionary<string, RankModel> DictRank { get; private set; }
        public CBRank CBRank { get; } = new CBRank();
        public FrmMain()
        {
            InitializeComponent();
        }

        private async void FrmMain_Load(object sender, EventArgs e)
        {
            this.DictRank = await this.CBRank.Start();
            this.LoadRank(this.DictRank.Values.ToList());
            foreach(RadioButton rdo in this.grpSort.Controls)
            {
                rdo.CheckedChanged += (s, ee) => {
                    if (rdo.Checked)
                    {
                        List<RankModel> lst = new List<RankModel>();
                        switch (rdo.Name)
                        {
                            case "rdoDate":
                                lst = this.DictRank.Values.OrderByDescending(item => item.LastDateTime).ToList();
                                break;
                            case "rdoName":
                                lst = this.DictRank.Values.OrderBy(item => item.Name).ToList();
                                break;
                            case "rdoScore":
                                lst = this.DictRank.Values.OrderByDescending(item => item.Score).ToList();
                                break;
                        }
                        this.LoadRank(lst);
                    }
                };
            }
            await Task.Run(() => {
                this.CBRank.SaveRankModel(this.DictRank);
            });
        }
        /// <summary>
        /// 加载显示
        /// </summary>
        /// <param name="ranks"></param>
        private void LoadRank(List<RankModel> ranks)
        {
            this.lstRank.BeginUpdate();
            this.lstRank.Items.Clear();
            foreach(RankModel model in ranks)
            {
                this.lstRank.Items.Add(model);
            }
            this.lstRank.EndUpdate();
            this.lstRank.SelectedIndex = 0;
        }
        private void LstRank_SelectedIndexChanged(object sender, EventArgs e)
        {
            RankModel rankModel = this.lstRank.SelectedItem as RankModel;
            if(rankModel != null)
            {
                this.txtName.Text = rankModel.Name;
                this.txtScore.Text = rankModel.Score;
                this.llblUrl.Text = rankModel.Url;
                this.txtDate.Text = rankModel.LastDateTime.ToLongDateString();
            }
        }

        private void LlblUrl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(this.llblUrl.Text);
        }

        private void BtnLook_Click(object sender, EventArgs e)
        {
            RankModel rankModel = this.lstRank.SelectedItem as RankModel;
            if(rankModel != null)
            {
                FrmBlog frmBlog = new FrmBlog();
                frmBlog.RankModel = rankModel;
                frmBlog.CBRank = this.CBRank;
                if(frmBlog.ShowDialog(this) == DialogResult.OK)
                {

                }
            }
        }

        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
        }

        private void BtnDatabase_Click(object sender, EventArgs e)
        {
            FrmDatabase frmDatabase = new FrmDatabase();
            frmDatabase.CBRank = this.CBRank;
            if(frmDatabase.ShowDialog(this) == DialogResult.OK)
            {

            }
        }
    }
}
