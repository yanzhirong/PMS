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
    public class BllMaterialsOut : Bll.BllBase
    {
        private BllCode m_bllCode = new BllCode();
        private BllMaterials m_bllMaterials = new BllMaterials();
        private DalMaterialsOut m_dalMaterialsOut = new DalMaterialsOut();
        private DalStore m_dalStore = new DalStore();

        public DataTable GetMaterialsOut(String _materialsName, int _applyMemberId, int _factoryId, DateTime _beginTime, DateTime _endTime, int _outputStatus)
        {
            DataTable dt = m_dalMaterialsOut.GetMaterialsOut(_materialsName, _applyMemberId, _factoryId, _beginTime, _endTime, _outputStatus);

            return dt;
        }

        public ModelMaterialsOutput GetMaterialsOutById(int _materialsOutId)
        {
            DataTable dt = m_dalMaterialsOut.GetMaterialsOutById(_materialsOutId);
            
            if(dt != null && dt.Rows.Count > 0)
            {
                return ModelUtils<ModelMaterialsOutput>.FillModel(dt.Rows[0]);
            }

            return new ModelMaterialsOutput();

        }

        public decimal GetOutputNum(string _outputCode)
        {
            decimal allNum = 0;

            if(StringUtils.IsNotBlank(_outputCode))
            {
                DataTable dt = m_dalMaterialsOut.GetOutputNum(_outputCode);
                if (dt != null && dt.Rows.Count > 0)
                {
                    foreach (DataRow dr in dt.Rows)
                    {
                        int specsId = ConvertUtils.ConvertToInt(dr["specsId"]);
                        if (specsId > 0)
                        {
                            ModelMaterialsSpecs modelSpecs = m_bllMaterials.GetMaterialsSpecsById(specsId);
                            allNum = allNum + ConvertUtils.ConvertToDecimal(dr["outputNum"]) * (modelSpecs.weight * modelSpecs.num);
                        }
                        else
                        {
                            allNum = allNum + ConvertUtils.ConvertToDecimal(dr["outputNum"]);
                        }
                    }
                }

            }
            return allNum;
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

        public ModelMaterialsOutput GetMaterialsOutByOutputCode(string _outputCode)
        {
            ModelMaterialsOutput model = new ModelMaterialsOutput();

            DataTable dt = m_dalMaterialsOut.GetMaterialsOutByOutputCode(_outputCode);

            if (dt != null && dt.Rows.Count > 0)
            {
                model = ModelUtils<ModelMaterialsOutput>.FillModel(dt.Rows[0]);
            }
            return model;
        }

        public ModelMaterialsOutput GetMaterialsOutByProduceCode(string _produceCode)
        {
            ModelMaterialsOutput model = new ModelMaterialsOutput();

            DataTable dt = m_dalMaterialsOut.GetMaterialsOutByProduceCode(_produceCode);

            if (dt != null && dt.Rows.Count > 0)
            {
                model = ModelUtils<ModelMaterialsOutput>.FillModel(dt.Rows[0]);
            }
            return model;
        }
        public Boolean AddMaterialsOut(ModelMaterialsOutput _model)
        {
            int rtn = 0;
            string outputCode = BllSeq.GetCode("ylck", "materialsOutCode");
            _model.outputCode = outputCode;
            rtn = m_dalMaterialsOut.AddMaterialsOut(_model);

            return rtn == 0 ? false : true;
        }

        public Boolean UpdateMaterialsOut(ModelMaterialsOutput _model)
        {
            int rtn = 0;
            rtn = m_dalMaterialsOut.UpdateMaterialsOut(_model);

            return rtn == 0 ? false : true;
        }

        public Boolean DeleteMaterialsOut(ModelMaterialsOutput _model)
        {
            int rtn = 0;
            rtn = m_dalMaterialsOut.DeleteMaterialsOut(_model);

            return rtn == 0 ? false : true;
        }

        public DataTable GetMaterialsOutSelect(int _factoryId, int _materialsId, int _specsId)
        {
            DataTable dt = m_dalMaterialsOut.GetMaterialsOutSelect(_factoryId, _materialsId, _specsId);

            return dt;

        }

        public DataTable GetMaterialsOutDetailByOutputCode(string _outputCode)
        {
            DataTable dt = m_dalMaterialsOut.GetMaterialsOutDetailByOutputCode(_outputCode);

            return dt;

        }

        public ModelMaterialsOutputDetail GetMaterialsOutDetailById(int _outputDetailId)
        {
            ModelMaterialsOutputDetail model = new ModelMaterialsOutputDetail();

            DataTable dt = m_dalMaterialsOut.GetMaterialsOutDetailById(_outputDetailId);

            if (dt != null && dt.Rows.Count > 0)
            {
                model = ModelUtils<ModelMaterialsOutputDetail>.FillModel(dt.Rows[0]);
            }
            return model;
        }

        public Boolean AddMaterialsOutputDetail(ModelMaterialsOutputDetail _model)
        {
            int rtn = 0;
            rtn = m_dalMaterialsOut.AddMaterialsOutputDetail(_model);

            return rtn == 0 ? false : true;
        }

        public Boolean DeteleMaterialsOutputDetail(ModelMaterialsOutputDetail _model)
        {
            int rtn = 0;
            rtn = m_dalMaterialsOut.DeteleMaterialsOutputDetail(_model);

            return rtn == 0 ? false : true;
        }

        public Boolean doOutPut(string _outputCode, int _outputDetailId, int _factoryId, int _materialsId, decimal _outputNum, int _applyMemberId, List<Dictionary<string, object>> listOutput, string userName)
        {
            int rtn = m_dalMaterialsOut.doOutPut(_outputCode, _outputDetailId, _factoryId, _materialsId, _outputNum, _applyMemberId, listOutput, userName);

            return rtn > 0 ? true : false;
        }
    }
}
