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

        public string GetOutputNum(string _outputCode)
        {
            string rtn = "";

            if(StringUtils.IsNotBlank(_outputCode))
            {
                DataTable dt = m_dalMaterialsOut.GetOutputNum(_outputCode);
                if (dt != null && dt.Rows.Count > 0)
                {
                    decimal allNum = 0;
                    int unit = 0;
                    foreach (DataRow dr in dt.Rows)
                    {
                        if (unit == 0)
                        {
                            unit = ConvertUtils.ConvertToInt(dr["uint"]);
                        }

                        decimal curNum = ConvertUtils.ConvertToDecimal(dr["num"]);
                        int curUnit = ConvertUtils.ConvertToInt(dr["unit"]);
                        curNum = curNum * m_bllCode.GetWeightUnit(curUnit);

                        allNum = allNum + curNum;
                    }

                    allNum = allNum / m_bllCode.GetWeightUnit(unit);

                    rtn = allNum + m_bllCode.GetSubCode((int)Enum.EnumCode.WeightUnit, unit).value1;
                }

            }
            return rtn;
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

        public Boolean AddMaterialsOut(ModelMaterialsOutput _model)
        {
            int rtn = 0;
            string outputCode = BllSeq.GetCode("materialsOutCode");
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

        public DataTable GetMaterialsOutSelect(int _factoryId, int _materialsId)
        {
            DataTable dt = m_dalMaterialsOut.GetMaterialsOutSelect(_factoryId, _materialsId);

            return dt;

        }

        public Boolean doOutPut(string _outputCode, int _factoryId, int _materialsId, decimal _outputNum, int _applyMemberId, List<Dictionary<string, object>> listOutput, string userName)
        {
            int rtn = m_dalMaterialsOut.doOutPut(_outputCode, _factoryId, _materialsId, _outputNum, _applyMemberId, listOutput, userName);

            return rtn > 0 ? true : false;
        }
    }
}
