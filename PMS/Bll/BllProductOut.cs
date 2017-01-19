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

        public DataTable GetProductOut(String _productName, String _customerName, DateTime _beginTime, DateTime _endTime, int _orderStatus, int _outputStatus, int _outputType)
        {
            DataTable dt = m_dalProductOut.GetProductOut(_productName, _customerName, _beginTime, _endTime, _orderStatus, _outputStatus, _outputType);

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

        public ModelProductOutput GetProductOutrByOutputCode(string _outputCode)
        {
            ModelProductOutput model = new ModelProductOutput();

            DataTable dt = m_dalProductOut.GetProductOutrByOutputCode(_outputCode);

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
            int seq = Bll.BllSeq.GetSeq("productOut");
            string outputCode = ConvertUtils.ConvertToDate(DateTime.Now, "yyyyMMddHHmmss") + "_" + seq;
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

        public Boolean CheckDelete(string _outputCode)
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
    }
}
