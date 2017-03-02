﻿namespace PMS.Frm.Product
{
    partial class FrmMaterialsDetail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMaterialsDetail));
            this.btn_submit = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.lbl_title = new System.Windows.Forms.Label();
            this.grb_materials = new System.Windows.Forms.GroupBox();
            this.cmb_materialsType = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_minStockNum = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txt_expiredDays = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.cmb_weightUnit = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txt_packingRemark = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_subName = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_shelfLife = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cmb_packingType = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_weight = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmb_morphology = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_searchKey = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grb_price = new System.Windows.Forms.GroupBox();
            this.label23 = new System.Windows.Forms.Label();
            this.cmb_priceUnit = new System.Windows.Forms.ComboBox();
            this.txt_price = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.grb_materials.SuspendLayout();
            this.grb_price.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_submit
            // 
            this.btn_submit.Location = new System.Drawing.Point(209, 535);
            this.btn_submit.Name = "btn_submit";
            this.btn_submit.Size = new System.Drawing.Size(75, 23);
            this.btn_submit.TabIndex = 101;
            this.btn_submit.Text = "确认";
            this.btn_submit.UseVisualStyleBackColor = true;
            this.btn_submit.Click += new System.EventHandler(this.btn_submit_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(389, 535);
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
            this.lbl_title.Location = new System.Drawing.Point(269, 32);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(124, 27);
            this.lbl_title.TabIndex = 24;
            this.lbl_title.Text = "物料信息";
            // 
            // grb_materials
            // 
            this.grb_materials.Controls.Add(this.cmb_materialsType);
            this.grb_materials.Controls.Add(this.label7);
            this.grb_materials.Controls.Add(this.label9);
            this.grb_materials.Controls.Add(this.txt_minStockNum);
            this.grb_materials.Controls.Add(this.label17);
            this.grb_materials.Controls.Add(this.txt_expiredDays);
            this.grb_materials.Controls.Add(this.label16);
            this.grb_materials.Controls.Add(this.label14);
            this.grb_materials.Controls.Add(this.cmb_weightUnit);
            this.grb_materials.Controls.Add(this.label12);
            this.grb_materials.Controls.Add(this.txt_packingRemark);
            this.grb_materials.Controls.Add(this.label3);
            this.grb_materials.Controls.Add(this.txt_subName);
            this.grb_materials.Controls.Add(this.label15);
            this.grb_materials.Controls.Add(this.label11);
            this.grb_materials.Controls.Add(this.txt_shelfLife);
            this.grb_materials.Controls.Add(this.label8);
            this.grb_materials.Controls.Add(this.cmb_packingType);
            this.grb_materials.Controls.Add(this.label6);
            this.grb_materials.Controls.Add(this.txt_weight);
            this.grb_materials.Controls.Add(this.label5);
            this.grb_materials.Controls.Add(this.cmb_morphology);
            this.grb_materials.Controls.Add(this.label4);
            this.grb_materials.Controls.Add(this.txt_searchKey);
            this.grb_materials.Controls.Add(this.label2);
            this.grb_materials.Controls.Add(this.txt_name);
            this.grb_materials.Controls.Add(this.label1);
            this.grb_materials.Location = new System.Drawing.Point(45, 73);
            this.grb_materials.Name = "grb_materials";
            this.grb_materials.Size = new System.Drawing.Size(585, 366);
            this.grb_materials.TabIndex = 103;
            this.grb_materials.TabStop = false;
            // 
            // cmb_materialsType
            // 
            this.cmb_materialsType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_materialsType.FormattingEnabled = true;
            this.cmb_materialsType.Items.AddRange(new object[] {
            "一般物料",
            "自制物料",
            "其它"});
            this.cmb_materialsType.Location = new System.Drawing.Point(344, 174);
            this.cmb_materialsType.Name = "cmb_materialsType";
            this.cmb_materialsType.Size = new System.Drawing.Size(163, 20);
            this.cmb_materialsType.TabIndex = 7;
            this.cmb_materialsType.SelectedIndexChanged += new System.EventHandler(this.cmb_materialsType_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(272, 177);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 12);
            this.label7.TabIndex = 70;
            this.label7.Text = "物料类型：";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(273, 272);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 12);
            this.label9.TabIndex = 69;
            this.label9.Text = "*（件数）";
            // 
            // txt_minStockNum
            // 
            this.txt_minStockNum.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.txt_minStockNum.Location = new System.Drawing.Point(75, 269);
            this.txt_minStockNum.MaxLength = 3;
            this.txt_minStockNum.Name = "txt_minStockNum";
            this.txt_minStockNum.Size = new System.Drawing.Size(164, 21);
            this.txt_minStockNum.TabIndex = 10;
            this.txt_minStockNum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_minStockNum_KeyPress);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.ForeColor = System.Drawing.Color.Red;
            this.label17.Location = new System.Drawing.Point(5, 272);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(65, 12);
            this.label17.TabIndex = 67;
            this.label17.Text = "库存报警：";
            // 
            // txt_expiredDays
            // 
            this.txt_expiredDays.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.txt_expiredDays.Location = new System.Drawing.Point(345, 218);
            this.txt_expiredDays.MaxLength = 3;
            this.txt_expiredDays.Name = "txt_expiredDays";
            this.txt_expiredDays.Size = new System.Drawing.Size(164, 21);
            this.txt_expiredDays.TabIndex = 9;
            this.txt_expiredDays.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_expiredDays_KeyPress);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.ForeColor = System.Drawing.Color.Red;
            this.label16.Location = new System.Drawing.Point(273, 221);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(65, 12);
            this.label16.TabIndex = 66;
            this.label16.Text = "过期报警：";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label14.ForeColor = System.Drawing.Color.Black;
            this.label14.Location = new System.Drawing.Point(513, 221);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(64, 12);
            this.label14.TabIndex = 65;
            this.label14.Text = "*（天数）";
            // 
            // cmb_weightUnit
            // 
            this.cmb_weightUnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_weightUnit.FormattingEnabled = true;
            this.cmb_weightUnit.Location = new System.Drawing.Point(345, 315);
            this.cmb_weightUnit.Name = "cmb_weightUnit";
            this.cmb_weightUnit.Size = new System.Drawing.Size(163, 20);
            this.cmb_weightUnit.TabIndex = 12;
            this.cmb_weightUnit.Visible = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(273, 318);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(65, 12);
            this.label12.TabIndex = 64;
            this.label12.Text = "重量单位：";
            this.label12.Visible = false;
            // 
            // txt_packingRemark
            // 
            this.txt_packingRemark.ImeMode = System.Windows.Forms.ImeMode.Hangul;
            this.txt_packingRemark.Location = new System.Drawing.Point(344, 130);
            this.txt_packingRemark.MaxLength = 50;
            this.txt_packingRemark.Name = "txt_packingRemark";
            this.txt_packingRemark.Size = new System.Drawing.Size(164, 21);
            this.txt_packingRemark.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(273, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 63;
            this.label3.Text = "包装说明：";
            // 
            // txt_subName
            // 
            this.txt_subName.ImeMode = System.Windows.Forms.ImeMode.Hangul;
            this.txt_subName.Location = new System.Drawing.Point(344, 35);
            this.txt_subName.MaxLength = 50;
            this.txt_subName.Name = "txt_subName";
            this.txt_subName.Size = new System.Drawing.Size(164, 21);
            this.txt_subName.TabIndex = 2;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(273, 38);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(65, 12);
            this.label15.TabIndex = 62;
            this.label15.Text = "材料略名：";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(274, 86);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(129, 12);
            this.label11.TabIndex = 60;
            this.label11.Text = "*（推荐拼英首字母）";
            // 
            // txt_shelfLife
            // 
            this.txt_shelfLife.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.txt_shelfLife.Location = new System.Drawing.Point(76, 221);
            this.txt_shelfLife.MaxLength = 4;
            this.txt_shelfLife.Name = "txt_shelfLife";
            this.txt_shelfLife.Size = new System.Drawing.Size(164, 21);
            this.txt_shelfLife.TabIndex = 8;
            this.txt_shelfLife.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_shelfLife_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(5, 224);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 12);
            this.label8.TabIndex = 58;
            this.label8.Text = "保 质 期：";
            // 
            // cmb_packingType
            // 
            this.cmb_packingType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_packingType.FormattingEnabled = true;
            this.cmb_packingType.Location = new System.Drawing.Point(76, 130);
            this.cmb_packingType.Name = "cmb_packingType";
            this.cmb_packingType.Size = new System.Drawing.Size(163, 20);
            this.cmb_packingType.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(5, 133);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 12);
            this.label6.TabIndex = 56;
            this.label6.Text = "包装类型：";
            // 
            // txt_weight
            // 
            this.txt_weight.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.txt_weight.Location = new System.Drawing.Point(76, 315);
            this.txt_weight.MaxLength = 12;
            this.txt_weight.Name = "txt_weight";
            this.txt_weight.Size = new System.Drawing.Size(164, 21);
            this.txt_weight.TabIndex = 11;
            this.txt_weight.Visible = false;
            this.txt_weight.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_weight_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(5, 318);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 12);
            this.label5.TabIndex = 52;
            this.label5.Text = "重    量：";
            this.label5.Visible = false;
            // 
            // cmb_morphology
            // 
            this.cmb_morphology.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_morphology.FormattingEnabled = true;
            this.cmb_morphology.Location = new System.Drawing.Point(77, 174);
            this.cmb_morphology.Name = "cmb_morphology";
            this.cmb_morphology.Size = new System.Drawing.Size(163, 20);
            this.cmb_morphology.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(5, 177);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 49;
            this.label4.Text = "产品形态：";
            // 
            // txt_searchKey
            // 
            this.txt_searchKey.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.txt_searchKey.Location = new System.Drawing.Point(76, 83);
            this.txt_searchKey.MaxLength = 20;
            this.txt_searchKey.Name = "txt_searchKey";
            this.txt_searchKey.Size = new System.Drawing.Size(164, 21);
            this.txt_searchKey.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(5, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 44;
            this.label2.Text = "检 索 键：";
            // 
            // txt_name
            // 
            this.txt_name.ImeMode = System.Windows.Forms.ImeMode.Hangul;
            this.txt_name.Location = new System.Drawing.Point(76, 35);
            this.txt_name.MaxLength = 50;
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(164, 21);
            this.txt_name.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(5, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 42;
            this.label1.Text = "物 料 名：";
            // 
            // grb_price
            // 
            this.grb_price.Controls.Add(this.label23);
            this.grb_price.Controls.Add(this.cmb_priceUnit);
            this.grb_price.Controls.Add(this.txt_price);
            this.grb_price.Controls.Add(this.label21);
            this.grb_price.ForeColor = System.Drawing.Color.Red;
            this.grb_price.Location = new System.Drawing.Point(45, 458);
            this.grb_price.Name = "grb_price";
            this.grb_price.Size = new System.Drawing.Size(585, 52);
            this.grb_price.TabIndex = 104;
            this.grb_price.TabStop = false;
            this.grb_price.Text = "价格";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label23.ForeColor = System.Drawing.Color.Black;
            this.label23.Location = new System.Drawing.Point(174, 21);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(18, 12);
            this.label23.TabIndex = 73;
            this.label23.Text = "元";
            // 
            // cmb_priceUnit
            // 
            this.cmb_priceUnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_priceUnit.FormattingEnabled = true;
            this.cmb_priceUnit.Location = new System.Drawing.Point(200, 18);
            this.cmb_priceUnit.Name = "cmb_priceUnit";
            this.cmb_priceUnit.Size = new System.Drawing.Size(49, 20);
            this.cmb_priceUnit.TabIndex = 14;
            // 
            // txt_price
            // 
            this.txt_price.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.txt_price.Location = new System.Drawing.Point(75, 18);
            this.txt_price.MaxLength = 12;
            this.txt_price.Name = "txt_price";
            this.txt_price.Size = new System.Drawing.Size(98, 21);
            this.txt_price.TabIndex = 13;
            this.txt_price.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_price_KeyPress);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(6, 21);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(65, 12);
            this.label21.TabIndex = 47;
            this.label21.Text = "价    格：";
            // 
            // FrmMaterialsDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(668, 586);
            this.Controls.Add(this.grb_price);
            this.Controls.Add(this.grb_materials);
            this.Controls.Add(this.lbl_title);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_submit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmMaterialsDetail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "物料管理";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmMaterialsDetail_FormClosed);
            this.Load += new System.EventHandler(this.FrmMaterialsDetail_Load);
            this.grb_materials.ResumeLayout(false);
            this.grb_materials.PerformLayout();
            this.grb_price.ResumeLayout(false);
            this.grb_price.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_submit;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.GroupBox grb_materials;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_minStockNum;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txt_expiredDays;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox cmb_weightUnit;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txt_packingRemark;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_subName;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txt_shelfLife;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmb_packingType;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_weight;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmb_morphology;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_searchKey;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grb_price;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.ComboBox cmb_priceUnit;
        private System.Windows.Forms.TextBox txt_price;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.ComboBox cmb_materialsType;
        private System.Windows.Forms.Label label7;
    }
}