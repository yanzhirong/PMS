﻿namespace PMS.Frm.Product
{
    partial class FrmMaterialsManage
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMaterialsManage));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_addNew = new System.Windows.Forms.Button();
            this.btn_query = new System.Windows.Forms.Button();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.packingType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.weight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.morphology = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shelfLife = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modifyBtn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.deleteBtn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.lbl_tile = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_addNew);
            this.groupBox1.Controls.Add(this.btn_query);
            this.groupBox1.Controls.Add(this.txt_name);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(30, 79);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(885, 95);
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
            this.label1.Text = "原料名：";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.name,
            this.subName,
            this.packingType,
            this.weight,
            this.morphology,
            this.shelfLife,
            this.modifyBtn,
            this.deleteBtn});
            this.dataGridView1.Location = new System.Drawing.Point(30, 188);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 35;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(885, 400);
            this.dataGridView1.TabIndex = 8;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.Visible = false;
            // 
            // name
            // 
            this.name.DataPropertyName = "name";
            this.name.HeaderText = "原料名";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            this.name.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // subName
            // 
            this.subName.DataPropertyName = "subName";
            this.subName.HeaderText = "原料略称";
            this.subName.Name = "subName";
            this.subName.ReadOnly = true;
            // 
            // packingType
            // 
            this.packingType.DataPropertyName = "packingType";
            this.packingType.HeaderText = "包装方式";
            this.packingType.Name = "packingType";
            this.packingType.ReadOnly = true;
            // 
            // weight
            // 
            this.weight.DataPropertyName = "weight";
            this.weight.HeaderText = "重量";
            this.weight.Name = "weight";
            this.weight.ReadOnly = true;
            // 
            // morphology
            // 
            this.morphology.DataPropertyName = "morphology";
            this.morphology.HeaderText = "产品形态";
            this.morphology.Name = "morphology";
            this.morphology.ReadOnly = true;
            this.morphology.Width = 120;
            // 
            // shelfLife
            // 
            this.shelfLife.DataPropertyName = "shelfLife";
            this.shelfLife.HeaderText = "保质期";
            this.shelfLife.Name = "shelfLife";
            this.shelfLife.ReadOnly = true;
            this.shelfLife.Width = 120;
            // 
            // modifyBtn
            // 
            this.modifyBtn.DataPropertyName = "modifyBtn";
            this.modifyBtn.HeaderText = "修改";
            this.modifyBtn.Name = "modifyBtn";
            // 
            // deleteBtn
            // 
            this.deleteBtn.DataPropertyName = "deleteBtn";
            this.deleteBtn.HeaderText = "删除";
            this.deleteBtn.Name = "deleteBtn";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(944, 24);
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
            this.lbl_tile.Text = "原料列表";
            // 
            // FrmMaterialsManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 611);
            this.Controls.Add(this.lbl_tile);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmMaterialsManage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "原料管理";
            this.Load += new System.EventHandler(this.FrmMaterialsManage_Load);
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
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn subName;
        private System.Windows.Forms.DataGridViewTextBoxColumn packingType;
        private System.Windows.Forms.DataGridViewTextBoxColumn weight;
        private System.Windows.Forms.DataGridViewTextBoxColumn morphology;
        private System.Windows.Forms.DataGridViewTextBoxColumn shelfLife;
        private System.Windows.Forms.DataGridViewButtonColumn modifyBtn;
        private System.Windows.Forms.DataGridViewButtonColumn deleteBtn;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Label lbl_tile;

    }
}