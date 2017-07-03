using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model;
using Bll;
using Common.Tools;
using System.IO;

namespace PMS.Frm.Store
{
    public partial class FrmMaterialsInQC : Main.BaseForm
    {
        private string m_inputCode;
        private int m_materialsId;
        private int m_specsId;
        private int m_factoryId;
        private int m_mode;

        private BllMaterialsIn m_bllMaterialsIn = new BllMaterialsIn();
        private BllMaterials m_bllMaterials = new BllMaterials();
        private BllFactory m_bllFactory = new BllFactory();

        public FrmMaterialsInQC(int _model,string _inputCode)
        {
            InitializeComponent();
            m_mode = _model;
            m_inputCode = _inputCode;
        }

        private void FrmQC_Load(object sender, EventArgs e)
        {
            
            //初始化
            init();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        #region 初始化
        /// <summary>
        /// 画面初始化
        /// </summary>
        private void init()
        {

            ModelMaterialsIn model = m_bllMaterialsIn.GetMaterialsInByInputCode(m_inputCode);
            this.m_materialsId = model.materialsId;
            this.m_specsId = model.specsId;
            this.m_factoryId = model.factoryId;

            this.txt_MaterialsName.Text = m_bllMaterials.GetMaterialsById(m_materialsId).name;

            this.txt_factoryName.Text = m_bllFactory.GetFactoryById(m_factoryId).name;

            this.dataGridView1.DataSource = m_bllMaterialsIn.GetMaterialsInQCByInputCode(this.m_inputCode);
            this.dataGridView1.Refresh();

            this.txt_new_certName.Text = "";
            this.txt_new_certPath.Text = "";

            if(m_mode == 3)
            {
                //this.grb_new.Enabled = false;
                this.dataGridView1.Columns["deleteBtn"].Visible = false;
                
            }
        }
        #endregion

        private void FrmQC_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
        }

        private void btn_new_add_Click(object sender, EventArgs e)
        {
            if (StringUtils.IsBlank(this.txt_new_certName.Text))
            {
                MsgUtils.ShowErrorMsg("请输入凭证名称！");
                this.txt_new_certName.Focus();
                return;
            }

            if (StringUtils.IsBlank(this.txt_new_certPath.Text))
            {
                MsgUtils.ShowErrorMsg("请选择凭证图片！");
                this.txt_new_certPath.Focus();
                return;
            }

            ModelMaterialsInQC model = new ModelMaterialsInQC();
            model.materialsId = m_materialsId;
            model.specsId = m_specsId;
            model.factoryId = m_factoryId;
            model.inputCode = m_inputCode;
            model.QCName = this.txt_new_certName.Text.Trim();
            model.remark = this.txt_remark.Text.Trim();

            FileStream fs = new FileStream(this.txt_new_certPath.Text, FileMode.Open);
            byte[] imageBytes = new byte[fs.Length];
            BinaryReader br = new BinaryReader(fs);
            model.QCImage = br.ReadBytes(Convert.ToInt32(fs.Length));
            model.isDelete = 0;
            model.createBy = LoginUserInfo.LoginUser.loginUser.userName;
            model.createTime = DateTime.Now;

            if (m_bllMaterialsIn.AddMaterialsInQC(model))
            {
                init();
                MsgUtils.ShowInfoMsg("新增质检报告成功！");
            }
            else
            {
                MsgUtils.ShowErrorMsg("新增质检报告失败！");
            }

            return;
        }

        private void btn_select_Click(object sender, EventArgs e)
        {
            this.openFileDialog1.Filter = "*jpg|*.JPG|*jpeg|*.JPEG|*.GIF|*.GIF|*.BMP|*.BMP|*.PNG|*.PNG";

            if (this.openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                this.txt_new_certPath.Text = this.openFileDialog1.FileName;

            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //查看
            if (dataGridView1.Columns[e.ColumnIndex].Name == "reviewBtn")
            {
                int id = (int)dataGridView1.Rows[e.RowIndex].Cells["id"].Value;
                Form form = new FrmMaterialsInQCPic(id);
                form.ShowDialog();
            }

            //删除
            if (dataGridView1.Columns[e.ColumnIndex].Name == "deleteBtn")
            {
                int id = (int)dataGridView1.Rows[e.RowIndex].Cells["id"].Value;

                if (id > 0)
                {
                    if(MsgUtils.ShowQustMsg("确认删除此质检报告么？", MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                    {
                        ModelMaterialsInQC model = new ModelMaterialsInQC();
                        model.inputCode = m_inputCode;
                        model.id = id;
                        model.modifyBy = LoginUserInfo.LoginUser.loginUser.userName;
                        model.modifyTime = DateTime.Now;
                        if (m_bllMaterialsIn.DeleteMaterialsInQC(model))
                        {
                            init();
                            MsgUtils.ShowInfoMsg("删除质检报告成功！");
                        }
                        else
                        {
                            MsgUtils.ShowErrorMsg("删除质检报告失败！");
                        }
                    }
                }

            }
        }
    }
}
