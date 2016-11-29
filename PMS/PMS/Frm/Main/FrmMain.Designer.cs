namespace PMS.Frm.Main
{
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.pnl_main = new System.Windows.Forms.Panel();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.lbl_loginInfo = new System.Windows.Forms.Label();
            this.lnk_logout = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // pnl_main
            // 
            this.pnl_main.BackColor = System.Drawing.Color.Aqua;
            this.pnl_main.Location = new System.Drawing.Point(0, 25);
            this.pnl_main.Name = "pnl_main";
            this.pnl_main.Size = new System.Drawing.Size(716, 417);
            this.pnl_main.TabIndex = 3;
            // 
            // menuStrip
            // 
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(717, 24);
            this.menuStrip.TabIndex = 4;
            this.menuStrip.Text = "menuStrip";
            // 
            // lbl_loginInfo
            // 
            this.lbl_loginInfo.AutoSize = true;
            this.lbl_loginInfo.Font = new System.Drawing.Font("宋体", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_loginInfo.ForeColor = System.Drawing.Color.Red;
            this.lbl_loginInfo.Location = new System.Drawing.Point(940, 6);
            this.lbl_loginInfo.Name = "lbl_loginInfo";
            this.lbl_loginInfo.Size = new System.Drawing.Size(0, 12);
            this.lbl_loginInfo.TabIndex = 6;
            this.lbl_loginInfo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lnk_logout
            // 
            this.lnk_logout.AutoSize = true;
            this.lnk_logout.Font = new System.Drawing.Font("宋体", 9F);
            this.lnk_logout.Location = new System.Drawing.Point(687, 6);
            this.lnk_logout.Name = "lnk_logout";
            this.lnk_logout.Size = new System.Drawing.Size(29, 12);
            this.lnk_logout.TabIndex = 7;
            this.lnk_logout.TabStop = true;
            this.lnk_logout.Text = "退出";
            this.lnk_logout.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnk_logout_LinkClicked);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(717, 435);
            this.Controls.Add(this.lnk_logout);
            this.Controls.Add(this.lbl_loginInfo);
            this.Controls.Add(this.pnl_main);
            this.Controls.Add(this.menuStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "生产管理系统";
            this.Activated += new System.EventHandler(this.FrmMain_Activated);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmMain_FormClosed);
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnl_main;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.Label lbl_loginInfo;
        private System.Windows.Forms.LinkLabel lnk_logout;
    }
}