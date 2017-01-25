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
    public class BllPurchase : Bll.BllBase
    {
        private DalPurchase m_dalPurchase = new DalPurchase();

        public Boolean AddPurchaseApply(List<ModelPurchaseApply> _listPurchaseApply)
        {
            int rtn = 0;
            rtn = m_dalPurchase.AddPurchaseApply(_listPurchaseApply);

            return rtn == 0 ? false : true;
        }
    }
}
