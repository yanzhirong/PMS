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
    public partial class FrmMaterialsInQCPic : Main.BaseForm
    {
        private int m_QCId;

        private BllMaterialsIn m_bllMaterialsIn = new BllMaterialsIn();

        public FrmMaterialsInQCPic(int _QCId)
        {
            InitializeComponent();
            m_QCId = _QCId;
        }

        private void FrmQCPic_Load(object sender, EventArgs e)
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

            //初始化
            if (m_QCId > 0)
            {


                this.pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;

                ModelMaterialsInQC model = m_bllMaterialsIn.GetQCById(m_QCId);
                MemoryStream ms = new MemoryStream(model.QCImage);
                this.pictureBox1.Image = new Bitmap(ms);
            }

        }
        #endregion

        private void FrmQCPic_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            this.saveFileDialog1.Filter = "*jpg|*.JPG|*jpeg|*.JPEG|*.GIF|*.GIF|*.BMP|*.BMP|*.PNG|*.PNG";

            if (this.saveFileDialog1.ShowDialog() == DialogResult.OK)
            {

                try
                {
                    Bitmap bmp = new Bitmap(this.pictureBox1.Image);
                    bmp.Save(this.saveFileDialog1.FileName);
                }
                catch (Exception ex)
                {
                    MsgUtils.ShowErrorMsg("保存文件失败！");
                }
                finally
                {
                }

            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(this.pictureBox1.Image, 10, 10);
        }

        private void btn_print_Click(object sender, EventArgs e)
        {
            PrintDialog MyPrintDg = new PrintDialog();
            MyPrintDg.Document = printDocument1;
            if (MyPrintDg.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    printDocument1.Print();
                }
                catch
                {   //停止打印
                    printDocument1.PrintController.OnEndPrint(printDocument1, new System.Drawing.Printing.PrintEventArgs());
                }
            }
        }
 
    }
}
