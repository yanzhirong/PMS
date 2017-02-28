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
    public class DalProductIn
    {
        StringBuilder sbSql = new StringBuilder();

        public DataTable GetProductIn(String _productName, int _factoryId, DateTime _beginTime, DateTime _endTime, int _inputStatus)
        {
            sbSql.Clear();
            sbSql.Append("select a.id, ");
            sbSql.Append("       a.inputCode, ");
            sbSql.Append("       b.name factoryName, ");
            sbSql.Append("       c.name productName, ");
            sbSql.Append("       a.inputNum, ");
            sbSql.Append("       a.produceCode, ");
            sbSql.Append("       date_format(a.produceDate, '%Y-%m-%d') produceDate, ");
            sbSql.Append("       date_format(a.expiresDate, '%Y-%m-%d') expiresDate, ");
            sbSql.Append("       case a.inputStatus when 0 then '请求入库' else '完成入库' end inputStatus, ");
            sbSql.Append("       a.inputStatus inputStatusCode, ");
            sbSql.Append("       date_format(a.inputDate, '%Y-%m-%d') inputDate, ");
            sbSql.Append("       ifnull(f.cnt,0) outputCnt, ");
            sbSql.Append("       case ifnull(f.cnt,0) when 0 then '修改' else '查看' end modifyBtn, ");
            sbSql.Append("       '删除' deleteBtn ");
            sbSql.Append("from p_product_input a ");
            sbSql.Append("left join m_factory b ");
            sbSql.Append("  on a.factoryId = b.id ");
            sbSql.Append("left join p_product c ");
            sbSql.Append("  on a.productId = c.id ");
            sbSql.Append("left join (select count(*) cnt,inputCode ");
            sbSql.Append("             from h_product_output_log ");
            sbSql.Append("            where isDelete = 0 ");
            sbSql.Append("            group by inputCode) f ");
            sbSql.Append("  on a.inputCode = f.inputCode ");
            sbSql.Append("left join p_produce d ");
            sbSql.Append("  on a.produceCode = d.produceCode ");
            sbSql.Append("where a.isDelete = 0 ");
            if (Common.Tools.StringUtils.IsNotBlank(_productName))
            {
                sbSql.Append("   and a.productId in (");
                sbSql.Append("                     select productId ");
                sbSql.Append("                       from r_product_search ");
                sbSql.Append("                      where productName like '%").Append(_productName).Append("%' or upper(searchKey) like '%").Append(_productName.ToUpper()).Append("%') ");
            }
            if (_factoryId > 0)
            {
                sbSql.Append("  and a.factoryId = ").Append(_factoryId).Append(" ");
            }
            if (_inputStatus > -1)
            {
                sbSql.Append("  and a.inputStatus = ").Append(_inputStatus).Append(" ");
            }
            sbSql.Append("  and (d.status is null or d.status = " + (int)Enum.EnumProduceOrderStatus.Produced + " or d.status = " + (int)Enum.EnumProduceOrderStatus.Complete + ") ");
            sbSql.Append("  and (a.inputStatus = 0 or ( a.inputStatus = 1 ");
            sbSql.Append("  and a.inputDate >= '").Append(_beginTime).Append("' ");
            sbSql.Append("  and a.inputDate <= '").Append(_endTime).Append("')) ");
            sbSql.Append("order by a.modifyTime desc");

            return Dal.DBHelper.Select(sbSql.ToString());
        }

        public DataTable GetProductInById(int _productInId)
        {
            sbSql.Clear();
            sbSql.Append("select a.* ");
            sbSql.Append("from p_product_input a ");
            sbSql.Append("where a.isDelete = 0 ");
            sbSql.Append("  and a.id = ").Append(_productInId).Append(" ");

            return Dal.DBHelper.Select(sbSql.ToString());
        }

        public int AddProductIn(ModelProductIn _model)
        {
            List<string> listSql = new List<string>();

            sbSql.Clear();
            sbSql.Append("insert into ");
            sbSql.Append("       p_product_input ( ");
            sbSql.Append("       inputCode, ");
            sbSql.Append("       factoryId, ");
            sbSql.Append("       productId, ");
            sbSql.Append("       inputNum, ");
            sbSql.Append("       stockNum, ");
            sbSql.Append("       produceDate, ");
            sbSql.Append("       expiresDate, ");
            sbSql.Append("       produceCode, ");
            sbSql.Append("       inputType, ");
            sbSql.Append("       inputStatus, ");
            sbSql.Append("       inputDate, ");
            sbSql.Append("       remark, ");
            sbSql.Append("       isDelete, ");
            sbSql.Append("       createBy, ");
            sbSql.Append("       createTime ");
            sbSql.Append("       ) values ( ");
            sbSql.Append("      '" + _model.inputCode + "', ");
            sbSql.Append("       " + _model.factoryId + ", ");
            sbSql.Append("       " + _model.productId + ", ");
            sbSql.Append("       " + _model.inputNum + ", ");
            sbSql.Append("       " + _model.stockNum + ", ");
            sbSql.Append("      '" + _model.produceDate + "', ");
            sbSql.Append("      '" + _model.expiresDate + "', ");
            sbSql.Append("      '" + _model.produceCode + "', ");
            sbSql.Append("       " + _model.inputType + ", ");
            sbSql.Append("       " + _model.inputStatus + ", ");
            sbSql.Append("      '" + _model.inputDate + "', ");
            sbSql.Append("      '" + _model.remark + "', ");
            sbSql.Append("       " + _model.isDelete + ", ");
            sbSql.Append("      '" + _model.createBy + "', ");
            sbSql.Append("      '" + _model.createTime + "')");
            listSql.Add(sbSql.ToString());

            if (StringUtils.IsNotBlank(_model.produceCode))
            {

                // 更新生产单状态
                sbSql.Clear();
                sbSql.Append("update p_produce ");
                sbSql.Append("   set status = " + (int)Enum.EnumProduceOrderStatus.Complete + ",");
                sbSql.Append("       modifyBy = '" + _model.modifyBy + "',");
                sbSql.Append("       modifyTime = '" + _model.modifyTime + "' ");
                sbSql.Append(" where isDelete = 0 ");
                sbSql.Append("   and (select min(inputStatus) ");
                sbSql.Append("          from p_product_input ");
                sbSql.Append("         where produceCode = '" + _model.produceCode + "' ");
                sbSql.Append("           and isDelete = 0) = 1 ");
                listSql.Add(sbSql.ToString());
            }

            return Dal.DBHelper.ExcuteTransaction(listSql);
        }

        public int UpdateProductIn(ModelProductIn _model)
        {
            List<string> listSql = new List<string>();

            sbSql.Clear();
            sbSql.Append("update p_product_input ");
            sbSql.Append("set inputCode = '" + _model.inputCode + "',");
            sbSql.Append("    factoryId = " + _model.factoryId + ",");
            sbSql.Append("    productId = " + _model.productId + ",");
            sbSql.Append("    inputNum = " + _model.inputNum + ",");
            sbSql.Append("    stockNum = " + _model.stockNum + ",");
            sbSql.Append("    produceDate = '" + _model.produceDate + "',");
            sbSql.Append("    expiresDate = '" + _model.expiresDate + "',");
            sbSql.Append("    produceCode = '" + _model.produceCode + "',");
            sbSql.Append("    inputType = " + _model.inputType + ",");
            sbSql.Append("    inputStatus = " + _model.inputStatus + ",");
            sbSql.Append("    inputDate = '" + _model.inputDate + "',");
            sbSql.Append("    remark = '" + _model.remark + "',");
            sbSql.Append("    modifyBy = '" + _model.modifyBy + "',");
            sbSql.Append("    modifyTime = '" + _model.modifyTime + "' ");
            sbSql.Append("where id = " + _model.id);
            listSql.Add(sbSql.ToString());

            if (StringUtils.IsNotBlank(_model.produceCode))
            {

                // 更新生产单状态
                sbSql.Clear();
                sbSql.Append("update p_produce ");
                sbSql.Append("   set status = " + (int)Enum.EnumProduceOrderStatus.Complete + ",");
                sbSql.Append("       modifyBy = '" + _model.modifyBy + "',");
                sbSql.Append("       modifyTime = '" + _model.modifyTime + "' ");
                sbSql.Append(" where isDelete = 0 ");
                sbSql.Append("   and (select min(inputStatus) ");
                sbSql.Append("          from p_product_input ");
                sbSql.Append("         where produceCode = '" + _model.produceCode + "' ");
                sbSql.Append("           and isDelete = 0) = 1 ");
                listSql.Add(sbSql.ToString());

            }

            return Dal.DBHelper.ExcuteTransaction(listSql);
        }

        public int DeleteProductIn(ModelProductIn _model)
        {
            List<string> listSql = new List<string>();

            sbSql.Clear();
            sbSql.Append("update p_product_input ");
            sbSql.Append("set isDelete = 1,");
            sbSql.Append("    modifyBy = '" + _model.modifyBy + "',");
            sbSql.Append("    modifyTime = '" + _model.modifyTime + "' ");
            sbSql.Append("where id = " + _model.id);
            listSql.Add(sbSql.ToString());
            
            return Dal.DBHelper.ExcuteTransaction(listSql);
        }

    }
}
