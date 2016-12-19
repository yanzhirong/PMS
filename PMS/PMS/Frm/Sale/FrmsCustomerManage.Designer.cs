namespace PMS.Frm.Sale
{
    partial class FrmCustomerManage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCustomerManage));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmb_type = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_addNew = new System.Windows.Forms.Button();
            this.btn_query = new System.Windows.Forms.Button();
            this.txt_code = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.lbl_tile = new System.Windows.Forms.Label();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.province = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.city = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telephone1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.manager = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mobile = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saler = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modifyBtn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.deleteBtn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmb_type);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txt_name);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btn_addNew);
            this.groupBox1.Controls.Add(this.btn_query);
            this.groupBox1.Controls.Add(this.txt_code);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(30, 79);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(995, 95);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            // 
            // cmb_type
            // 
            this.cmb_type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_type.FormattingEnabled = true;
            this.cmb_type.Items.AddRange(new object[] {
            "销售客户",
            "供应商"});
            this.cmb_type.Location = new System.Drawing.Point(456, 14);
            this.cmb_type.Name = "cmb_type";
            this.cmb_type.Size = new System.Drawing.Size(121, 20);
            this.cmb_type.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(394, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 10;
            this.label3.Text = "客户类型：";
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(268, 14);
            this.txt_name.MaxLength = 20;
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(100, 21);
            this.txt_name.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(208, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 9;
            this.label2.Text = "客户名称：";
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
            // txt_code
            // 
            this.txt_code.Location = new System.Drawing.Point(84, 14);
            this.txt_code.MaxLength = 20;
            this.txt_code.Name = "txt_code";
            this.txt_code.Size = new System.Drawing.Size(100, 21);
            this.txt_code.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 7;
            this.label1.Text = "客户代码：";
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
            this.id,
            this.code,
            this.name,
            this.province,
            this.city,
            this.telephone1,
            this.manager,
            this.mobile,
            this.type,
            this.saler,
            this.modifyBtn,
            this.deleteBtn});
            this.dataGridView1.Location = new System.Drawing.Point(30, 188);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 20;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(995, 400);
            this.dataGridView1.TabIndex = 8;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1044, 24);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // lbl_tile
            // 
            this.lbl_tile.AutoSize = true;
            this.lbl_tile.Font = new System.Drawing.Font("宋体", 20F);
            this.lbl_tile.Location = new System.Drawing.Point(431, 34);
            this.lbl_tile.Name = "lbl_tile";
            this.lbl_tile.Size = new System.Drawing.Size(120, 27);
            this.lbl_tile.TabIndex = 67;
            this.lbl_tile.Text = "客户列表";
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.Visible = false;
            // 
            // code
            // 
            this.code.DataPropertyName = "code";
            this.code.HeaderText = "客户代码";
            this.code.Name = "code";
            this.code.ReadOnly = true;
            this.code.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.code.Width = 90;
            // 
            // name
            // 
            this.name.DataPropertyName = "name";
            this.name.HeaderText = "客户名称";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            // 
            // province
            // 
            this.province.DataPropertyName = "provinceName";
            this.province.HeaderText = "省";
            this.province.Name = "province";
            this.province.ReadOnly = true;
            this.province.Width = 80;
            // 
            // city
            // 
            this.city.DataPropertyName = "cityName";
            this.city.HeaderText = "市";
            this.city.Name = "city";
            this.city.ReadOnly = true;
            this.city.Width = 80;
            // 
            // telephone1
            // 
            this.telephone1.DataPropertyName = "telephone1";
            this.telephone1.HeaderText = "公司电话";
            this.telephone1.Name = "telephone1";
            this.telephone1.ReadOnly = true;
            // 
            // manager
            // 
            this.manager.DataPropertyName = "manager";
            this.manager.HeaderText = "联系人";
            this.manager.Name = "manager";
            this.manager.ReadOnly = true;
            this.manager.Width = 80;
            // 
            // mobile
            // 
            this.mobile.HeaderText = "联系电话";
            this.mobile.Name = "mobile";
            this.mobile.ReadOnly = true;
            // 
            // type
            // 
            this.type.HeaderText = "客户类型";
            this.type.Name = "type";
            this.type.ReadOnly = true;
            // 
            // saler
            // 
            this.saler.HeaderText = "销售";
            this.saler.Name = "saler";
            this.saler.ReadOnly = true;
            this.saler.Width = 80;
            // 
            // modifyBtn
            // 
            this.modifyBtn.DataPropertyName = "modifyBtn";
            this.modifyBtn.HeaderText = "修改";
            this.modifyBtn.Name = "modifyBtn";
            this.modifyBtn.Width = 80;
            // 
            // deleteBtn
            // 
            this.deleteBtn.DataPropertyName = "deleteBtn";
            this.deleteBtn.HeaderText = "删除";
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Width = 80;
            // 
            // FrmCustomerManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1044, 611);
            this.Controls.Add(this.lbl_tile);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmCustomerManage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "客户管理";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmCustomerManage_FormClosed);
            this.Load += new System.EventHandler(this.FrmCustomerManage_Load);
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
        private System.Windows.Forms.TextBox txt_code;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Label lbl_tile;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmb_type;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn code;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn province;
        private System.Windows.Forms.DataGridViewTextBoxColumn city;
        private System.Windows.Forms.DataGridViewTextBoxColumn telephone1;
        private System.Windows.Forms.DataGridViewTextBoxColumn manager;
        private System.Windows.Forms.DataGridViewTextBoxColumn mobile;
        private System.Windows.Forms.DataGridViewTextBoxColumn type;
        private System.Windows.Forms.DataGridViewTextBoxColumn saler;
        private System.Windows.Forms.DataGridViewButtonColumn modifyBtn;
        private System.Windows.Forms.DataGridViewButtonColumn deleteBtn;

    }
}