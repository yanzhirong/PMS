using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Model;
using Enum;
using Common.Tools;

namespace Dal
{
    public class DalPurchase
    {
        string sql;
        StringBuilder sbSql = new StringBuilder();

        public int AddPurchaseApply(List<ModelPurchaseApply> _listPurchaseApply)
        {
            List<string> listSql = new List<string>();

            List<string> listProduceCode = new List<string>();

            foreach (ModelPurchaseApply purchaseApply in _listPurchaseApply)
            {
                sbSql.Clear();
                sbSql.Append("insert into ");
                sbSql.Append("       p_purchase_apply ( ");
                sbSql.Append("       factoryId, ");
                sbSql.Append("       materialsId, ");
                sbSql.Append("       num, ");
                sbSql.Append("       unit, ");
                sbSql.Append("       produceCode, ");
                sbSql.Append("       deliveryDate, ");
                sbSql.Append("       applyType, ");
                sbSql.Append("       applyBy, ");
                sbSql.Append("       applyDate, ");
                sbSql.Append("       status, ");
                sbSql.Append("       remark, ");
                sbSql.Append("       isDelete, ");
                sbSql.Append("       createBy, ");
                sbSql.Append("       createTime");
                sbSql.Append("       ) value ( ");
                sbSql.Append("       " + purchaseApply.factoryId + ", ");
                sbSql.Append("       " + purchaseApply.materialsId + ", ");
                sbSql.Append("       " + purchaseApply.num + ", ");
                sbSql.Append("       " + purchaseApply.unit + ", ");
                sbSql.Append("      '" + purchaseApply.produceCode + "', ");
                sbSql.Append("      '" + purchaseApply.deliveryDate + "', ");
                sbSql.Append("       " + purchaseApply.applyType + ", ");
                sbSql.Append("      '" + purchaseApply.applyBy + "', ");
                sbSql.Append("      '" + purchaseApply.applyDate + "', ");
                sbSql.Append("       " + purchaseApply.status + ", ");
                sbSql.Append("      '" + purchaseApply.remark + "', ");
                sbSql.Append("       " + purchaseApply.isDelete + ", ");
                sbSql.Append("      '" + purchaseApply.createBy + "', ");
                sbSql.Append("      '" + purchaseApply.createTime + "')");

                listSql.Add(sbSql.ToString());

                if(!listProduceCode.Contains(purchaseApply.produceCode))
                {
                    listProduceCode.Add(purchaseApply.produceCode);
                }
            }

            foreach(string produceCode in listProduceCode)
            {
                sbSql.Clear();
                sbSql.Append("update p_produce ");
                sbSql.Append("set status = ").Append((int)Enum.EnumProduceOrderStatus.MaterialsPurchasing).Append(" ");
                sbSql.Append("where produceCode = '").Append(produceCode).Append("'");
                listSql.Add(sbSql.ToString());
            }

            return Dal.DBHelper.ExcuteTransaction(listSql);
        }
        
    }
}
