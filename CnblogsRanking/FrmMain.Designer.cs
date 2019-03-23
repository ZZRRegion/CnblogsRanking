namespace CnblogsRanking
{
    partial class FrmMain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.lstRank = new System.Windows.Forms.ListBox();
            this.grpInfo = new System.Windows.Forms.GroupBox();
            this.txtDate = new System.Windows.Forms.TextBox();
            this.lblDate = new System.Windows.Forms.Label();
            this.txtScore = new System.Windows.Forms.TextBox();
            this.lblScore = new System.Windows.Forms.Label();
            this.llblUrl = new System.Windows.Forms.LinkLabel();
            this.lblUrl = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.grpSort = new System.Windows.Forms.GroupBox();
            this.rdoName = new System.Windows.Forms.RadioButton();
            this.rdoScore = new System.Windows.Forms.RadioButton();
            this.rdoDate = new System.Windows.Forms.RadioButton();
            this.btnLook = new System.Windows.Forms.Button();
            this.btnDatabase = new System.Windows.Forms.Button();
            this.grpInfo.SuspendLayout();
            this.grpSort.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstRank
            // 
            this.lstRank.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lstRank.FormattingEnabled = true;
            this.lstRank.ItemHeight = 20;
            this.lstRank.Location = new System.Drawing.Point(31, 101);
            this.lstRank.Name = "lstRank";
            this.lstRank.Size = new System.Drawing.Size(829, 424);
            this.lstRank.TabIndex = 0;
            this.lstRank.SelectedIndexChanged += new System.EventHandler(this.LstRank_SelectedIndexChanged);
            // 
            // grpInfo
            // 
            this.grpInfo.Controls.Add(this.txtDate);
            this.grpInfo.Controls.Add(this.lblDate);
            this.grpInfo.Controls.Add(this.txtScore);
            this.grpInfo.Controls.Add(this.lblScore);
            this.grpInfo.Controls.Add(this.llblUrl);
            this.grpInfo.Controls.Add(this.lblUrl);
            this.grpInfo.Controls.Add(this.txtName);
            this.grpInfo.Controls.Add(this.lblName);
            this.grpInfo.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.grpInfo.Location = new System.Drawing.Point(868, 12);
            this.grpInfo.Name = "grpInfo";
            this.grpInfo.Size = new System.Drawing.Size(400, 233);
            this.grpInfo.TabIndex = 1;
            this.grpInfo.TabStop = false;
            this.grpInfo.Text = "个人信息";
            // 
            // txtDate
            // 
            this.txtDate.Location = new System.Drawing.Point(128, 191);
            this.txtDate.Name = "txtDate";
            this.txtDate.ReadOnly = true;
            this.txtDate.Size = new System.Drawing.Size(255, 30);
            this.txtDate.TabIndex = 7;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(14, 196);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(109, 20);
            this.lblDate.TabIndex = 6;
            this.lblDate.Text = "更新日期：";
            // 
            // txtScore
            // 
            this.txtScore.Location = new System.Drawing.Point(128, 136);
            this.txtScore.Name = "txtScore";
            this.txtScore.ReadOnly = true;
            this.txtScore.Size = new System.Drawing.Size(255, 30);
            this.txtScore.TabIndex = 5;
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Location = new System.Drawing.Point(54, 141);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(69, 20);
            this.lblScore.TabIndex = 4;
            this.lblScore.Text = "积分：";
            // 
            // llblUrl
            // 
            this.llblUrl.AutoSize = true;
            this.llblUrl.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.llblUrl.Location = new System.Drawing.Point(128, 93);
            this.llblUrl.Name = "llblUrl";
            this.llblUrl.Size = new System.Drawing.Size(88, 16);
            this.llblUrl.TabIndex = 3;
            this.llblUrl.TabStop = true;
            this.llblUrl.Text = "linkLabel1";
            this.llblUrl.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LlblUrl_LinkClicked);
            // 
            // lblUrl
            // 
            this.lblUrl.AutoSize = true;
            this.lblUrl.Location = new System.Drawing.Point(14, 93);
            this.lblUrl.Name = "lblUrl";
            this.lblUrl.Size = new System.Drawing.Size(109, 20);
            this.lblUrl.TabIndex = 2;
            this.lblUrl.Text = "个人主页：";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(128, 40);
            this.txtName.Name = "txtName";
            this.txtName.ReadOnly = true;
            this.txtName.Size = new System.Drawing.Size(255, 30);
            this.txtName.TabIndex = 1;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(34, 45);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(89, 20);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "用户名：";
            // 
            // grpSort
            // 
            this.grpSort.Controls.Add(this.rdoName);
            this.grpSort.Controls.Add(this.rdoScore);
            this.grpSort.Controls.Add(this.rdoDate);
            this.grpSort.Location = new System.Drawing.Point(31, 12);
            this.grpSort.Name = "grpSort";
            this.grpSort.Size = new System.Drawing.Size(185, 72);
            this.grpSort.TabIndex = 2;
            this.grpSort.TabStop = false;
            this.grpSort.Text = "排序";
            // 
            // rdoName
            // 
            this.rdoName.AutoSize = true;
            this.rdoName.Location = new System.Drawing.Point(113, 21);
            this.rdoName.Name = "rdoName";
            this.rdoName.Size = new System.Drawing.Size(71, 16);
            this.rdoName.TabIndex = 2;
            this.rdoName.TabStop = true;
            this.rdoName.Text = "按用户名";
            this.rdoName.UseVisualStyleBackColor = true;
            // 
            // rdoScore
            // 
            this.rdoScore.AutoSize = true;
            this.rdoScore.Location = new System.Drawing.Point(19, 46);
            this.rdoScore.Name = "rdoScore";
            this.rdoScore.Size = new System.Drawing.Size(59, 16);
            this.rdoScore.TabIndex = 1;
            this.rdoScore.TabStop = true;
            this.rdoScore.Text = "按积分";
            this.rdoScore.UseVisualStyleBackColor = true;
            // 
            // rdoDate
            // 
            this.rdoDate.AutoSize = true;
            this.rdoDate.Location = new System.Drawing.Point(19, 21);
            this.rdoDate.Name = "rdoDate";
            this.rdoDate.Size = new System.Drawing.Size(59, 16);
            this.rdoDate.TabIndex = 0;
            this.rdoDate.TabStop = true;
            this.rdoDate.Text = "按时间";
            this.rdoDate.UseVisualStyleBackColor = true;
            // 
            // btnLook
            // 
            this.btnLook.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnLook.Location = new System.Drawing.Point(868, 251);
            this.btnLook.Name = "btnLook";
            this.btnLook.Size = new System.Drawing.Size(123, 41);
            this.btnLook.TabIndex = 3;
            this.btnLook.Text = "查看博客";
            this.btnLook.UseVisualStyleBackColor = true;
            this.btnLook.Click += new System.EventHandler(this.BtnLook_Click);
            // 
            // btnDatabase
            // 
            this.btnDatabase.Location = new System.Drawing.Point(868, 304);
            this.btnDatabase.Name = "btnDatabase";
            this.btnDatabase.Size = new System.Drawing.Size(123, 41);
            this.btnDatabase.TabIndex = 4;
            this.btnDatabase.Text = "查看LiteDB数据库";
            this.btnDatabase.UseVisualStyleBackColor = true;
            this.btnDatabase.Click += new System.EventHandler(this.BtnDatabase_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1277, 533);
            this.Controls.Add(this.btnDatabase);
            this.Controls.Add(this.btnLook);
            this.Controls.Add(this.grpSort);
            this.Controls.Add(this.grpInfo);
            this.Controls.Add(this.lstRank);
            this.MinimizeBox = true;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "博客园排行";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmMain_FormClosing);
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.grpInfo.ResumeLayout(false);
            this.grpInfo.PerformLayout();
            this.grpSort.ResumeLayout(false);
            this.grpSort.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstRank;
        private System.Windows.Forms.GroupBox grpInfo;
        private System.Windows.Forms.TextBox txtScore;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.LinkLabel llblUrl;
        private System.Windows.Forms.Label lblUrl;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtDate;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.GroupBox grpSort;
        private System.Windows.Forms.RadioButton rdoName;
        private System.Windows.Forms.RadioButton rdoScore;
        private System.Windows.Forms.RadioButton rdoDate;
        private System.Windows.Forms.Button btnLook;
        private System.Windows.Forms.Button btnDatabase;
    }
}

