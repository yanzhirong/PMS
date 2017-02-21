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

        public DataTable GetProduceyByProduceCode(string _produceCode)
        {
            sbSql.Clear();
            sbSql.Append("select * ");
            sbSql.Append("  from p_produce ");
            sbSql.Append(" where isDelete = 0 ");
            sbSql.Append("   and produceCode = '").Append(_produceCode).Append("' ");

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
            sbSql.Append("       a.num, ");
            sbSql.Append("       f.name customerName, ");
            sbSql.Append("       date_format(a.deliveryDate, '%Y-%m-%d') deliveryDate, ");
            sbSql.Append("       case a.status when 0 then '未确认' else '已确认' end applyStatus, ");
            sbSql.Append("       case a.applyType when 0 then '销售订单申请' else '特殊申请' end applyType, ");
            sbSql.Append("       a.applyBy applyMember, ");
            sbSql.Append("       date_format(a.applyDate, '%Y-%m-%d') applyDate, ");
            sbSql.Append("       '查看' queryStore ");
            sbSql.Append("  from p_produce_apply a ");
            sbSql.Append("  left join m_factory b ");
            sbSql.Append("         on a.factoryId = b.id ");
            sbSql.Append("  left join p_product c ");
            sbSql.Append("         on a.productId = c.id ");
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

        public int SubmitProduceApply(Dictionary<int, string> _dcApply, Dictionary<int, object> _dcFactory, Dictionary<int, object> _dcFactoryOutput)
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

            foreach (KeyValuePair<int, object> kvp_factoryOutput in _dcFactoryOutput)
            {
                Dictionary<int, ModelMaterialsOutput> dcMaterialsOutput = (Dictionary<int, ModelMaterialsOutput>)kvp_factoryOutput.Value;

                foreach (KeyValuePair<int, ModelMaterialsOutput> kvp_materialsOutput in dcMaterialsOutput)
                {
                    ModelMaterialsOutput modelMaterialsOutput = (ModelMaterialsOutput)kvp_materialsOutput.Value;

                    sbSql.Clear();
                    sbSql.Append("insert into ");
                    sbSql.Append("       p_materials_output ( ");
                    sbSql.Append("       outputCode, ");
                    sbSql.Append("       produceCode, ");
                    sbSql.Append("       factoryId, ");
                    sbSql.Append("       materialsId, ");
                    sbSql.Append("       outputNum, ");
                    sbSql.Append("       outputUnit, ");
                    sbSql.Append("       outputStatus, ");
                    sbSql.Append("       outputType, ");
                    sbSql.Append("       applyMemberId, ");
                    sbSql.Append("       applyDate, ");
                    sbSql.Append("       remark, ");
                    sbSql.Append("       isDelete, ");
                    sbSql.Append("       createBy, ");
                    sbSql.Append("       createTime ");
                    sbSql.Append("       ) values ( ");
                    sbSql.Append("      '" + modelMaterialsOutput.outputCode + "', ");
                    sbSql.Append("      '" + modelMaterialsOutput.produceCode + "', ");
                    sbSql.Append("       " + modelMaterialsOutput.factoryId + ", ");
                    sbSql.Append("       " + modelMaterialsOutput.materialsId + ", ");
                    sbSql.Append("       " + modelMaterialsOutput.outputNum + ", ");
                    sbSql.Append("       " + modelMaterialsOutput.outputUnit + ", ");
                    sbSql.Append("       " + modelMaterialsOutput.outputStatus + ", ");
                    sbSql.Append("       " + modelMaterialsOutput.outputType + ", ");
                    sbSql.Append("      '" + modelMaterialsOutput.applyMemberId + "', ");
                    sbSql.Append("      '" + modelMaterialsOutput.applyDate + "', ");
                    sbSql.Append("      '" + modelMaterialsOutput.remark + "', ");
                    sbSql.Append("       " + modelMaterialsOutput.isDelete + ", ");
                    sbSql.Append("      '" + modelMaterialsOutput.createBy + "', ");
                    sbSql.Append("      '" + modelMaterialsOutput.createTime + "')");
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

        public DataTable GetProduce(string _productName, int _factoryId, int _Status, DateTime _beginTime, DateTime _endTime)
        {
            sbSql.Clear();
            sbSql.Append("select a.id, ");
            sbSql.Append("       a.produceCode, ");
            sbSql.Append("       a.factoryId, ");
            sbSql.Append("       b.name factoryName, ");
            sbSql.Append("       a.productId, ");
            sbSql.Append("       c.name productName, ");
            sbSql.Append("       a.num, ");
            sbSql.Append("       date_format(a.deliveryDate, '%Y-%m-%d') deliveryDate, ");
            sbSql.Append("       e.value1 status, ");
            sbSql.Append("       '编辑' modifyBtn, ");
            sbSql.Append("       '删除' deleteBtn, ");
            sbSql.Append("       '查看' queryStore, ");
            sbSql.Append("       a.status statusCode ");
            sbSql.Append("  from p_produce a ");
            sbSql.Append("  left join m_factory b ");
            sbSql.Append("         on a.factoryId = b.id ");
            sbSql.Append("  left join p_product c ");
            sbSql.Append("         on a.productId = c.id ");
            sbSql.Append("  left join m_code e ");
            sbSql.Append("         on a.status = e.subCode ");
            sbSql.Append("        and e.code = 11 ");
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
            if (_Status > -1)
            {
                sbSql.Append("   and a.status = ").Append(_Status).Append(" ");
            }
            sbSql.Append("   and a.deliveryDate >= '").Append(_beginTime).Append("' ");
            sbSql.Append("   and a.deliveryDate <= '").Append(_endTime).Append("' ");
            sbSql.Append(" order by a.factoryId, productId, deliveryDate ");

            return Dal.DBHelper.Select(sbSql.ToString());
        }

        public DataTable GetProduceById(int _produceId)
        {
            sbSql.Clear();
            sbSql.Append("select * ");
            sbSql.Append("  from p_produce ");
            sbSql.Append(" where isDelete = 0 ");
            sbSql.Append("   and id = ").Append(_produceId).Append(" ");

            return Dal.DBHelper.Select(sbSql.ToString());
        }


        public int AddProduce(ModelProduce _modelProduce, ModelProductIn _modelProductIn)
        {
            List<string> listSql = new List<string>();

            sbSql.Clear();
            sbSql.Append("insert into ");
            sbSql.Append("       p_produce ( ");
            sbSql.Append("       produceCode, ");
            sbSql.Append("       factoryId, ");
            sbSql.Append("       productId, ");
            sbSql.Append("       num, ");
            sbSql.Append("       deliveryDate, ");
            sbSql.Append("       status, ");
            sbSql.Append("       applyBy, ");
            sbSql.Append("       applyDate, ");
            sbSql.Append("       remark, ");
            sbSql.Append("       isDelete, ");
            sbSql.Append("       createBy, ");
            sbSql.Append("       createTime ");
            sbSql.Append("       ) values ( ");
            sbSql.Append("      '" + _modelProduce.produceCode + "', ");
            sbSql.Append("       " + _modelProduce.factoryId + ", ");
            sbSql.Append("       " + _modelProduce.productId + ", ");
            sbSql.Append("       " + _modelProduce.num + ", ");
            sbSql.Append("      '" + _modelProduce.deliveryDate + "', ");
            sbSql.Append("       " + _modelProduce.status + ", ");
            sbSql.Append("      '" + _modelProduce.applyBy + "', ");
            sbSql.Append("      '" + _modelProduce.applyDate + "', ");
            sbSql.Append("      '" + _modelProduce.remark + "', ");
            sbSql.Append("       " + _modelProduce.isDelete + ", ");
            sbSql.Append("      '" + _modelProduce.createBy + "', ");
            sbSql.Append("      '" + _modelProduce.createTime + "')");

            listSql.Add(sbSql.ToString());

            if (_modelProductIn != null)
            {
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
                sbSql.Append("       remark, ");
                sbSql.Append("       isDelete, ");
                sbSql.Append("       createBy, ");
                sbSql.Append("       createTime ");
                sbSql.Append("       ) values ( ");
                sbSql.Append("      '" + _modelProductIn.produceCode + "', ");
                sbSql.Append("       " + _modelProductIn.factoryId + ", ");
                sbSql.Append("       " + _modelProductIn.productId + ", ");
                sbSql.Append("       " + _modelProductIn.inputNum + ", ");
                sbSql.Append("       " + _modelProductIn.stockNum + ", ");
                sbSql.Append("      '" + _modelProductIn.produceDate + "', ");
                sbSql.Append("      '" + _modelProductIn.expiresDate + "', ");
                sbSql.Append("      '" + _modelProductIn.produceCode + "', ");
                sbSql.Append("       " + _modelProductIn.inputType + ", ");
                sbSql.Append("       " + _modelProductIn.inputStatus + ", ");
                sbSql.Append("      '" + _modelProductIn.remark + "', ");
                sbSql.Append("       " + _modelProductIn.isDelete + ", ");
                sbSql.Append("      '" + _modelProductIn.createBy + "', ");
                sbSql.Append("      '" + _modelProductIn.createTime + "')");

                listSql.Add(sbSql.ToString());
            }
            return Dal.DBHelper.ExcuteTransaction(listSql);
        }

        public int UpdateProduce(ModelProduce _model, ModelProductIn _modelProductIn)
        {
            List<string> listSql = new List<string>();

            sbSql.Clear();
            sbSql.Append("update p_produce ");
            sbSql.Append("set factoryId = " + _model.factoryId + ", ");
            sbSql.Append("    productId = " + _model.productId + ", ");
            sbSql.Append("    num = " + _model.num + ", ");
            sbSql.Append("    deliveryDate = '" + _model.deliveryDate + "', ");
            sbSql.Append("    status = " + _model.status + ", ");
            sbSql.Append("    applyBy = '" + _model.applyBy + "', ");
            sbSql.Append("    applyDate = '" + _model.applyDate + "',");
            sbSql.Append("    remark = '" + _model.remark + "',");
            sbSql.Append("    modifyBy = '" + _model.modifyBy + "',");
            sbSql.Append("    modifyTime = '" + _model.modifyTime + "' ");
            sbSql.Append("where id = " + _model.id + " ");
            sbSql.Append("  and isDelete = 0 ");
            listSql.Add(sbSql.ToString());

            if (_modelProductIn != null)
            {
                sbSql.Clear();
                sbSql.Append("update p_product_input ");
                sbSql.Append("set isDelete = 1, ");
                sbSql.Append("    modifyBy = '" + _model.modifyBy + "',");
                sbSql.Append("    modifyTime = '" + _model.modifyTime + "' ");
                sbSql.Append("where produceCode = '" + _modelProductIn.produceCode + "' ");
                sbSql.Append("  and isDelete = 0 ");
                listSql.Add(sbSql.ToString());
              
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
                sbSql.Append("       remark, ");
                sbSql.Append("       isDelete, ");
                sbSql.Append("       createBy, ");
                sbSql.Append("       createTime ");
                sbSql.Append("       ) values ( ");
                sbSql.Append("      '" + _modelProductIn.produceCode + "', ");
                sbSql.Append("       " + _modelProductIn.factoryId + ", ");
                sbSql.Append("       " + _modelProductIn.productId + ", ");
                sbSql.Append("       " + _modelProductIn.inputNum + ", ");
                sbSql.Append("       " + _modelProductIn.stockNum + ", ");
                sbSql.Append("      '" + _modelProductIn.produceDate + "', ");
                sbSql.Append("      '" + _modelProductIn.expiresDate + "', ");
                sbSql.Append("      '" + _modelProductIn.produceCode + "', ");
                sbSql.Append("       " + _modelProductIn.inputType + ", ");
                sbSql.Append("       " + _modelProductIn.inputStatus + ", ");
                sbSql.Append("      '" + _modelProductIn.remark + "', ");
                sbSql.Append("       " + _modelProductIn.isDelete + ", ");
                sbSql.Append("      '" + _modelProductIn.createBy + "', ");
                sbSql.Append("      '" + _modelProductIn.createTime + "')");

                listSql.Add(sbSql.ToString());
            }
            return Dal.DBHelper.ExcuteTransaction(listSql);
        }

        public int DeleteProduce(ModelProduce _model)
        {
            sbSql.Clear();
            sbSql.Append("update p_produce ");
            sbSql.Append("set isDelete = 1, ");
            sbSql.Append("    remark = '" + _model.remark + "',");
            sbSql.Append("    modifyBy = '" + _model.modifyBy + "',");
            sbSql.Append("    modifyTime = '" + _model.modifyTime + "' ");
            sbSql.Append("where id = " + _model.id + " ");
            sbSql.Append("  and isDelete = 0 ");

            return Dal.DBHelper.Excute(sbSql.ToString());
        }
    }
}
