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
    public class BllCompany : Bll.BllBase
    {
        private DalCompany m_dalCompany = new DalCompany();

        public ModelCompany GetCompany()
        {
            DataTable company = m_dalCompany.GetCompany();

            if (company != null && company.Rows.Count > 0)
            {
                return ModelUtils<ModelCompany>.FillModel(company.Rows[0]);
            }
            return new ModelCompany();
        }

        public Boolean UpdatecCompany(ModelCompany _modelCompany)
        {
            int rtn = 0;
            rtn = m_dalCompany.UpdatecCompany(_modelCompany);

            return rtn == 0 ? false : true;
        }
    }
}
