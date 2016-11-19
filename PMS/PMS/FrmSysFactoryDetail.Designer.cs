namespace PMS
{
    partial class FrmSysFactoryDetail
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
            this.lbl_role = new System.Windows.Forms.Label();
            this.btn_submit = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.lbl_title = new System.Windows.Forms.Label();
            this.grb_factory = new System.Windows.Forms.GroupBox();
            this.txt_fax = new System.Windows.Forms.TextBox();
            this.lbl_fax = new System.Windows.Forms.Label();
            this.txt_telphone = new System.Windows.Forms.TextBox();
            this.lbl_telphone = new System.Windows.Forms.Label();
            this.txt_address = new System.Windows.Forms.TextBox();
            this.lbl_address = new System.Windows.Forms.Label();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.lbl_name = new System.Windows.Forms.Label();
            this.txt_zip = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grb_factory.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_role
            // 
            this.lbl_role.AutoSize = true;
            this.lbl_role.Location = new System.Drawing.Point(28, 54);
            this.lbl_role.Name = "lbl_role";
            this.lbl_role.Size = new System.Drawing.Size(0, 12);
            this.lbl_role.TabIndex = 11;
            // 
            // btn_submit
            // 
            this.btn_submit.Location = new System.Drawing.Point(201, 344);
            this.btn_submit.Name = "btn_submit";
            this.btn_submit.Size = new System.Drawing.Size(75, 23);
            this.btn_submit.TabIndex = 6;
            this.btn_submit.Text = "确定";
            this.btn_submit.UseVisualStyleBackColor = true;
            this.btn_submit.Click += new System.EventHandler(this.btn_submit_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(387, 340);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(75, 27);
            this.btn_cancel.TabIndex = 7;
            this.btn_cancel.Text = "取消";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.Font = new System.Drawing.Font("宋体", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_title.Location = new System.Drawing.Point(216, 20);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(180, 27);
            this.lbl_title.TabIndex = 66;
            this.lbl_title.Text = "仓库信息管理";
            // 
            // grb_factory
            // 
            this.grb_factory.Controls.Add(this.txt_zip);
            this.grb_factory.Controls.Add(this.label1);
            this.grb_factory.Controls.Add(this.txt_fax);
            this.grb_factory.Controls.Add(this.lbl_fax);
            this.grb_factory.Controls.Add(this.txt_telphone);
            this.grb_factory.Controls.Add(this.lbl_telphone);
            this.grb_factory.Controls.Add(this.txt_address);
            this.grb_factory.Controls.Add(this.lbl_address);
            this.grb_factory.Controls.Add(this.txt_name);
            this.grb_factory.Controls.Add(this.lbl_name);
            this.grb_factory.Location = new System.Drawing.Point(52, 59);
            this.grb_factory.Name = "grb_factory";
            this.grb_factory.Size = new System.Drawing.Size(550, 250);
            this.grb_factory.TabIndex = 67;
            this.grb_factory.TabStop = false;
            // 
            // txt_fax
            // 
            this.txt_fax.Location = new System.Drawing.Point(121, 166);
            this.txt_fax.MaxLength = 50;
            this.txt_fax.Name = "txt_fax";
            this.txt_fax.Size = new System.Drawing.Size(400, 21);
            this.txt_fax.TabIndex = 4;
            // 
            // lbl_fax
            // 
            this.lbl_fax.AutoSize = true;
            this.lbl_fax.Location = new System.Drawing.Point(30, 169);
            this.lbl_fax.Name = "lbl_fax";
            this.lbl_fax.Size = new System.Drawing.Size(65, 12);
            this.lbl_fax.TabIndex = 66;
            this.lbl_fax.Text = "传    真：";
            // 
            // txt_telphone
            // 
            this.txt_telphone.Location = new System.Drawing.Point(121, 121);
            this.txt_telphone.MaxLength = 50;
            this.txt_telphone.Name = "txt_telphone";
            this.txt_telphone.Size = new System.Drawing.Size(400, 21);
            this.txt_telphone.TabIndex = 3;
            // 
            // lbl_telphone
            // 
            this.lbl_telphone.AutoSize = true;
            this.lbl_telphone.Location = new System.Drawing.Point(30, 124);
            this.lbl_telphone.Name = "lbl_telphone";
            this.lbl_telphone.Size = new System.Drawing.Size(65, 12);
            this.lbl_telphone.TabIndex = 65;
            this.lbl_telphone.Text = "联系电话：";
            // 
            // txt_address
            // 
            this.txt_address.Location = new System.Drawing.Point(121, 75);
            this.txt_address.MaxLength = 200;
            this.txt_address.Name = "txt_address";
            this.txt_address.Size = new System.Drawing.Size(400, 21);
            this.txt_address.TabIndex = 2;
            // 
            // lbl_address
            // 
            this.lbl_address.AutoSize = true;
            this.lbl_address.Location = new System.Drawing.Point(30, 78);
            this.lbl_address.Name = "lbl_address";
            this.lbl_address.Size = new System.Drawing.Size(65, 12);
            this.lbl_address.TabIndex = 64;
            this.lbl_address.Text = "仓库地址：";
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(121, 27);
            this.txt_name.MaxLength = 100;
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(400, 21);
            this.txt_name.TabIndex = 1;
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Location = new System.Drawing.Point(30, 30);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(65, 12);
            this.lbl_name.TabIndex = 63;
            this.lbl_name.Text = "仓库名称：";
            // 
            // txt_zip
            // 
            this.txt_zip.Location = new System.Drawing.Point(121, 210);
            this.txt_zip.MaxLength = 50;
            this.txt_zip.Name = "txt_zip";
            this.txt_zip.Size = new System.Drawing.Size(400, 21);
            this.txt_zip.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 213);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 68;
            this.label1.Text = "邮    编：";
            // 
            // FrmSysFactoryDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 403);
            this.Controls.Add(this.lbl_title);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_submit);
            this.Controls.Add(this.lbl_role);
            this.Controls.Add(this.grb_factory);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmSysFactoryDetail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FrmSysFactoryDetail_Load);
            this.grb_factory.ResumeLayout(false);
            this.grb_factory.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_role;
        private System.Windows.Forms.Button btn_submit;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.GroupBox grb_factory;
        private System.Windows.Forms.TextBox txt_fax;
        private System.Windows.Forms.Label lbl_fax;
        private System.Windows.Forms.TextBox txt_telphone;
        private System.Windows.Forms.Label lbl_telphone;
        private System.Windows.Forms.TextBox txt_address;
        private System.Windows.Forms.Label lbl_address;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.TextBox txt_zip;
        private System.Windows.Forms.Label label1;

    }
}