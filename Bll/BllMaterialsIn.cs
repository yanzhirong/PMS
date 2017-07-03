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

        public DataTable GetMaterialsIn(String _materialsName, int _customerId, int _factoryId, DateTime _beginTime, DateTime _endTime, int _inputStatus, int _isQC)
        {
            DataTable dt = m_dalMaterialsIn.GetMaterialsIn(_materialsName, _customerId, _factoryId, _beginTime, _endTime, _inputStatus, _isQC);

            return dt;
        }

        public ModelMaterialsIn GetMaterialsInById(int _id)
        {
            DataTable dt = m_dalMaterialsIn.GetMaterialsInById(_id);
            
            if(dt != null && dt.Rows.Count > 0)
            {
                return ModelUtils<ModelMaterialsIn>.FillModel(dt.Rows[0]);
            }

            return new ModelMaterialsIn();

        }

        public DataTable GetMaterialsInByMaterialsIdSpecsId(int _materialsId, int _specsId)
        {
            DataTable dt = m_dalMaterialsIn.GetMaterialsInByMaterialsIdSpecsId(_materialsId, _specsId);
            return dt;

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
            _model.inputCode = BllSeq.GetCode("ylrk", "materialsInCode");
            _model.inputStatus = 1;
            rtn = m_dalMaterialsIn.AddMaterialsIn(_model);

            return rtn == 0 ? false : true;
        }

        public Boolean UpdateMaterialsIn(ModelMaterialsIn _model)
        {
            int rtn = 0;
            if (StringUtils.IsBlank(_model.inputCode))
            {
                _model.inputCode = BllSeq.GetCode("ylrk", "materialsInCode");
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

        public DataTable GetMaterialsInQCByInputCode(String _inputCode)
        {
            DataTable dt = m_dalMaterialsIn.GetMaterialsInQCByInputCode(_inputCode);

            return dt;
        }

        public ModelMaterialsInQC GetQCById(int _QCId)
        {
            DataTable user = m_dalMaterialsIn.GetQCById(_QCId);

            if (user != null && user.Rows.Count > 0)
            {
                return ModelUtils<ModelMaterialsInQC>.FillModel(user.Rows[0]); ;
            }
            return null;
        }
        public Boolean AddMaterialsInQC(ModelMaterialsInQC _model)
        {
            int rtn = 0;
            rtn = m_dalMaterialsIn.AddMaterialsInQC(_model);
            if(rtn > 0)
            {
                rtn = m_dalMaterialsIn.UpdateMaterialsInQC(_model.inputCode);
            }
            return rtn == 0 ? false : true;
        }

        public Boolean DeleteMaterialsInQC(ModelMaterialsInQC _model)
        {
            int rtn = 0;
            rtn = m_dalMaterialsIn.DeleteMaterialsInQC(_model);
            if (rtn > 0)
            {
                rtn = m_dalMaterialsIn.UpdateMaterialsInQC(_model.inputCode);
            }
            return rtn == 0 ? false : true;
        }
    }
}
