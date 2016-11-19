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
        private DalUser m_dalUser = new DalUser();
        private DalRole m_dalRole = new DalRole();

        public DataTable GetUsers(string _name, int _roleId)
        {
            DataTable users = m_dalUser.GetUsers(_name, _roleId);

            return users;
        }

        public ModelUser GetUserById(int _userId)
        {
            DataTable user = m_dalUser.GetUserById(_userId);

            if (user != null && user.Rows.Count > 0)
            {
                return ModelUtils<ModelUser>.FillModel(user.Rows[0]); ;
            }
            return new ModelUser();
        }

        public ModelUser GetUserByName(string _userName)
        {
            DataTable user = m_dalUser.GetUserByName(_userName);

            if (user != null && user.Rows.Count > 0)
            {
                return ModelUtils<ModelUser>.FillModel(user.Rows[0]); ;
            }
            return new ModelUser();
        }

        public Boolean AddUser(ModelUser _modelUser)
        {
            int rtn = 0;
            rtn = m_dalUser.AddUser(_modelUser);

            return rtn == 0 ? false : true;
        }

        public Boolean UpdateUser(ModelUser _modelUser, int _orgRoleId)
        {
            int rtn = 0;
            rtn = m_dalUser.UpdateUser(_modelUser, _orgRoleId);

            return rtn == 0 ? false : true;
        }

        public Boolean DeleteUser(ModelUser _modelUser)
        {
            int rtn = 0;
            rtn = m_dalUser.DeleteUser(_modelUser);

            return rtn == 0 ? false : true;
        }
    }

}
