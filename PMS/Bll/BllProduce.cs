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
    public class BllProduce : Bll.BllBase
    {
        private DalProduce m_dalProduce = new DalProduce();

        public Boolean AddProduceApply(List<ModelProduceApply> _listProduceApply)
        {
            int rtn = 0;
            rtn = m_dalProduce.AddProduceApply(_listProduceApply);

            return rtn == 0 ? false : true;
        }

    }
}
