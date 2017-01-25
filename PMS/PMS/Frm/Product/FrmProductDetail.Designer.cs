namespace PMS.Frm.Product
{
    partial class FrmProductDetail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmProductDetail));
            this.btn_submit = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.lbl_title = new System.Windows.Forms.Label();
            this.grb_materials = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_minStockNum = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txt_expiredDays = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
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
            this.label27 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.txt_advisePrice = new System.Windows.Forms.TextBox();
            this.label26 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.cmb_priceUnit = new System.Windows.Forms.ComboBox();
            this.txt_minPrice = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label22 = new System.Windows.Forms.Label();
            this.grb_materials.SuspendLayout();
            this.grb_price.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_submit
            // 
            this.btn_submit.Location = new System.Drawing.Point(232, 638);
            this.btn_submit.Name = "btn_submit";
            this.btn_submit.Size = new System.Drawing.Size(75, 23);
            this.btn_submit.TabIndex = 101;
            this.btn_submit.Text = "确认";
            this.btn_submit.UseVisualStyleBackColor = true;
            this.btn_submit.Click += new System.EventHandler(this.btn_submit_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(357, 638);
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
            this.lbl_title.Location = new System.Drawing.Point(214, 41);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(180, 27);
            this.lbl_title.TabIndex = 24;
            this.lbl_title.Text = "商品信息设置";
            // 
            // grb_materials
            // 
            this.grb_materials.Controls.Add(this.label9);
            this.grb_materials.Controls.Add(this.label7);
            this.grb_materials.Controls.Add(this.txt_minStockNum);
            this.grb_materials.Controls.Add(this.label17);
            this.grb_materials.Controls.Add(this.txt_expiredDays);
            this.grb_materials.Controls.Add(this.label16);
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
            this.grb_materials.Location = new System.Drawing.Point(43, 71);
            this.grb_materials.Name = "grb_materials";
            this.grb_materials.Size = new System.Drawing.Size(582, 335);
            this.grb_materials.TabIndex = 103;
            this.grb_materials.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(247, 286);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 12);
            this.label9.TabIndex = 69;
            this.label9.Text = "*（件数）";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(516, 250);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 12);
            this.label7.TabIndex = 68;
            this.label7.Text = "*（天数）";
            // 
            // txt_minStockNum
            // 
            this.txt_minStockNum.ImeMode = System.Windows.Forms.ImeMode.Close;
            this.txt_minStockNum.Location = new System.Drawing.Point(77, 283);
            this.txt_minStockNum.MaxLength = 20;
            this.txt_minStockNum.Name = "txt_minStockNum";
            this.txt_minStockNum.Size = new System.Drawing.Size(164, 21);
            this.txt_minStockNum.TabIndex = 57;
            this.txt_minStockNum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_minStockNum_KeyPress);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.ForeColor = System.Drawing.Color.Red;
            this.label17.Location = new System.Drawing.Point(5, 286);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(65, 12);
            this.label17.TabIndex = 67;
            this.label17.Text = "库存报警：";
            // 
            // txt_expiredDays
            // 
            this.txt_expiredDays.ImeMode = System.Windows.Forms.ImeMode.Close;
            this.txt_expiredDays.Location = new System.Drawing.Point(337, 247);
            this.txt_expiredDays.MaxLength = 20;
            this.txt_expiredDays.Name = "txt_expiredDays";
            this.txt_expiredDays.Size = new System.Drawing.Size(164, 21);
            this.txt_expiredDays.TabIndex = 55;
            this.txt_expiredDays.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_expiredDays_KeyPress);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.ForeColor = System.Drawing.Color.Red;
            this.label16.Location = new System.Drawing.Point(266, 250);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(65, 12);
            this.label16.TabIndex = 66;
            this.label16.Text = "过期报警：";
            // 
            // cmb_weightUnit
            // 
            this.cmb_weightUnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_weightUnit.FormattingEnabled = true;
            this.cmb_weightUnit.Location = new System.Drawing.Point(337, 199);
            this.cmb_weightUnit.Name = "cmb_weightUnit";
            this.cmb_weightUnit.Size = new System.Drawing.Size(163, 20);
            this.cmb_weightUnit.TabIndex = 53;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.Color.Red;
            this.label12.Location = new System.Drawing.Point(265, 202);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(65, 12);
            this.label12.TabIndex = 64;
            this.label12.Text = "重量单位：";
            // 
            // txt_packingRemark
            // 
            this.txt_packingRemark.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.txt_packingRemark.Location = new System.Drawing.Point(336, 110);
            this.txt_packingRemark.MaxLength = 20;
            this.txt_packingRemark.Name = "txt_packingRemark";
            this.txt_packingRemark.Size = new System.Drawing.Size(164, 21);
            this.txt_packingRemark.TabIndex = 48;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(265, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 63;
            this.label3.Text = "包装说明：";
            // 
            // txt_subName
            // 
            this.txt_subName.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.txt_subName.Location = new System.Drawing.Point(336, 15);
            this.txt_subName.MaxLength = 20;
            this.txt_subName.Name = "txt_subName";
            this.txt_subName.Size = new System.Drawing.Size(164, 21);
            this.txt_subName.TabIndex = 45;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(265, 18);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(65, 12);
            this.label15.TabIndex = 62;
            this.label15.Text = "商品略名：";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(247, 66);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(129, 12);
            this.label11.TabIndex = 60;
            this.label11.Text = "*（推荐拼英首字母）";
            // 
            // txt_shelfLife
            // 
            this.txt_shelfLife.ImeMode = System.Windows.Forms.ImeMode.Close;
            this.txt_shelfLife.Location = new System.Drawing.Point(76, 247);
            this.txt_shelfLife.MaxLength = 20;
            this.txt_shelfLife.Name = "txt_shelfLife";
            this.txt_shelfLife.Size = new System.Drawing.Size(164, 21);
            this.txt_shelfLife.TabIndex = 54;
            this.txt_shelfLife.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_shelfLife_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(5, 250);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 12);
            this.label8.TabIndex = 58;
            this.label8.Text = "保 质 期：";
            // 
            // cmb_packingType
            // 
            this.cmb_packingType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_packingType.FormattingEnabled = true;
            this.cmb_packingType.Location = new System.Drawing.Point(76, 110);
            this.cmb_packingType.Name = "cmb_packingType";
            this.cmb_packingType.Size = new System.Drawing.Size(163, 20);
            this.cmb_packingType.TabIndex = 47;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(5, 113);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 12);
            this.label6.TabIndex = 56;
            this.label6.Text = "包装类型：";
            // 
            // txt_weight
            // 
            this.txt_weight.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.txt_weight.Location = new System.Drawing.Point(76, 199);
            this.txt_weight.MaxLength = 20;
            this.txt_weight.Name = "txt_weight";
            this.txt_weight.Size = new System.Drawing.Size(164, 21);
            this.txt_weight.TabIndex = 51;
            this.txt_weight.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_weight_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(5, 202);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 12);
            this.label5.TabIndex = 52;
            this.label5.Text = "重    量：";
            // 
            // cmb_morphology
            // 
            this.cmb_morphology.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_morphology.FormattingEnabled = true;
            this.cmb_morphology.Location = new System.Drawing.Point(77, 154);
            this.cmb_morphology.Name = "cmb_morphology";
            this.cmb_morphology.Size = new System.Drawing.Size(163, 20);
            this.cmb_morphology.TabIndex = 50;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(5, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 49;
            this.label4.Text = "产品形态：";
            // 
            // txt_searchKey
            // 
            this.txt_searchKey.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.txt_searchKey.Location = new System.Drawing.Point(76, 63);
            this.txt_searchKey.MaxLength = 20;
            this.txt_searchKey.Name = "txt_searchKey";
            this.txt_searchKey.Size = new System.Drawing.Size(164, 21);
            this.txt_searchKey.TabIndex = 46;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(5, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 44;
            this.label2.Text = "检 索 键：";
            // 
            // txt_name
            // 
            this.txt_name.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.txt_name.Location = new System.Drawing.Point(76, 15);
            this.txt_name.MaxLength = 20;
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(164, 21);
            this.txt_name.TabIndex = 43;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(5, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 42;
            this.label1.Text = "商 品 名：";
            // 
            // grb_price
            // 
            this.grb_price.Controls.Add(this.label27);
            this.grb_price.Controls.Add(this.label25);
            this.grb_price.Controls.Add(this.txt_advisePrice);
            this.grb_price.Controls.Add(this.label26);
            this.grb_price.Controls.Add(this.label23);
            this.grb_price.Controls.Add(this.cmb_priceUnit);
            this.grb_price.Controls.Add(this.txt_minPrice);
            this.grb_price.Controls.Add(this.label21);
            this.grb_price.ForeColor = System.Drawing.Color.Red;
            this.grb_price.Location = new System.Drawing.Point(43, 568);
            this.grb_price.Name = "grb_price";
            this.grb_price.Size = new System.Drawing.Size(580, 52);
            this.grb_price.TabIndex = 104;
            this.grb_price.TabStop = false;
            this.grb_price.Text = "价格";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(428, 21);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(41, 12);
            this.label27.TabIndex = 78;
            this.label27.Text = "单位：";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label25.ForeColor = System.Drawing.Color.Black;
            this.label25.Location = new System.Drawing.Point(390, 21);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(18, 12);
            this.label25.TabIndex = 77;
            this.label25.Text = "元";
            // 
            // txt_advisePrice
            // 
            this.txt_advisePrice.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.txt_advisePrice.Location = new System.Drawing.Point(291, 18);
            this.txt_advisePrice.MaxLength = 20;
            this.txt_advisePrice.Name = "txt_advisePrice";
            this.txt_advisePrice.Size = new System.Drawing.Size(98, 21);
            this.txt_advisePrice.TabIndex = 76;
            this.txt_advisePrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_advisePrice_KeyPress);
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(222, 21);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(65, 12);
            this.label26.TabIndex = 75;
            this.label26.Text = "最低价格：";
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
            this.cmb_priceUnit.Location = new System.Drawing.Point(469, 18);
            this.cmb_priceUnit.Name = "cmb_priceUnit";
            this.cmb_priceUnit.Size = new System.Drawing.Size(49, 20);
            this.cmb_priceUnit.TabIndex = 65;
            // 
            // txt_minPrice
            // 
            this.txt_minPrice.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.txt_minPrice.Location = new System.Drawing.Point(75, 18);
            this.txt_minPrice.MaxLength = 20;
            this.txt_minPrice.Name = "txt_minPrice";
            this.txt_minPrice.Size = new System.Drawing.Size(98, 21);
            this.txt_minPrice.TabIndex = 60;
            this.txt_minPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_minPrice_KeyPress);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(6, 21);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(65, 12);
            this.label21.TabIndex = 47;
            this.label21.Text = "最低价格：";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(667, 24);
            this.menuStrip1.TabIndex = 105;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(43, 435);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 35;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(582, 127);
            this.dataGridView1.TabIndex = 106;
            this.dataGridView1.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellValueChanged);
            this.dataGridView1.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dataGridView1_EditingControlShowing);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("宋体", 9F);
            this.label22.ForeColor = System.Drawing.Color.Black;
            this.label22.Location = new System.Drawing.Point(46, 417);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(53, 12);
            this.label22.TabIndex = 107;
            this.label22.Text = "商品构成";
            // 
            // FrmProductDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(667, 670);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.grb_price);
            this.Controls.Add(this.grb_materials);
            this.Controls.Add(this.lbl_title);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_submit);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmProductDetail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "原料管理";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmProductDetail_FormClosed);
            this.Load += new System.EventHandler(this.FrmProductDetail_Load);
            this.grb_materials.ResumeLayout(false);
            this.grb_materials.PerformLayout();
            this.grb_price.ResumeLayout(false);
            this.grb_price.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_submit;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.GroupBox grb_materials;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_minStockNum;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txt_expiredDays;
        private System.Windows.Forms.Label label16;
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
        private System.Windows.Forms.TextBox txt_minPrice;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.TextBox txt_advisePrice;
        private System.Windows.Forms.Label label26;
    }
}