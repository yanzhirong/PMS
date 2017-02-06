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

        public DataTable GetProduceApply(string _productName, int _factoryId, int _applyType, int _applyStatus, DateTime _beginTime, DateTime _endTime)
        {
            sbSql.Clear();
            sbSql.Append("select a.id, ");
            sbSql.Append("       a.factoryId, ");
            sbSql.Append("       b.name factoryName, ");
            sbSql.Append("       a.productId, ");
            sbSql.Append("       c.name productName, ");
            sbSql.Append("       concat(a.num, d.value1) numDisplay, ");
            sbSql.Append("       f.name customerName, ");
            sbSql.Append("       date_format(a.deliveryDate, '%Y-%m-%d') deliveryDate, ");
            sbSql.Append("       case a.status when 0 then '未确认' else '已确认' end applyStatus, ");
            sbSql.Append("       case a.applyType when 0 then '销售订单申请' else '特殊申请' end applyType, ");
            sbSql.Append("       a.applyBy applyMember, ");
            sbSql.Append("       date_format(a.applyDate, '%Y-%m-%d') applyDate, ");
            sbSql.Append("       '查看' queryStore, ");
            sbSql.Append("       a.num, ");
            sbSql.Append("       a.unit ");
            sbSql.Append("  from p_produce_apply a ");
            sbSql.Append("  left join m_factory b ");
            sbSql.Append("         on a.factoryId = b.id ");
            sbSql.Append("  left join p_product c ");
            sbSql.Append("         on a.productId = c.id ");
            sbSql.Append("  left join m_code d ");
            sbSql.Append("         on a.unit = d.subCode ");
            sbSql.Append("        and d.code = 3 ");
            sbSql.Append("  left join p_product_output e ");
            sbSql.Append("         on a.outputCode = e.outputCode ");
            sbSql.Append("  left join p_customer f ");
            sbSql.Append("         on e.customerId = f.id ");
            sbSql.Append(" where a.isDelete = 0 ");
            if (Common.Tools.StringUtils.IsNotBlank(_productName))
            {
                sbSql.Append("   and a.productId in (");
                sbSql.Append("                     select productId ");
                sbSql.Append("                       from r_product_search ");
                sbSql.Append("                      where productName like '%").Append(_productName).Append("%' or upper(searchKey) like '%").Append(_productName.ToUpper()).Append("%') ");
            }
            if (_factoryId > 0)
            {
                sbSql.Append("   and a.factoryId = ").Append(_factoryId).Append(" ");
            }
            if (_applyType > -1)
            {
                sbSql.Append("   and a.applyType = ").Append(_applyType).Append(" ");
            }
            sbSql.Append("   and a.status = ").Append(_applyStatus).Append(" ");
            sbSql.Append("   and a.deliveryDate >= '").Append(_beginTime).Append("' ");
            sbSql.Append("   and a.deliveryDate <= '").Append(_endTime).Append("' ");
            sbSql.Append(" order by a.factoryId, productId, deliveryDate ");

            return Dal.DBHelper.Select(sbSql.ToString());
        }

        public int SubmitProduceApply(Dictionary<int, string> _dcApply, Dictionary<int, object> _dcFactory, List<ModelMaterialsOutput> _listMaterialsOutput)
        {
            List<string> listSql = new List<string>();
            string modifyBy = "";

            foreach(KeyValuePair<int, object> kvp_factory in _dcFactory)
            {
                Dictionary<int, object> dcProduct = (Dictionary<int, object>)kvp_factory.Value;

                foreach (KeyValuePair<int, object> kvp_product in dcProduct)
                {
                    ModelProduce modelProduce = (ModelProduce)kvp_product.Value;

                    sbSql.Clear();
                    sbSql.Append("insert into ");
                    sbSql.Append("       p_produce ( ");
                    sbSql.Append("       produceCode, ");
                    sbSql.Append("       factoryId, ");
                    sbSql.Append("       productId, ");
                    sbSql.Append("       num, ");
                    sbSql.Append("       unit, ");
                    sbSql.Append("       deliveryDate, ");
                    sbSql.Append("       status, ");
                    sbSql.Append("       applyBy, ");
                    sbSql.Append("       applyDate, ");
                    sbSql.Append("       remark, ");
                    sbSql.Append("       isDelete, ");
                    sbSql.Append("       createBy, ");
                    sbSql.Append("       createTime ");
                    sbSql.Append("       ) values ( ");
                    sbSql.Append("      '" + modelProduce.produceCode + "', ");
                    sbSql.Append("       " + modelProduce.factoryId + ", ");
                    sbSql.Append("       " + modelProduce.productId + ", ");
                    sbSql.Append("       " + modelProduce.num + ", ");
                    sbSql.Append("       " + modelProduce.unit + ", ");
                    sbSql.Append("      '" + modelProduce.deliveryDate + "', ");
                    sbSql.Append("       " + modelProduce.status + ", ");
                    sbSql.Append("      '" + modelProduce.applyBy + "', ");
                    sbSql.Append("      '" + modelProduce.applyDate + "', ");
                    sbSql.Append("      '" + modelProduce.remark + "', ");
                    sbSql.Append("       " + modelProduce.isDelete + ", ");
                    sbSql.Append("      '" + modelProduce.createBy + "', ");
                    sbSql.Append("      '" + modelProduce.createTime + "')");
                    listSql.Add(sbSql.ToString());

                    if (StringUtils.IsBlank(modifyBy))
                    {
                        modifyBy = modelProduce.createBy;
                    }
                }
            }

            foreach (KeyValuePair<int, string> kvp in _dcApply)
            {
                sbSql.Clear();
                sbSql.Append("update p_produce_apply ");
                sbSql.Append("set status = 1,");
                sbSql.Append("    produceCode = '").Append(kvp.Value).Append("',");
                sbSql.Append("    modifyBy = '" + modifyBy + "',");
                sbSql.Append("    modifyTime = '" + DateTime.Now + "' ");
                sbSql.Append("where id = " + kvp.Key + " ");
                sbSql.Append("  and isDelete = 0 ");
                listSql.Add(sbSql.ToString());
            }

            foreach (ModelMaterialsOutput modelMaterialsOutput in _listMaterialsOutput)
            {
                sbSql.Clear();
                sbSql.Append("insert into ");
                sbSql.Append("       p_materials_output ( ");
                sbSql.Append("       outputCode, ");
                sbSql.Append("       produceCode, ");
                sbSql.Append("       factoryId, ");
                sbSql.Append("       productId, ");
                sbSql.Append("       deliveryDate, ");
                sbSql.Append("       outputStatus, ");
                sbSql.Append("       outputDate, ");
                sbSql.Append("       outputType, ");
                sbSql.Append("       applyBy, ");
                sbSql.Append("       remark, ");
                sbSql.Append("       isDelete, ");
                sbSql.Append("       createBy, ");
                sbSql.Append("       createTime ");
                sbSql.Append("       ) values ( ");
                sbSql.Append("      '" + modelMaterialsOutput.outputCode + "', ");
                sbSql.Append("      '" + modelMaterialsOutput.produceCode + "', ");
                sbSql.Append("       " + modelMaterialsOutput.factoryId + ", ");
                sbSql.Append("       " + modelMaterialsOutput.productId + ", ");
                sbSql.Append("      '" + modelMaterialsOutput.deliveryDate + "', ");
                sbSql.Append("       " + modelMaterialsOutput.outputStatus + ", ");
                sbSql.Append("      '" + modelMaterialsOutput.outputDate + "', ");
                sbSql.Append("       " + modelMaterialsOutput.outputType + ", ");
                sbSql.Append("      '" + modelMaterialsOutput.applyBy + "', ");
                sbSql.Append("      '" + modelMaterialsOutput.remark + "', ");
                sbSql.Append("       " + modelMaterialsOutput.isDelete + ", ");
                sbSql.Append("      '" + modelMaterialsOutput.createBy + "', ");
                sbSql.Append("      '" + modelMaterialsOutput.createTime + "')");
                listSql.Add(sbSql.ToString());

                foreach (ModelMaterialsOutputDetail modelMaterialsOutputDetail in modelMaterialsOutput.modelMaterialsOutputDetail)
                {
                    sbSql.Clear();
                    sbSql.Append("insert into ");
                    sbSql.Append("       r_materials_output_detail ( ");
                    sbSql.Append("       outputCode, ");
                    sbSql.Append("       materialstId, ");
                    sbSql.Append("       materialsNum, ");
                    sbSql.Append("       materialsUnit, ");
                    sbSql.Append("       outputStatus, ");
                    sbSql.Append("       outputDate, ");
                    sbSql.Append("       remark, ");
                    sbSql.Append("       isDelete, ");
                    sbSql.Append("       createBy, ");
                    sbSql.Append("       createTime ");
                    sbSql.Append("       ) values ( ");
                    sbSql.Append("      '" + modelMaterialsOutputDetail.outputCode + "', ");
                    sbSql.Append("       " + modelMaterialsOutputDetail.materialstId + ", ");
                    sbSql.Append("       " + modelMaterialsOutputDetail.materialsNum + ", ");
                    sbSql.Append("      '" + modelMaterialsOutputDetail.materialsUnit + "', ");
                    sbSql.Append("       " + modelMaterialsOutputDetail.outputStatus + ", ");
                    sbSql.Append("      '" + modelMaterialsOutputDetail.outputDate + "', ");
                    sbSql.Append("      '" + modelMaterialsOutputDetail.remark + "', ");
                    sbSql.Append("       " + modelMaterialsOutputDetail.isDelete + ", ");
                    sbSql.Append("      '" + modelMaterialsOutputDetail.createBy + "', ");
                    sbSql.Append("      '" + modelMaterialsOutputDetail.createTime + "')");
                    listSql.Add(sbSql.ToString());
                }
            }

            return Dal.DBHelper.ExcuteTransaction(listSql);

        }

        public int CancelProduceApply(List<ModelProduceApply> _listCancelApply)
        {
            List<string> listSql = new List<string>();

            foreach (ModelProduceApply modelProduceApply in _listCancelApply)
            {
                sbSql.Clear();
                sbSql.Append("update p_produce_apply ");
                sbSql.Append("set status = 2,");
                sbSql.Append("    modifyBy = '" + modelProduceApply.modifyBy + "',");
                sbSql.Append("    modifyTime = '" + modelProduceApply.modifyTime + "' ");
                sbSql.Append("where id = " + modelProduceApply.id + " ");
                sbSql.Append("  and isDelete = 0 ");
                listSql.Add(sbSql.ToString());
            }

            return Dal.DBHelper.ExcuteTransaction(listSql);
        }
    }
}
