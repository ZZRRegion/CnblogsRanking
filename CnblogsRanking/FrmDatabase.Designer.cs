﻿namespace CnblogsRanking
{
    partial class FrmDatabase
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lstBlog = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lstBlog
            // 
            this.lstBlog.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lstBlog.FormattingEnabled = true;
            this.lstBlog.ItemHeight = 20;
            this.lstBlog.Location = new System.Drawing.Point(12, 3);
            this.lstBlog.Name = "lstBlog";
            this.lstBlog.Size = new System.Drawing.Size(289, 424);
            this.lstBlog.TabIndex = 0;
            // 
            // FrmDatabase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(311, 450);
            this.Controls.Add(this.lstBlog);
            this.Name = "FrmDatabase";
            this.Text = "查看";
            this.Load += new System.EventHandler(this.FrmDatabase_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstBlog;
    }
}