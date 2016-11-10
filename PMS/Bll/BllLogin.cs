using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dal;
using System.Data;
using Common.Enum;
using Model;

namespace Bll
{
    public class BllLogin : Bll.BllBase
    {
        public void DoLogin(string _name , string _pwd)
        {
            DalLogin dalLogin = new DalLogin();

            DataTable user = dalLogin.GetUser(_name);

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
    }
}
