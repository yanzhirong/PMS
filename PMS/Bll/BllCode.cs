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

        public List<ModelItem> GetCodeItem(string _code)
        {
            return GetCodeItem(_code, true , "subCode", "value1");
        }

        public List<ModelItem> GetCodeItem(string _code, Boolean _isAddBlank)
        {
            return GetCodeItem(_code, _isAddBlank, "subCode", "value1");
        }

        public List<ModelItem> GetCodeItem(string _code, Boolean _isAddBlank, string _itemKeyName, string _itemValueName)
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
        public List<ModelCode> GetCodeList(string _code)
        {
            DataTable dt = m_dalCode.GetCode(_code, true);

            if (dt != null && dt.Rows.Count > 0)
            {
                return ModelUtils<ModelCode>.FillModel(dt);
            }
            return null;
        }

        public ModelCode GetSubCode(string _code, string _subCode)
        {
            DataTable dt = m_dalCode.GetSubCode(_code, _subCode);

            if (dt != null && dt.Rows.Count > 0)
            {
                return ModelUtils<ModelCode>.FillModel(dt.Rows[0]);
            }
            return new ModelCode();
        }
    }
}
