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
    public class BllProductIn : Bll.BllBase
    {
        private DalProductIn m_dalProductIn = new DalProductIn();
        private DalStore m_dalStore = new DalStore();

        public DataTable GetProductIn(String _productName, int _factoryId, DateTime _beginTime, DateTime _endTime, int _inputStatus)
        {
            DataTable dt = m_dalProductIn.GetProductIn(_productName, _factoryId, _beginTime, _endTime, _inputStatus);

            return dt;
        }

        public ModelProductIn GetProductInById(int _productInId)
        {
            DataTable dt = m_dalProductIn.GetProductInById(_productInId);
            
            if(dt != null && dt.Rows.Count > 0)
            {
                return ModelUtils<ModelProductIn>.FillModel(dt.Rows[0]);
            }

            return new ModelProductIn();

        }

        public Boolean AddProductIn(ModelProductIn _model)
        {
            int rtn = 0;
            _model.inputCode = BllSeq.GetCode("productInCode");
            _model.status = 1;
            rtn = m_dalProductIn.AddProductIn(_model);

            return rtn == 0 ? false : true;
        }

        public Boolean UpdateProductIn(ModelProductIn _model)
        {
            int rtn = 0;
            if (StringUtils.IsBlank(_model.inputCode))
            {
                _model.inputCode = BllSeq.GetCode("productInCode");
            }
            _model.status = 1;
            rtn = m_dalProductIn.UpdateProductIn(_model);

            return rtn == 0 ? false : true;
        }

        public Boolean DeleteProductIn(ModelProductIn _model)
        {
            int rtn = 0;
            rtn = m_dalProductIn.DeleteProductIn(_model);

            return rtn == 0 ? false : true;
        }

        public Boolean CheckUpdateDelete(string _inputCode)
        {
            DataTable dt = m_dalStore.GetProductOutputLogByInputCode(_inputCode);

            if (dt != null && dt.Rows.Count > 0)
            {
                return false;
            }

            return true;
        }

    }
}
