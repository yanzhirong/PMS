namespace PMS.Frm.Sys
{
    partial class FrmSysUser
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSysUser));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_addNew = new System.Windows.Forms.Button();
            this.btn_query = new System.Windows.Forms.Button();
            this.cmb_role = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.userId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roleId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.role = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.position = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mobile = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modify = new System.Windows.Forms.DataGridViewButtonColumn();
            this.delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.lbl_tile = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_addNew);
            this.groupBox1.Controls.Add(this.btn_query);
            this.groupBox1.Controls.Add(this.cmb_role);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txt_name);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(30, 60);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(965, 95);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            // 
            // btn_addNew
            // 
            this.btn_addNew.Location = new System.Drawing.Point(155, 57);
            this.btn_addNew.Name = "btn_addNew";
            this.btn_addNew.Size = new System.Drawing.Size(75, 23);
            this.btn_addNew.TabIndex = 4;
            this.btn_addNew.Text = "新增";
            this.btn_addNew.UseVisualStyleBackColor = true;
            this.btn_addNew.Click += new System.EventHandler(this.btn_addNew_Click);
            // 
            // btn_query
            // 
            this.btn_query.Location = new System.Drawing.Point(27, 57);
            this.btn_query.Name = "btn_query";
            this.btn_query.Size = new System.Drawing.Size(75, 23);
            this.btn_query.TabIndex = 3;
            this.btn_query.Text = "查询";
            this.btn_query.UseVisualStyleBackColor = true;
            this.btn_query.Click += new System.EventHandler(this.btn_query_Click);
            // 
            // cmb_role
            // 
            this.cmb_role.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_role.FormattingEnabled = true;
            this.cmb_role.Location = new System.Drawing.Point(283, 14);
            this.cmb_role.Name = "cmb_role";
            this.cmb_role.Size = new System.Drawing.Size(121, 20);
            this.cmb_role.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(236, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 9;
            this.label2.Text = "角色：";
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(84, 14);
            this.txt_name.MaxLength = 20;
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(100, 21);
            this.txt_name.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 7;
            this.label1.Text = "用户名：";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.userId,
            this.roleId,
            this.name,
            this.role,
            this.sex,
            this.position,
            this.mobile,
            this.email,
            this.createTime,
            this.modify,
            this.delete});
            this.dataGridView1.Location = new System.Drawing.Point(30, 170);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 35;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(965, 418);
            this.dataGridView1.TabIndex = 8;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // userId
            // 
            this.userId.DataPropertyName = "userId";
            this.userId.HeaderText = "用户ID";
            this.userId.Name = "userId";
            this.userId.Visible = false;
            // 
            // roleId
            // 
            this.roleId.DataPropertyName = "roleId";
            this.roleId.HeaderText = "角色ID";
            this.roleId.Name = "roleId";
            this.roleId.ReadOnly = true;
            this.roleId.Visible = false;
            // 
            // name
            // 
            this.name.DataPropertyName = "userName";
            this.name.HeaderText = "用户名";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            this.name.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // role
            // 
            this.role.DataPropertyName = "roleName";
            this.role.HeaderText = "角色";
            this.role.Name = "role";
            this.role.ReadOnly = true;
            // 
            // sex
            // 
            this.sex.DataPropertyName = "sex";
            this.sex.HeaderText = "性别";
            this.sex.Name = "sex";
            this.sex.ReadOnly = true;
            // 
            // position
            // 
            this.position.DataPropertyName = "position";
            this.position.HeaderText = "职位";
            this.position.Name = "position";
            this.position.ReadOnly = true;
            // 
            // mobile
            // 
            this.mobile.DataPropertyName = "mobile";
            this.mobile.HeaderText = "手机";
            this.mobile.Name = "mobile";
            this.mobile.ReadOnly = true;
            this.mobile.Width = 120;
            // 
            // email
            // 
            this.email.DataPropertyName = "email";
            this.email.HeaderText = "电子邮箱";
            this.email.Name = "email";
            this.email.ReadOnly = true;
            this.email.Width = 120;
            // 
            // createTime
            // 
            this.createTime.DataPropertyName = "createTime";
            this.createTime.HeaderText = "创建时间";
            this.createTime.Name = "createTime";
            this.createTime.ReadOnly = true;
            this.createTime.Width = 125;
            // 
            // modify
            // 
            this.modify.DataPropertyName = "modifyBtn";
            this.modify.HeaderText = "修改";
            this.modify.Name = "modify";
            this.modify.Width = 80;
            // 
            // delete
            // 
            this.delete.DataPropertyName = "deleteBtn";
            this.delete.HeaderText = "删除";
            this.delete.Name = "delete";
            this.delete.Width = 80;
            // 
            // lbl_tile
            // 
            this.lbl_tile.AutoSize = true;
            this.lbl_tile.Font = new System.Drawing.Font("宋体", 20F);
            this.lbl_tile.Location = new System.Drawing.Point(428, 33);
            this.lbl_tile.Name = "lbl_tile";
            this.lbl_tile.Size = new System.Drawing.Size(120, 27);
            this.lbl_tile.TabIndex = 69;
            this.lbl_tile.Text = "用户列表";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1024, 24);
            this.menuStrip1.TabIndex = 70;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // FrmSysUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 600);
            this.Controls.Add(this.lbl_tile);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmSysUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "用户管理";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmSysUser_FormClosed);
            this.Load += new System.EventHandler(this.FrmSysUser_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_addNew;
        private System.Windows.Forms.Button btn_query;
        private System.Windows.Forms.ComboBox cmb_role;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn userId;
        private System.Windows.Forms.DataGridViewTextBoxColumn roleId;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn role;
        private System.Windows.Forms.DataGridViewTextBoxColumn sex;
        private System.Windows.Forms.DataGridViewTextBoxColumn position;
        private System.Windows.Forms.DataGridViewTextBoxColumn mobile;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.DataGridViewTextBoxColumn createTime;
        private System.Windows.Forms.DataGridViewButtonColumn modify;
        private System.Windows.Forms.DataGridViewButtonColumn delete;
        private System.Windows.Forms.Label lbl_tile;
        private System.Windows.Forms.MenuStrip menuStrip1;

    }
}