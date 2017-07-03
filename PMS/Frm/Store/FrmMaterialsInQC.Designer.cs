namespace PMS.Frm.Store
{
    partial class FrmMaterialsInQC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMaterialsInQC));
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.grb_customer = new System.Windows.Forms.GroupBox();
            this.txt_factoryName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QCName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.remark = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reviewBtn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.deleteBtn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.grb_new = new System.Windows.Forms.GroupBox();
            this.txt_remark = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_new_certName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_new_add = new System.Windows.Forms.Button();
            this.btn_select = new System.Windows.Forms.Button();
            this.txt_new_certPath = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_MaterialsName = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.lbl_title = new System.Windows.Forms.Label();
            this.btn_close = new System.Windows.Forms.Button();
            this.grb_customer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.grb_new.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // grb_customer
            // 
            this.grb_customer.Controls.Add(this.txt_factoryName);
            this.grb_customer.Controls.Add(this.label5);
            this.grb_customer.Controls.Add(this.dataGridView1);
            this.grb_customer.Controls.Add(this.grb_new);
            this.grb_customer.Controls.Add(this.txt_MaterialsName);
            this.grb_customer.Controls.Add(this.label15);
            this.grb_customer.Location = new System.Drawing.Point(31, 70);
            this.grb_customer.Name = "grb_customer";
            this.grb_customer.Size = new System.Drawing.Size(619, 406);
            this.grb_customer.TabIndex = 103;
            this.grb_customer.TabStop = false;
            // 
            // txt_factoryName
            // 
            this.txt_factoryName.Enabled = false;
            this.txt_factoryName.ImeMode = System.Windows.Forms.ImeMode.Hangul;
            this.txt_factoryName.Location = new System.Drawing.Point(87, 60);
            this.txt_factoryName.MaxLength = 50;
            this.txt_factoryName.Name = "txt_factoryName";
            this.txt_factoryName.Size = new System.Drawing.Size(508, 21);
            this.txt_factoryName.TabIndex = 65;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(16, 65);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 12);
            this.label5.TabIndex = 66;
            this.label5.Text = "库房名称：";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.QCName,
            this.remark,
            this.reviewBtn,
            this.deleteBtn});
            this.dataGridView1.Location = new System.Drawing.Point(18, 103);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(583, 150);
            this.dataGridView1.TabIndex = 64;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.Visible = false;
            this.id.Width = 10;
            // 
            // QCName
            // 
            this.QCName.DataPropertyName = "QCName";
            this.QCName.HeaderText = "质检报告";
            this.QCName.Name = "QCName";
            this.QCName.ReadOnly = true;
            this.QCName.Width = 150;
            // 
            // remark
            // 
            this.remark.DataPropertyName = "remark";
            this.remark.HeaderText = "说明";
            this.remark.Name = "remark";
            this.remark.ReadOnly = true;
            this.remark.Width = 250;
            // 
            // reviewBtn
            // 
            this.reviewBtn.DataPropertyName = "reviewBtn";
            this.reviewBtn.HeaderText = "查看";
            this.reviewBtn.Name = "reviewBtn";
            this.reviewBtn.ReadOnly = true;
            this.reviewBtn.Width = 60;
            // 
            // deleteBtn
            // 
            this.deleteBtn.DataPropertyName = "deleteBtn";
            this.deleteBtn.HeaderText = "删除";
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.ReadOnly = true;
            this.deleteBtn.Width = 60;
            // 
            // grb_new
            // 
            this.grb_new.Controls.Add(this.txt_remark);
            this.grb_new.Controls.Add(this.label1);
            this.grb_new.Controls.Add(this.txt_new_certName);
            this.grb_new.Controls.Add(this.label4);
            this.grb_new.Controls.Add(this.btn_new_add);
            this.grb_new.Controls.Add(this.btn_select);
            this.grb_new.Controls.Add(this.txt_new_certPath);
            this.grb_new.Controls.Add(this.label3);
            this.grb_new.Controls.Add(this.label2);
            this.grb_new.Location = new System.Drawing.Point(18, 265);
            this.grb_new.Name = "grb_new";
            this.grb_new.Size = new System.Drawing.Size(583, 131);
            this.grb_new.TabIndex = 63;
            this.grb_new.TabStop = false;
            // 
            // txt_remark
            // 
            this.txt_remark.ImeMode = System.Windows.Forms.ImeMode.HangulFull;
            this.txt_remark.Location = new System.Drawing.Point(88, 66);
            this.txt_remark.MaxLength = 100;
            this.txt_remark.Name = "txt_remark";
            this.txt_remark.Size = new System.Drawing.Size(489, 21);
            this.txt_remark.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(17, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 108;
            this.label1.Text = "报告说明：";
            // 
            // txt_new_certName
            // 
            this.txt_new_certName.ImeMode = System.Windows.Forms.ImeMode.HangulFull;
            this.txt_new_certName.Location = new System.Drawing.Point(88, 42);
            this.txt_new_certName.MaxLength = 50;
            this.txt_new_certName.Name = "txt_new_certName";
            this.txt_new_certName.Size = new System.Drawing.Size(489, 21);
            this.txt_new_certName.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(17, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 106;
            this.label4.Text = "报告名称：";
            // 
            // btn_new_add
            // 
            this.btn_new_add.Location = new System.Drawing.Point(13, 93);
            this.btn_new_add.Name = "btn_new_add";
            this.btn_new_add.Size = new System.Drawing.Size(75, 23);
            this.btn_new_add.TabIndex = 5;
            this.btn_new_add.Text = "新增";
            this.btn_new_add.UseVisualStyleBackColor = true;
            this.btn_new_add.Click += new System.EventHandler(this.btn_new_add_Click);
            // 
            // btn_select
            // 
            this.btn_select.Location = new System.Drawing.Point(502, 14);
            this.btn_select.Name = "btn_select";
            this.btn_select.Size = new System.Drawing.Size(75, 23);
            this.btn_select.TabIndex = 2;
            this.btn_select.Text = "参照";
            this.btn_select.UseVisualStyleBackColor = true;
            this.btn_select.Click += new System.EventHandler(this.btn_select_Click);
            // 
            // txt_new_certPath
            // 
            this.txt_new_certPath.Enabled = false;
            this.txt_new_certPath.ImeMode = System.Windows.Forms.ImeMode.Hangul;
            this.txt_new_certPath.Location = new System.Drawing.Point(88, 14);
            this.txt_new_certPath.MaxLength = 50;
            this.txt_new_certPath.Name = "txt_new_certPath";
            this.txt_new_certPath.Size = new System.Drawing.Size(408, 21);
            this.txt_new_certPath.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(88, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 12);
            this.label3.TabIndex = 66;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(17, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 65;
            this.label2.Text = "质检报告：";
            // 
            // txt_MaterialsName
            // 
            this.txt_MaterialsName.Enabled = false;
            this.txt_MaterialsName.ImeMode = System.Windows.Forms.ImeMode.Hangul;
            this.txt_MaterialsName.Location = new System.Drawing.Point(87, 25);
            this.txt_MaterialsName.MaxLength = 50;
            this.txt_MaterialsName.Name = "txt_MaterialsName";
            this.txt_MaterialsName.Size = new System.Drawing.Size(508, 21);
            this.txt_MaterialsName.TabIndex = 1;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.ForeColor = System.Drawing.Color.Black;
            this.label15.Location = new System.Drawing.Point(16, 30);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(65, 12);
            this.label15.TabIndex = 62;
            this.label15.Text = "原料名称：";
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.Font = new System.Drawing.Font("宋体", 20F, System.Drawing.FontStyle.Bold);
            this.lbl_title.ForeColor = System.Drawing.Color.Black;
            this.lbl_title.Location = new System.Drawing.Point(273, 25);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(124, 27);
            this.lbl_title.TabIndex = 24;
            this.lbl_title.Text = "质检报告";
            // 
            // btn_close
            // 
            this.btn_close.Location = new System.Drawing.Point(551, 500);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(75, 23);
            this.btn_close.TabIndex = 6;
            this.btn_close.Text = "返回";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // FrmQC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(692, 546);
            this.Controls.Add(this.grb_customer);
            this.Controls.Add(this.lbl_title);
            this.Controls.Add(this.btn_close);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmQC";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "质检报告";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmQC_FormClosed);
            this.Load += new System.EventHandler(this.FrmQC_Load);
            this.grb_customer.ResumeLayout(false);
            this.grb_customer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.grb_new.ResumeLayout(false);
            this.grb_new.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.GroupBox grb_customer;
        private System.Windows.Forms.TextBox txt_MaterialsName;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.GroupBox grb_new;
        private System.Windows.Forms.Button btn_select;
        private System.Windows.Forms.TextBox txt_new_certPath;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_new_add;
        private System.Windows.Forms.TextBox txt_new_certName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_factoryName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn QCName;
        private System.Windows.Forms.DataGridViewTextBoxColumn remark;
        private System.Windows.Forms.DataGridViewButtonColumn reviewBtn;
        private System.Windows.Forms.DataGridViewButtonColumn deleteBtn;
        private System.Windows.Forms.TextBox txt_remark;
        private System.Windows.Forms.Label label1;
    }
}