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

        public DataTable GetRoles(string _name)
        {
            DataTable roles = m_dalRole.GetRoles(_name);

            return roles;
        }

        public ModelRole GetRoleByName(string _name)
        {
            DataTable dt = m_dalRole.GetRoleByName(_name);

            if (dt != null && dt.Rows.Count > 0)
            {
                return ModelUtils<ModelRole>.FillModel(dt.Rows[0]);
            }

            return new ModelRole();
        }

        public ModelRole GetRoleById(int _roleId)
        {
            DataTable dt = m_dalRole.GetRoleById(_roleId);
            if (dt != null && dt.Rows.Count > 0)
            {
                return ModelUtils<ModelRole>.FillModel(dt.Rows[0]);
            }

            return new ModelRole();
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

        public Boolean AddRole(ModelRole _modelRole, List<ModelMenu> _listMenu)
        {
            int rtn = 0;
            rtn = m_dalRole.AddRole(_modelRole, _listMenu);

            if (rtn > 0)
            {
                _modelRole.roleId = this.GetRoleByName(_modelRole.roleName).roleId;
                if (this.UpdateMenuByRoleId(_modelRole, _listMenu))
                {
                    return true;
                }
                else
                {
                    this.DeleteRole(_modelRole);
                    return false;
                }
            }

            return rtn == 0 ? false : true;
        }

        public Boolean UpdateRole(ModelRole _modelRole, List<ModelMenu> _listMenu)
        {
            int rtn = 0;
            rtn = m_dalRole.UpdateRole(_modelRole, _listMenu);

            return rtn == 0 ? false : true;
        }

        public Boolean DeleteRole(ModelRole _modelRole)
        {
            int rtn = 0;
            rtn = m_dalRole.DeleteRole(_modelRole);

            return rtn == 0 ? false : true;
        }

        public Boolean UpdateMenuByRoleId(ModelRole _modelRole, List<ModelMenu> _listMenu)
        {

            int rtn = 0;
            rtn = m_dalRole.UpdateMenuByRoleId(_modelRole, _listMenu);

            return rtn == 0 ? false : true;

        }
    }

}
