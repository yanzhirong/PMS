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
                sbSql.Append("       saleOrderCode, ");
                sbSql.Append("       outputCode, ");
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
                sbSql.Append("       " + produceApply.factoryId + ", ");
                sbSql.Append("       " + produceApply.productId + ", ");
                sbSql.Append("       " + produceApply.num + ", ");
                sbSql.Append("       " + produceApply.unit + ", ");
                sbSql.Append("      '" + produceApply.saleOrderCode + "', ");
                sbSql.Append("      '" + produceApply.outputCode + "', ");
                sbSql.Append("      '" + produceApply.deliveryDate + "', ");
                sbSql.Append("       " + produceApply.applyType + ", ");
                sbSql.Append("      '" + produceApply.applyBy + "', ");
                sbSql.Append("      '" + produceApply.applyDate + "', ");
                sbSql.Append("       " + produceApply.status + ", ");
                sbSql.Append("      '" + produceApply.remark + "', ");
                sbSql.Append("       " + produceApply.isDelete + ", ");
                sbSql.Append("      '" + produceApply.createBy + "', ");
                sbSql.Append("      '" + produceApply.createTime + "')");

                listSql.Add(sbSql.ToString());
            }

            sbSql.Clear();
            sbSql.Append("update p_saleOrder ");
            sbSql.Append("set orderStatus = " + (int)Enum.EnumSaleOrderStatus.Producing + " ");
            sbSql.Append("where orderCode = '" + _listProduceApply[0].saleOrderCode).Append("'");
            listSql.Add(sbSql.ToString());

            return Dal.DBHelper.ExcuteTransaction(listSql);
        }

        public DataTable GetProduceApplyByOutputCodeAndProductId(string _outputCode, int _productId)
        {

            sbSql.Clear();
            sbSql.Append("select * ");
            sbSql.Append("  from p_produce_apply ");
            sbSql.Append(" where isDelete = 0 ");
            sbSql.Append("   and outputCode = '").Append(_outputCode).Append("' ");
            sbSql.Append("   and productId = ").Append(_productId).Append(" ");

            return Dal.DBHelper.Select(sbSql.ToString());

        }

    }
}
