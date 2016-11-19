using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dal;
using System.Data;
using Common.Enum;
using Common.Tools;
using Model;

namespace Bll
{
    public class BllLogin : Bll.BllBase
    {
        private DalUser dalUser = new DalUser();
        private DalRole dalRole = new DalRole();

        public void DoLogin(string _name , string _pwd)
        {
            DataTable user = dalUser.GetUser(_name);

            this.result = new Result();

            if (user != null && user.Rows.Count > 0)
            {
                string pwd = (string)user.Rows[0]["pwd"];

                if (_pwd.Equals(pwd))
                {
                    this.result.resultCode = EnumResultCode.Success;
                }
                else
                {
                    this.result.resultCode = EnumResultCode.Failed;
                    this.result.resultMsg = "密码不正确！";
                }
            }
            else
            {
                this.result.resultCode = EnumResultCode.Failed;
                this.result.resultMsg = "用户不存在！";
            }
        }

        public ModelUser GetLoginUser(string _name)
        {
            DataTable user = dalUser.GetUser(_name);

            if (user != null && user.Rows.Count > 0)
            {
               return ModelUtils<ModelUser>.FillModel(user.Rows[0]);
            }
            return new ModelUser();
        }

        public ModelRole GetLoginRole(int _roleId)
        {
            DataTable role = dalRole.GetRoleById(_roleId);

            if (role != null && role.Rows.Count > 0)
            {
                return ModelUtils<ModelRole>.FillModel(role.Rows[0]);
            }
            return null;
        }

        public List<ModelMenu> GetLoginMenu(int _roleId)
        {
            DataTable menu = dalRole.GetLoginMenuByRoleId(_roleId);

            if (menu != null && menu.Rows.Count > 0)
            {
                return ModelUtils<ModelMenu>.FillModel(menu);
            }
            return null;
        }
    }

}
