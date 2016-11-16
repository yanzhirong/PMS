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
    public class BllUser : Bll.BllBase
    {
        private DalUser dalUser = new DalUser();

        public List<ModelItem> GetAllRoles()
        {
            DataTable roles = dalUser.GetAllRoles();

            if(roles != null && roles.Rows.Count > 0){
                return ModelUtils<ModelItem>.FillModel(roles);
            }
            return null;          
        }

        public DataTable GetUsers(string _name, int _roleId)
        {
            DataTable users = dalUser.GetUsers(_name, _roleId);

            if (users != null && users.Rows.Count > 0)
            {
                return users;
            }
            return null;
        }


    }

}
