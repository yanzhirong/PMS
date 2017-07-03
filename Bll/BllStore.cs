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
        private BllMaterials m_bllMaterials = new BllMaterials();
        private DalStore m_dalStore = new DalStore();

        public int GetStoreProductNum(int _factoryId, int _productId, int _specsId, DateTime _expiresDate)
        {
            DataTable dt = m_dalStore.GetStoreProductNum(_factoryId, _productId, _specsId, _expiresDate);

            if (dt != null && dt.Rows.Count > 0)
            {
                int storeNum = 0;
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    storeNum = storeNum + ConvertUtils.ConvertToInt(dt.Rows[i]["stockNum"]);
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
                    int specsId = ConvertUtils.ConvertToInt(dt.Rows[i]["specsId"]);
                    if (specsId > 0)
                    {
                        ModelMaterialsSpecs modelSpecs = m_bllMaterials.GetMaterialsSpecsById(specsId);
                        storeNum = storeNum + ConvertUtils.ConvertToInt(dt.Rows[i]["stockNum"]) * modelSpecs.weight * modelSpecs.num;
                    }
                    else
                    {
                        storeNum = storeNum + ConvertUtils.ConvertToInt(dt.Rows[i]["stockNum"]);
                    }
                }
                return storeNum;
            }
            return 0;
        }

        public DataTable GetProductStore(int _factoryId, string _productName, string _specsName)
        {
            return m_dalStore.GetProductStore(_factoryId, _productName, _productName);
        }

        public DataTable GetMaterialsStore(int _factoryId, string _materialsName, string _specsName)
        {
            return m_dalStore.GetMaterialsStore(_factoryId, _materialsName, _specsName);
        }

        public DataTable GetMaterialsOutputLogByOutputCode(string _outputCode, int _materialsId, int _specsId)
        {
            return m_dalStore.GetMaterialsOutputLogByOutputCode(_outputCode, _materialsId, _specsId);
        }

        public DataTable GetProductOutputLog(string _outputCode, int _productId, int _specsId)
        {
            return m_dalStore.GetProductOutputLog(_outputCode, _productId, _specsId);
        }

        public DataTable GetTransfer(string _name, int _factoryId, int _type, DateTime _beginTime, DateTime _endTime)
        {
            return m_dalStore.GetTransfer(_name, _factoryId, _type, _beginTime, _endTime);
        }

        public ModelTransfer GetTransferById(int _transferId)
        {
            //TODO
            return new ModelTransfer();
        }
        public Boolean AddTransfer(ModelTransfer _model, List<Dictionary<string, object>> _listTransferDetail)
        {
            int rtn = 0;

            //TODO

            return rtn > 0 ? true : false;
        }

        public DataTable GetStore(int _type, int _qc, string _name, int _factoryId, DateTime _expiresDate, DateTime _inputDate_begin, DateTime _inputDate_end, decimal _stockNum)
        {
            return m_dalStore.GetStore(_type, _qc, _name, _factoryId, _expiresDate, _inputDate_begin, _inputDate_end, _stockNum);
        }

        public DataTable GetStoreExport(int _type, int _qc, string _name, int _factoryId, DateTime _expiresDate, DateTime _inputDate_begin, DateTime _inputDate_end, decimal _stockNum)
        {
            return m_dalStore.GetStoreExport(_type, _qc, _name, _factoryId, _expiresDate, _inputDate_begin, _inputDate_end, _stockNum);
        }

        public Boolean UpdateInventoryProduct(ModelProductIn _modelProductIn, ModelInventoryProductLog _modelInventoryProductLog)
        {
            int rtn = m_dalStore.UpdateInventoryProduct(_modelProductIn, _modelInventoryProductLog);

            return rtn > 0 ? true : false;
        }

        public Boolean UpdateInventoryMaterials(ModelMaterialsIn _modelMaterialsIn, ModelInventoryMaterialsLog _modelInventoryMaterialsLog)
        {
            int rtn = m_dalStore.UpdateInventoryMaterials(_modelMaterialsIn, _modelInventoryMaterialsLog);

            return rtn > 0 ? true : false;
        }

        public DataTable GetTrace(int _factoryId, int _customerId, DateTime _outputDate_begin, DateTime _outputDate_end, string _productName, string _productSpecs, string _productOutputCode, string _materialsName, string _materislsSpecs, string _materialsInputCode)
        {
            DataTable dt = m_dalStore.GetTrace(_factoryId, _customerId, _outputDate_begin, _outputDate_end, _productName, _productSpecs, _productOutputCode, _materialsName, _materislsSpecs, _materialsInputCode);
            return dt;
        }

        public DataTable GetTraceExport(int _factoryId, int _customerId, DateTime _outputDate_begin, DateTime _outputDate_end, string _productName, string _productSpecs, string _productOutputCode, string _materialsName, string _materislsSpecs, string _materialsInputCode)
        {
            DataTable dt = m_dalStore.GetTraceExport(_factoryId, _customerId, _outputDate_begin, _outputDate_end, _productName, _productSpecs, _productOutputCode, _materialsName, _materislsSpecs, _materialsInputCode);
            return dt;
        }
    }
}
