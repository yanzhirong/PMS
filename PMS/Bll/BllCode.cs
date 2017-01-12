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
    public class BllCode : Bll.BllBase
    {
        private DalCode m_dalCode = new DalCode();

        public List<ModelItem> GetAllCodeName()
        {
            DataTable dt = m_dalCode.GetAllCodeName();

            if (dt != null && dt.Rows.Count > 0)
            {
                return ModelUtils<ModelItem>.FillModel(dt);
            }
            return null;
        }

        public ModelCode GetCodeByName(string _codeName)
        {
            DataTable dt = m_dalCode.GetCodeByName(_codeName);
            if (dt != null && dt.Rows.Count > 0)
            {
                return ModelUtils<ModelCode>.FillModel(dt.Rows[0]);
            }
            return new ModelCode();
        }
        
        public List<ModelItem> GetCodeItem(int _code)
        {
            return GetCodeItem(_code, true , "subCode", "value1");
        }

        public List<ModelItem> GetCodeItem(int _code, Boolean _isAddBlank)
        {
            return GetCodeItem(_code, _isAddBlank, "subCode", "value1");
        }

        public List<ModelItem> GetCodeItem(int _code, Boolean _isAddBlank, string _itemKeyName, string _itemValueName)
        {
            List<ModelItem> listItem = new List<ModelItem>();

            if (_isAddBlank)
            {
                ModelItem item = new ModelItem();
                listItem.Add(item);
            }

            DataTable dt = m_dalCode.GetCode(_code, false);
            if (dt != null && dt.Rows.Count > 0)
            {
                foreach (DataRow dr in dt.Rows)
                {
                    ModelItem item = new ModelItem();
                    item.itemKey = dr[_itemKeyName];
                    item.itemValue = dr[_itemValueName].ToString();
                    listItem.Add(item);
                }
            }
            return listItem;
        }
        public DataTable GetCodeList(int _code)
        {
            DataTable dt = m_dalCode.GetCode(_code, false);

            return dt;
        }

        public ModelCode GetSubCode(int _code, int _subCode)
        {
            DataTable dt = m_dalCode.GetSubCode(_code, _subCode);

            if (dt != null && dt.Rows.Count > 0)
            {
                return ModelUtils<ModelCode>.FillModel(dt.Rows[0]);
            }
            return new ModelCode();
        }

        public Boolean AddCode(ModelCode _modelCode)
        {
            int rtn = m_dalCode.AddCode(_modelCode);
            return rtn > 0 ? true : false;
        }

        public Boolean UpdateCode(List<ModelCode> _listCode)
        {
            int rtn = m_dalCode.UpdateCode(_listCode);
            return rtn > 0 ? true : false;
        }

        public decimal GetWeightUnit(int _unit)
        {
            DataTable dt = m_dalCode.GetWeightUnit(_unit);

            if (dt != null && dt.Rows.Count > 0)
            {
                return ConvertUtils.ConvertToDecimal(dt.Rows[0][0]);
            }
            else
            {
                return 0;
            }
        }
    }
}
