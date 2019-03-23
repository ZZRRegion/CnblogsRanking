namespace CnblogsRanking
{
    partial class BlogShowControl
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

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblCon = new System.Windows.Forms.Label();
            this.lblPost = new System.Windows.Forms.Label();
            this.llblUrl = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.lblTitle.Location = new System.Drawing.Point(46, 5);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(663, 45);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "标题";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCon
            // 
            this.lblCon.AutoEllipsis = true;
            this.lblCon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblCon.Location = new System.Drawing.Point(46, 50);
            this.lblCon.Name = "lblCon";
            this.lblCon.Size = new System.Drawing.Size(663, 35);
            this.lblCon.TabIndex = 1;
            this.lblCon.Text = "摘要";
            this.lblCon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPost
            // 
            this.lblPost.AutoEllipsis = true;
            this.lblPost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblPost.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblPost.Location = new System.Drawing.Point(46, 85);
            this.lblPost.Name = "lblPost";
            this.lblPost.Size = new System.Drawing.Size(663, 36);
            this.lblPost.TabIndex = 2;
            this.lblPost.Text = "Post";
            this.lblPost.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // llblUrl
            // 
            this.llblUrl.AutoSize = true;
            this.llblUrl.Location = new System.Drawing.Point(49, 126);
            this.llblUrl.Name = "llblUrl";
            this.llblUrl.Size = new System.Drawing.Size(65, 12);
            this.llblUrl.TabIndex = 3;
            this.llblUrl.TabStop = true;
            this.llblUrl.Text = "linkLabel1";
            this.llblUrl.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LlblUrl_LinkClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "标题：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 5;
            this.label2.Text = "摘要：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 12);
            this.label3.TabIndex = 6;
            this.label3.Text = "Post:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 7;
            this.label4.Text = "地址：";
            // 
            // BlogShowControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.llblUrl);
            this.Controls.Add(this.lblPost);
            this.Controls.Add(this.lblCon);
            this.Controls.Add(this.lblTitle);
            this.Name = "BlogShowControl";
            this.Size = new System.Drawing.Size(715, 148);
            this.Load += new System.EventHandler(this.BlogShowControl_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblCon;
        private System.Windows.Forms.Label lblPost;
        private System.Windows.Forms.LinkLabel llblUrl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}
