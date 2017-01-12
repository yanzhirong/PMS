using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Model;
using Enum;

namespace Dal
{
    public class DalProduce
    {
        string sql;
        StringBuilder sbSql = new StringBuilder();

        public int AddProduceApply(List<ModelProduceApply> _listProduceApply)
        {
            List<string> listSql = new List<string>();

            foreach (ModelProduceApply produceApply in _listProduceApply)
            {
                sbSql.Clear();
                sbSql.Append("insert into ");
                sbSql.Append("       p_produce_apply ( ");
                sbSql.Append("       factoryId, ");
                sbSql.Append("       productId, ");
                sbSql.Append("       num, ");
                sbSql.Append("       unit, ");
                sbSql.Append("       saleOrderId, ");
                sbSql.Append("       deliverDate, ");
                sbSql.Append("       applyType, ");
                sbSql.Append("       applyBy, ");
                sbSql.Append("       applyDate, ");
                sbSql.Append("       status, ");
                sbSql.Append("       remark, ");
                sbSql.Append("       isDelete, ");
                sbSql.Append("       createBy, ");
                sbSql.Append("       createTime, ");
                sbSql.Append("       modifyBy, ");
                sbSql.Append("       modifyTime ");
                sbSql.Append("       ) value ( ");
                sbSql.Append("      '" + produceApply.factoryId + "', ");
                sbSql.Append("      '" + produceApply.productId + "', ");
                sbSql.Append("       " + produceApply.num + ", ");
                sbSql.Append("      '" + produceApply.unit + "', ");
                sbSql.Append("       " + produceApply.saleOrderId + ", ");
                sbSql.Append("      '" + produceApply.deliverDate + "', ");
                sbSql.Append("       " + produceApply.applyType + ", ");
                sbSql.Append("      '" + produceApply.applyBy + "', ");
                sbSql.Append("      '" + produceApply.applyDate + "', ");
                sbSql.Append("       " + produceApply.status + ", ");
                sbSql.Append("      '" + produceApply.remark + "', ");
                sbSql.Append("       " + produceApply.isDelete + ", ");
                sbSql.Append("      '" + produceApply.createBy + "', ");
                sbSql.Append("      '" + produceApply.createTime + "', ");
                sbSql.Append("      '" + produceApply.modifyBy + "', ");
                sbSql.Append("      '" + produceApply.modifyTime + "')");

                listSql.Add(sbSql.ToString());
            }
            return Dal.DBHelper.ExcuteTransaction(listSql);
        }

    }
}
