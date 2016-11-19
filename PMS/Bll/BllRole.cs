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
    public class BllRole : Bll.BllBase
    {
        private DalUser m_dalUser = new DalUser();
        private DalRole m_dalRole = new DalRole();

        public List<ModelItem> GetAllRoles()
        {
            DataTable roles = m_dalRole.GetAllRoles();

            if (roles != null && roles.Rows.Count > 0)
            {
                return ModelUtils<ModelItem>.FillModel(roles);
            }
            return null;
        }

        public List<ModelMenu> GetMenuByRoleId(int _roleId)
        {
            DataTable roles = m_dalRole.GetMenuByRoleId(_roleId);

            if(roles != null && roles.Rows.Count > 0){
                return ModelUtils<ModelMenu>.FillModel(roles);
            }
            return null;          
        }

        public int GetMenuIdByCheckBoxName(string _checkBoxName)
        {
            int menuId = 0;
            menuId = m_dalRole.GetMenuIdByCheckBoxName(_checkBoxName);
            return menuId;
        }

        public Boolean UpdateMenuByRoleId(int _roleId, List<ModelMenu> _listMenu, int _loginUserId)
        {

            int rtn = 0;
            rtn = m_dalRole.UpdateMenuByRoleId(_roleId, _listMenu, _loginUserId);

            return rtn == 0 ? false : true;

        }
    }

}
