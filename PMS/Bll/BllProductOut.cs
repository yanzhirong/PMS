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
    public class BllProductOut : Bll.BllBase
    {
        private DalProductOut m_dalProductOut = new DalProductOut();

        public DataTable GetProductOut(String _productName, String _customerName, int _factoryId, DateTime _beginTime, DateTime _endTime, int _outputType, int _outputStatus)
        {
            DataTable dt = m_dalProductOut.GetProductOut(_productName, _customerName, _factoryId, _beginTime, _endTime, _outputType, _outputStatus);

            return dt;
        }

        public ModelProductOutput GetProductOutById(int _productOutId)
        {
            DataTable dt = m_dalProductOut.GetProductOutById(_productOutId);
            
            if(dt != null && dt.Rows.Count > 0)
            {
                return ModelUtils<ModelProductOutput>.FillModel(dt.Rows[0]);
            }

            return new ModelProductOutput();

        }

        public ModelProductOutputDetail GetProductOutDetailById(int _productOutDetailId)
        {
            DataTable dt = m_dalProductOut.GetProductOutDetailById(_productOutDetailId);

            if (dt != null && dt.Rows.Count > 0)
            {
                return ModelUtils<ModelProductOutputDetail>.FillModel(dt.Rows[0]);
            }

            return new ModelProductOutputDetail();

        }

        public ModelProductOutput GetProductOutByOutputCode(string _outputCode)
        {
            ModelProductOutput model = new ModelProductOutput();

            DataTable dt = m_dalProductOut.GetProductOutByOutputCode(_outputCode);

            if (dt != null && dt.Rows.Count > 0)
            {
                model = ModelUtils<ModelProductOutput>.FillModel(dt.Rows[0]);
            }
            return model;
        }

        public ModelProductOutput GetProductOutByOrderCode(string _orderCode)
        {
            ModelProductOutput model = new ModelProductOutput();

            DataTable dt = m_dalProductOut.GetProductOutByOrderCode(_orderCode);

            if (dt != null && dt.Rows.Count > 0)
            {
                model = ModelUtils<ModelProductOutput>.FillModel(dt.Rows[0]);
            }
            return model;
        }

        public DataTable GetProductOutDetailByOutputCode(string _outputCode)
        {
            return m_dalProductOut.GetProductOutDetailByOutputCode(_outputCode);
        }

        public Boolean AddProductOut(ModelProductOutput _model)
        {
            int rtn = 0;
            string outputCode = BllSeq.GetCode("productOutCode");
            _model.outputCode = outputCode;
            _model.outputStatus = 0;
            rtn = m_dalProductOut.AddProductOut(_model);

            return rtn == 0 ? false : true;
        }

        public Boolean UpdateProductOut(ModelProductOutput _model)
        {
            int rtn = 0;
            rtn = m_dalProductOut.UpdateProductOut(_model);

            return rtn == 0 ? false : true;
        }

        public Boolean DeleteProductOut(ModelProductOutput _model)
        {
            int rtn = 0;
            rtn = m_dalProductOut.DeleteProductOut(_model);

            return rtn == 0 ? false : true;
        }

        public Boolean CheckUpdateDelete(string _outputCode)
        {
            DataTable dt = m_dalProductOut.GetProductOutDetailByOutputCode(_outputCode);

            if (dt != null && dt.Rows.Count > 0)
            {
                foreach (DataRow dr in dt.Rows)
                {
                    if(ConvertUtils.ConvertToInt(dr["outputStatus"]) > 0)
                    {
                        return false;
                    }
                }
            }

            return true;
        }

        public DataTable GetProductOutSelect(int _factoryId, int _productId)
        {
            DataTable dt = m_dalProductOut.GetProductOutSelect(_factoryId, _productId);

            return dt;

        }

        public Boolean doOutPut(string _outputCode, int _outputDetailId, int _factoryId, int _productId, int _applyMemberId, int _outputNum, List<Dictionary<string, object>> listOutput, string userName)
        {
            int rtn = m_dalProductOut.doOutPut(_outputCode, _outputDetailId, _factoryId, _productId, _applyMemberId, _outputNum, listOutput, userName);

            return rtn > 0 ? true : false;
        }
    }
}
