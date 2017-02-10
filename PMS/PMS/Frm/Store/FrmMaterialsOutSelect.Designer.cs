namespace PMS.Frm.Store
{
    partial class FrmMaterialsOutSelect
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMaterialsOutSelect));
            this.btn_submit = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.lbl_title = new System.Windows.Forms.Label();
            this.grb_productOut = new System.Windows.Forms.GroupBox();
            this.txt_unitCode = new System.Windows.Forms.TextBox();
            this.btn_select = new System.Windows.Forms.Button();
            this.txt_unit = new System.Windows.Forms.TextBox();
            this.txt_factory = new System.Windows.Forms.TextBox();
            this.txt_num = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_product = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txt_outputCode = new System.Windows.Forms.TextBox();
            this.lbl_orderCode = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.grb_productOut.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_submit
            // 
            this.btn_submit.Location = new System.Drawing.Point(223, 577);
            this.btn_submit.Name = "btn_submit";
            this.btn_submit.Size = new System.Drawing.Size(75, 23);
            this.btn_submit.TabIndex = 101;
            this.btn_submit.Text = "确认";
            this.btn_submit.UseVisualStyleBackColor = true;
            this.btn_submit.Click += new System.EventHandler(this.btn_submit_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(416, 577);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_cancel.TabIndex = 102;
            this.btn_cancel.Text = "取消";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.Font = new System.Drawing.Font("宋体", 20F, System.Drawing.FontStyle.Bold);
            this.lbl_title.ForeColor = System.Drawing.Color.Black;
            this.lbl_title.Location = new System.Drawing.Point(279, 27);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(124, 27);
            this.lbl_title.TabIndex = 24;
            this.lbl_title.Text = "物料出库";
            // 
            // grb_productOut
            // 
            this.grb_productOut.Controls.Add(this.button1);
            this.grb_productOut.Controls.Add(this.txt_unitCode);
            this.grb_productOut.Controls.Add(this.btn_select);
            this.grb_productOut.Controls.Add(this.txt_unit);
            this.grb_productOut.Controls.Add(this.txt_factory);
            this.grb_productOut.Controls.Add(this.txt_num);
            this.grb_productOut.Controls.Add(this.label3);
            this.grb_productOut.Controls.Add(this.txt_product);
            this.grb_productOut.Controls.Add(this.label2);
            this.grb_productOut.Controls.Add(this.label1);
            this.grb_productOut.Controls.Add(this.dataGridView1);
            this.grb_productOut.Controls.Add(this.txt_outputCode);
            this.grb_productOut.Controls.Add(this.lbl_orderCode);
            this.grb_productOut.Location = new System.Drawing.Point(33, 66);
            this.grb_productOut.Name = "grb_productOut";
            this.grb_productOut.Size = new System.Drawing.Size(641, 474);
            this.grb_productOut.TabIndex = 103;
            this.grb_productOut.TabStop = false;
            // 
            // txt_unitCode
            // 
            this.txt_unitCode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txt_unitCode.Enabled = false;
            this.txt_unitCode.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.txt_unitCode.Location = new System.Drawing.Point(99, 101);
            this.txt_unitCode.MaxLength = 20;
            this.txt_unitCode.Name = "txt_unitCode";
            this.txt_unitCode.Size = new System.Drawing.Size(37, 21);
            this.txt_unitCode.TabIndex = 129;
            this.txt_unitCode.Visible = false;
            // 
            // btn_select
            // 
            this.btn_select.Location = new System.Drawing.Point(18, 99);
            this.btn_select.Name = "btn_select";
            this.btn_select.Size = new System.Drawing.Size(75, 23);
            this.btn_select.TabIndex = 128;
            this.btn_select.Text = "刷新库存";
            this.btn_select.UseVisualStyleBackColor = true;
            this.btn_select.Click += new System.EventHandler(this.btn_select_Click);
            // 
            // txt_unit
            // 
            this.txt_unit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txt_unit.Enabled = false;
            this.txt_unit.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.txt_unit.Location = new System.Drawing.Point(565, 62);
            this.txt_unit.MaxLength = 20;
            this.txt_unit.Name = "txt_unit";
            this.txt_unit.Size = new System.Drawing.Size(37, 21);
            this.txt_unit.TabIndex = 127;
            // 
            // txt_factory
            // 
            this.txt_factory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txt_factory.Enabled = false;
            this.txt_factory.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.txt_factory.Location = new System.Drawing.Point(380, 24);
            this.txt_factory.MaxLength = 20;
            this.txt_factory.Name = "txt_factory";
            this.txt_factory.Size = new System.Drawing.Size(222, 21);
            this.txt_factory.TabIndex = 126;
            // 
            // txt_num
            // 
            this.txt_num.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txt_num.Enabled = false;
            this.txt_num.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.txt_num.Location = new System.Drawing.Point(380, 62);
            this.txt_num.MaxLength = 20;
            this.txt_num.Name = "txt_num";
            this.txt_num.Size = new System.Drawing.Size(179, 21);
            this.txt_num.TabIndex = 125;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(319, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 124;
            this.label3.Text = "出库数量：";
            // 
            // txt_product
            // 
            this.txt_product.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txt_product.Enabled = false;
            this.txt_product.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.txt_product.Location = new System.Drawing.Point(77, 62);
            this.txt_product.MaxLength = 20;
            this.txt_product.Name = "txt_product";
            this.txt_product.Size = new System.Drawing.Size(222, 21);
            this.txt_product.TabIndex = 123;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(16, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 122;
            this.label2.Text = "出库物料：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(319, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 121;
            this.label1.Text = "工    厂：";
            this.label1.Visible = false;
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
            this.dataGridView1.Location = new System.Drawing.Point(18, 144);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 20;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(600, 311);
            this.dataGridView1.TabIndex = 9;
            this.dataGridView1.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellValueChanged);
            this.dataGridView1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dataGridView1_KeyPress);
            // 
            // txt_outputCode
            // 
            this.txt_outputCode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txt_outputCode.Enabled = false;
            this.txt_outputCode.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.txt_outputCode.Location = new System.Drawing.Point(77, 24);
            this.txt_outputCode.MaxLength = 20;
            this.txt_outputCode.Name = "txt_outputCode";
            this.txt_outputCode.Size = new System.Drawing.Size(222, 21);
            this.txt_outputCode.TabIndex = 43;
            // 
            // lbl_orderCode
            // 
            this.lbl_orderCode.AutoSize = true;
            this.lbl_orderCode.ForeColor = System.Drawing.Color.Black;
            this.lbl_orderCode.Location = new System.Drawing.Point(16, 27);
            this.lbl_orderCode.Name = "lbl_orderCode";
            this.lbl_orderCode.Size = new System.Drawing.Size(65, 12);
            this.lbl_orderCode.TabIndex = 42;
            this.lbl_orderCode.Text = "出库单号：";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(527, 99);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 132;
            this.button1.Text = "申请购买";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // FrmMaterialsOutSelect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(711, 632);
            this.Controls.Add(this.grb_productOut);
            this.Controls.Add(this.lbl_title);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_submit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmMaterialsOutSelect";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "物料出库管理";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmMaterialsOutSelect_FormClosed);
            this.Load += new System.EventHandler(this.FrmMaterialsOutSelect_Load);
            this.grb_productOut.ResumeLayout(false);
            this.grb_productOut.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_submit;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.GroupBox grb_productOut;
        private System.Windows.Forms.TextBox txt_outputCode;
        private System.Windows.Forms.Label lbl_orderCode;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_unit;
        private System.Windows.Forms.TextBox txt_factory;
        private System.Windows.Forms.TextBox txt_num;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_product;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_select;
        private System.Windows.Forms.TextBox txt_unitCode;
        private System.Windows.Forms.Button button1;
    }
}