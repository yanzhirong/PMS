using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dal;
using System.Data;
using Common.Tools;
using Model;

namespace Bll
{
    public class BllCustomer : Bll.BllBase
    {
        private DalCustomer m_dalCustomer = new DalCustomer();

        public DataTable GetCustomers(string _code, string _name, int _type, int _salerId)
        {
            DataTable dt = m_dalCustomer.GetCustomers(_code, _name, _type, _salerId);

            return dt;
        }

        public ModelCustomer GetCustomerById(int _id)
        {
            DataTable user = m_dalCustomer.GetCustomerById(_id);

            if (user != null && user.Rows.Count > 0)
            {
                return ModelUtils<ModelCustomer>.FillModel(user.Rows[0]); ;
            }
            return new ModelCustomer();
        }

        public ModelCustomer GetCustomerByCode(string _code)
        {
            DataTable user = m_dalCustomer.GetCustomerByCode(_code);

            if (user != null && user.Rows.Count > 0)
            {
                return ModelUtils<ModelCustomer>.FillModel(user.Rows[0]); ;
            }
            return new ModelCustomer();
        }

        public Boolean AddCustomer(ModelCustomer _modelCustomer)
        {
            int rtn = 0;
            rtn = m_dalCustomer.AddCustomer(_modelCustomer);

            return rtn == 0 ? false : true;
        }

        public Boolean UpdateCustomer(ModelCustomer _modelCustomer)
        {
            int rtn = 0;
            rtn = m_dalCustomer.UpdateCustomer(_modelCustomer);

            return rtn == 0 ? false : true;
        }

        public Boolean DeleteCustomer(ModelCustomer _modelCustomer)
        {
            int rtn = 0;
            rtn = m_dalCustomer.DeleteCustomer(_modelCustomer);

            return rtn == 0 ? false : true;
        }
    }

}
