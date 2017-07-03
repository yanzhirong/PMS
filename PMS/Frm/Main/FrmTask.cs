using Bll;
using Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Common.Tools;

namespace PMS.Frm.Main
{
    public partial class FrmTask : Main.BaseForm
    {
        private int m_isLogin;

        private BllRole m_bllRole = new BllRole();
        private BllCode m_bllCode = new BllCode();
        private BllLogin m_bllLogin = new BllLogin();

        public FrmTask()
        {
            m_isLogin = 0;
            InitializeComponent();
        }

        public FrmTask(int _isLogin)
        {
            m_isLogin = _isLogin;
            InitializeComponent();
        }

        private void FrmTask_Load(object sender, EventArgs e)
        {

            //显示登录者信息
            this.Text = "生产管理系统 --> " + this.Text + "     (" + LoginUserInfo.LoginUser.loginUser.userName + "/" + LoginUserInfo.LoginUser.loginRole.roleName + ")";

            LoginUserInfo.LoginUser.menuFrom = this;
            WinCommon.CreateMenu(ref this.menuStrip1);

            //角色
            List<ModelItem> listItem = m_bllRole.GetAllRoles();
            WinCommon.BindComboBox(ref this.cmb_role, listItem);

            listItem = m_bllCode.GetCodeItem((int)Enum.EnumCode.TaskType);
            WinCommon.BindComboBox(ref this.cmb_taskType, listItem);

            for (int i = 0; i < this.cmb_role.Items.Count; i++ )
            {
                ModelItem modelItem = (ModelItem)this.cmb_role.Items[i];
                if (LoginUserInfo.LoginUser.loginRole.roleId == (int)modelItem.itemKey)
                {
                    this.cmb_role.SelectedIndex = i;
                    break;
                }
            }

            if (!WinCommon.IsAdmin(LoginUserInfo.LoginUser.loginRole.roleType))
            {
                this.cmb_role.Enabled = false;
            }

            doSelect();

            //if (m_isLogin == 1)
            //{
            //    if (this.dataGridView1.Rows.Count <= 0)
            //    {
            //        this.Hide();
            //        Form form = new Main.FrmMain();
            //        form.ShowDialog();
            //    }

            //}
        }

        private void btn_query_Click(object sender, EventArgs e)
        {
            doSelect();
        }

        private void doSelect()
        {
            if (this.cmb_taskType.Items.Count > 1)
            {
                DataTable dtTask = (DataTable)this.dataGridView1.DataSource;
                if (dtTask != null && dtTask.Rows.Count > 0)
                {
                    dtTask.Rows.Clear();
                }

                List<int> listTaskType = new List<int>();

                if (this.cmb_taskType.SelectedIndex > 0)
                {
                    dtTask = m_bllLogin.GetTask(ConvertUtils.ConvertToInt(((ModelItem)this.cmb_taskType.SelectedItem).itemKey));
                }
                else
                {
                    foreach (ModelItem item in this.cmb_taskType.Items)
                    {
                        int taskType = ConvertUtils.ConvertToInt(item.itemKey);
                        if (taskType > 0)
                        {
                            DataTable dt = m_bllLogin.GetTask(taskType);
                            if (dt != null && dt.Rows.Count > 0)
                            {
                                if (dtTask != null && dtTask.Rows.Count > 0)
                                {
                                    foreach (DataRow dr in dt.Rows)
                                    {
                                        DataRow newDr = dtTask.NewRow();
                                        newDr["taskType"] = dr["taskType"];
                                        newDr["taskName"] = dr["taskName"];
                                        newDr["taskContent"] = dr["taskContent"];
                                        dtTask.Rows.Add(newDr);
                                    }
                                }
                                else
                                {
                                    dtTask = dt;
                                }
                            }
                        }
                    }
                }

                this.dataGridView1.DataSource = dtTask;
                this.dataGridView1.Refresh();
            }
            else
            {
                DataTable dt2 = (DataTable) this.dataGridView1.DataSource;
                if (dt2 != null && dt2.Rows.Count > 0)
                {
                    dt2.Rows.Clear();
                    this.dataGridView1.DataSource = dt2;
                    this.dataGridView1.Refresh();
                }

            }
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
            {
                return;
            }

            //处理
            if (dataGridView1.Columns[e.ColumnIndex].Name == "processBtn")
            {
                int taskType = ConvertUtils.ConvertToInt(this.dataGridView1.Rows[e.RowIndex].Cells["taskType"].Value);

                Form form;
                switch (taskType)
                {
                    case (int)Enum.EnumTaskType.MaterialsExpired:
                        form = new Store.FrmInventory();
                        form.ShowDialog();
                        break;
                    case (int)Enum.EnumTaskType.MaterialsStockOut:
                        form = new Purchase.FrmPurchaseManage();
                        form.ShowDialog();
                       break;
                    case (int)Enum.EnumTaskType.ProductExpired:
                        form = new Store.FrmInventory();
                        form.ShowDialog();
                        break;
                    case (int)Enum.EnumTaskType.ProductStockOut:
                        form = new Produce.FrmProduceManage();
                        form.ShowDialog();
                        break;
                    case (int)Enum.EnumTaskType.ProduceApply:
                        form = new Produce.FrmProducePlan();
                        form.ShowDialog();
                        break;
                    case (int)Enum.EnumTaskType.PurchaseApply:
                        form = new Purchase.FrmPurchasePlan();
                        form.ShowDialog();
                        break;
                }
                doSelect();
            }

        }

        private void FrmTask_FormClosed(object sender, FormClosedEventArgs e)
        {
            WinCommon.Exit();
        }

        private void cmb_role_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<ModelItem> listItem = m_bllCode.GetCodeItem((int)Enum.EnumCode.TaskType);

            int roleId = ConvertUtils.ConvertToInt(((ModelItem)this.cmb_role.SelectedItem).itemKey);
            int roleType = m_bllRole.GetRoleById(roleId).roleType;

            if(!WinCommon.IsAdmin(roleType))
            {
                for (int idx = listItem.Count - 1; idx >= 0; idx -- )
                {
                    ModelItem item = listItem[idx];
                    if (ConvertUtils.ConvertToInt(item.itemKey) > 0)
                    {
                        bool deleteTask = true;
                        ModelCode modelCode = m_bllCode.GetSubCode((int)Enum.EnumCode.TaskType, ConvertUtils.ConvertToInt(item.itemKey));
                        string[] taskRole = modelCode.value2.Split(',');
                        for (int i = 0; i < taskRole.Length; i++)
                        {
                            if (roleType == ConvertUtils.ConvertToInt(taskRole[i]))
                            {
                                deleteTask = false;
                                break;
                            }
                        }

                        if (deleteTask)
                        {
                            listItem.RemoveAt(idx);
                        }
                    }
                }
            }

            WinCommon.BindComboBox(ref this.cmb_taskType, listItem);
        }

 
    }
}
