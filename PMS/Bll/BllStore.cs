﻿using System;
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
    public class BllStroe : Bll.BllBase
    {
        private BllCode m_bllCode = new BllCode();
        private DalStore m_dalStore = new DalStore();

        public decimal GetStoreProductNum(int _factoryId, int _productId, DateTime _expiresDate)
        {
            DataTable dt = m_dalStore.GetStoreProductNum(_factoryId, _productId, _expiresDate);

            if (dt != null && dt.Rows.Count > 0)
            {
                decimal storeNum = 0;
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    storeNum = storeNum + ConvertUtils.ConvertToDecimal(dt.Rows[0]["num"]) * m_bllCode.GetWeightUnit(ConvertUtils.ConvertToInt(dt.Rows[0]["unit"]));
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
                    storeNum = storeNum + ConvertUtils.ConvertToDecimal(dt.Rows[0]["num"]) * m_bllCode.GetWeightUnit(ConvertUtils.ConvertToInt(dt.Rows[0]["unit"]));
                }
                return storeNum;
            }
            return 0;
        }
    }
}
