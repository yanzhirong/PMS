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
    public class BllMaterialsIn : Bll.BllBase
    {
        private DalMaterialsIn m_dalMaterialsIn = new DalMaterialsIn();
        private DalStore m_dalStore = new DalStore();

        public DataTable GetMaterialsIn(String _materialsName, int _customerId, int _factoryId, DateTime _beginTime, DateTime _endTime, int _inputStatus)
        {
            DataTable dt = m_dalMaterialsIn.GetMaterialsIn(_materialsName, _customerId, _factoryId, _beginTime, _endTime, _inputStatus);

            return dt;
        }

        public ModelMaterialsIn GetMaterialsInById(int _materialsId)
        {
            DataTable dt = m_dalMaterialsIn.GetMaterialsInById(_materialsId);
            
            if(dt != null && dt.Rows.Count > 0)
            {
                return ModelUtils<ModelMaterialsIn>.FillModel(dt.Rows[0]);
            }

            return new ModelMaterialsIn();

        }

        public ModelMaterialsIn GetMaterialsInByInputCode(string _inputCode)
        {
            ModelMaterialsIn model = new ModelMaterialsIn();

            DataTable dt = m_dalMaterialsIn.GetMaterialsInByInputCode(_inputCode);

            if (dt != null && dt.Rows.Count > 0)
            {
                model = ModelUtils<ModelMaterialsIn>.FillModel(dt.Rows[0]);
            }
            return model;
        }

        public Boolean AddMaterialsIn(ModelMaterialsIn _model)
        {
            int rtn = 0;
            _model.inputCode = BllSeq.GetCode("materialsInCode");
            _model.inputStatus = 1;
            rtn = m_dalMaterialsIn.AddMaterialsIn(_model);

            return rtn == 0 ? false : true;
        }

        public Boolean UpdateMaterialsIn(ModelMaterialsIn _model)
        {
            int rtn = 0;
            if (StringUtils.IsBlank(_model.inputCode))
            {
                _model.inputCode = BllSeq.GetCode("materialsInCode");
            }
            _model.inputStatus = 1;
            rtn = m_dalMaterialsIn.UpdateMaterialsIn(_model);

            return rtn == 0 ? false : true;
        }

        public Boolean DeleteMaterialsIn(ModelMaterialsIn _model)
        {
            int rtn = 0;
            rtn = m_dalMaterialsIn.DeleteMaterialsIn(_model);

            return rtn == 0 ? false : true;
        }

        public Boolean CheckUpdateDelete(string _inputCode)
        {
            DataTable dt = m_dalStore.GetMaterialsOutputLogByInputCode(_inputCode);

            if (dt != null && dt.Rows.Count > 0)
            {
                return false;
            }

            return true;
        }

    }
}
