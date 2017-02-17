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
    public class BllStore : Bll.BllBase
    {
        private BllCode m_bllCode = new BllCode();
        private DalStore m_dalStore = new DalStore();

        public int GetStoreProductNum(int _factoryId, int _productId, DateTime _expiresDate)
        {
            DataTable dt = m_dalStore.GetStoreProductNum(_factoryId, _productId, _expiresDate);

            if (dt != null && dt.Rows.Count > 0)
            {
                int storeNum = 0;
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    storeNum = storeNum + ConvertUtils.ConvertToInt(dt.Rows[i]["num"]);
                }
                return storeNum;
            }
            return 0;
        }

        public decimal GetStoreMaterialsNum(int _factoryId, int _materialsId, DateTime _expiresDate)
        {
            DataTable dt = m_dalStore.GetStoreMaterialsNum(_factoryId, _materialsId, _expiresDate);

            if (dt != null && dt.Rows.Count > 0)
            {
                decimal storeNum = 0;
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    storeNum = storeNum + ConvertUtils.ConvertToDecimal(dt.Rows[i]["num"]) * m_bllCode.GetWeightUnit(ConvertUtils.ConvertToInt(dt.Rows[i]["unit"]));
                }
                return storeNum;
            }
            return 0;
        }

        public DataTable GetProductStore(string _productName, int _factoryId)
        {
            return m_dalStore.GetProductStore(_productName, _factoryId);
        }
        
        public DataTable GetMaterialsStore(string _materialsName, int _factoryId)
        {
            return m_dalStore.GetMaterialsStore(_materialsName, _factoryId);
        }

        public DataTable GetMaterialsOutputLogByOutputCode(string _outputCode)
        {
            return m_dalStore.GetMaterialsOutputLogByOutputCode(_outputCode);
        }

        public DataTable GetProductOutputLogByOutputCode(string _outputCode)
        {
            return m_dalStore.GetProductOutputLogByOutputCode(_outputCode);
        }
    }
}
