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

        public DataTable GetPurchaseApply(string _materialsName, int _factoryId, int _applyStatus, DateTime _beginTime, DateTime _endTime)
        {
            sbSql.Clear();
            sbSql.Append("select a.id, ");
            sbSql.Append("       a.factoryId, ");
            sbSql.Append("       b.name factoryName, ");
            sbSql.Append("       a.materialsId, ");
            sbSql.Append("       c.name materialsName, ");
            sbSql.Append("       concat(a.num, d.value1) numDisplay, ");
            sbSql.Append("       a.produceCode , ");
            sbSql.Append("       date_format(a.deliveryDate, '%Y-%m-%d') deliveryDate, ");
            sbSql.Append("       case a.status when 0 then '未确认' else '已确认' end applyStatus, ");
            sbSql.Append("       a.applyBy applyMember, ");
            sbSql.Append("       date_format(a.applyDate, '%Y-%m-%d') applyDate, ");
            sbSql.Append("       '查看' queryStore, ");
            sbSql.Append("       a.num, ");
            sbSql.Append("       a.unit ");
            sbSql.Append("  from p_purchase_apply a ");
            sbSql.Append("  left join m_factory b ");
            sbSql.Append("         on a.factoryId = b.id ");
            sbSql.Append("  left join p_materials c ");
            sbSql.Append("         on a.materialsId = c.id ");
            sbSql.Append("  left join m_code d ");
            sbSql.Append("         on a.unit = d.subCode ");
            sbSql.Append("        and d.code = 3 ");
            sbSql.Append(" where a.isDelete = 0 ");
            if (Common.Tools.StringUtils.IsNotBlank(_materialsName))
            {
                sbSql.Append("   and a.materialsId in (");
                sbSql.Append("                     select materialsId ");
                sbSql.Append("                       from r_materials_search ");
                sbSql.Append("                      where materialsName like '%").Append(_materialsName).Append("%' or upper(searchKey) like '%").Append(_materialsName.ToUpper()).Append("%') ");
            }
            if (_factoryId > 0)
            {
                sbSql.Append("   and a.factoryId = ").Append(_factoryId).Append(" ");
            }
            sbSql.Append("   and a.status = ").Append(_applyStatus).Append(" ");
            sbSql.Append("   and a.deliveryDate >= '").Append(_beginTime).Append("' ");
            sbSql.Append("   and a.deliveryDate <= '").Append(_endTime).Append("' ");
            sbSql.Append(" order by a.factoryId, materialsId, deliveryDate ");

            return Dal.DBHelper.Select(sbSql.ToString());
        }

        public DataTable GetPurchase(string _materialsName, int _factoryId, DateTime _beginTime, DateTime _endTime, int _status, int _type)
        {
            sbSql.Clear();
            sbSql.Append("select a.id, ");
            sbSql.Append("       a.factoryId, ");
            sbSql.Append("       b.name factoryName, ");
            sbSql.Append("       a.materialsId, ");
            sbSql.Append("       c.name materialsName, ");
            sbSql.Append("       concat(a.num, d.value1) numDisplay, ");
            sbSql.Append("       a.produceCode , ");
            sbSql.Append("       date_format(a.deliveryDate, '%Y-%m-%d') deliveryDate, ");
            sbSql.Append("       e.value1 status, ");
            sbSql.Append("       a.applyBy applyMember, ");
            sbSql.Append("       case a.status when 3 then '查看' else '编辑' end modifyBtn, ");
            sbSql.Append("       '删除' deleteBtn, ");
            sbSql.Append("       '查看库存' queryStore, ");
            sbSql.Append("       a.status statusCode, ");
            sbSql.Append("       a.num, ");
            sbSql.Append("       a.unit ");
            sbSql.Append("  from p_purchase a ");
            sbSql.Append("  left join m_factory b ");
            sbSql.Append("         on a.factoryId = b.id ");
            sbSql.Append("  left join p_materials c ");
            sbSql.Append("         on a.materialsId = c.id ");
            sbSql.Append("  left join m_code d ");
            sbSql.Append("         on a.unit = d.subCode ");
            sbSql.Append("        and d.code = 3 ");
            sbSql.Append("  left join m_code e ");
            sbSql.Append("         on a.status = e.subCode ");
            sbSql.Append("        and e.code = 12 ");
            sbSql.Append(" where a.isDelete = 0 ");
            if (Common.Tools.StringUtils.IsNotBlank(_materialsName))
            {
                sbSql.Append("   and a.materialsId in (");
                sbSql.Append("                     select materialsId ");
                sbSql.Append("                       from r_materials_search ");
                sbSql.Append("                      where materialsName like '%").Append(_materialsName).Append("%' or upper(searchKey) like '%").Append(_materialsName.ToUpper()).Append("%') ");
            }
            if (_factoryId > 0)
            {
                sbSql.Append("   and a.factoryId = ").Append(_factoryId).Append(" ");
            }
            if (_status > -1)
            {
                sbSql.Append("   and a.status = ").Append(_status).Append(" ");
            }
            if (_type > -1)
            {
                sbSql.Append("   and a.applyType = ").Append(_type).Append(" ");
            } 
            sbSql.Append("   and a.deliveryDate >= '").Append(_beginTime).Append("' ");
            sbSql.Append("   and a.deliveryDate <= '").Append(_endTime).Append("' ");
            sbSql.Append(" order by a.factoryId, materialsId, deliveryDate ");

            return Dal.DBHelper.Select(sbSql.ToString());
        }
       
        public int SubmitPurchaseApply(Dictionary<int, string> _dcApply, Dictionary<int, object> _dcFactory)
        {
            List<string> listSql = new List<string>();
            string modifyBy = "";

            foreach (KeyValuePair<int, object> kvp_factory in _dcFactory)
            {
                Dictionary<int, object> dcPurchase = (Dictionary<int, object>)kvp_factory.Value;

                foreach (KeyValuePair<int, object> kvp_purchase in dcPurchase)
                {
                    ModelPurchase modelPurchase = (ModelPurchase)kvp_purchase.Value;

                    sbSql.Clear();
                    sbSql.Append("insert into ");
                    sbSql.Append("       p_purchase ( ");
                    sbSql.Append("       purchaseCode, ");
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
                    sbSql.Append("      '" + modelPurchase.purchaseCode + "', ");
                    sbSql.Append("       " + modelPurchase.factoryId + ", ");
                    sbSql.Append("       " + modelPurchase.materialsId + ", ");
                    sbSql.Append("       " + modelPurchase.num + ", ");
                    sbSql.Append("       " + modelPurchase.unit + ", ");
                    sbSql.Append("      '" + modelPurchase.produceCode + "', ");
                    sbSql.Append("      '" + modelPurchase.deliveryDate + "', ");
                    sbSql.Append("       " + modelPurchase.applyType + ", ");
                    sbSql.Append("      '" + modelPurchase.applyBy + "', ");
                    sbSql.Append("      '" + modelPurchase.applyDate + "', ");
                    sbSql.Append("       " + modelPurchase.status + ", ");
                    sbSql.Append("      '" + modelPurchase.remark + "', ");
                    sbSql.Append("       " + modelPurchase.isDelete + ", ");
                    sbSql.Append("      '" + modelPurchase.createBy + "', ");
                    sbSql.Append("      '" + modelPurchase.createTime + "')");
                    listSql.Add(sbSql.ToString());

                    if (StringUtils.IsBlank(modifyBy))
                    {
                        modifyBy = modelPurchase.createBy;
                    }
                }
            }

            foreach (KeyValuePair<int, string> kvp in _dcApply)
            {
                sbSql.Clear();
                sbSql.Append("update p_purchase_apply ");
                sbSql.Append("set status = 1,");
                sbSql.Append("    purchaseCode = '").Append(kvp.Value).Append("',");
                sbSql.Append("    modifyBy = '" + modifyBy + "',");
                sbSql.Append("    modifyTime = '" + DateTime.Now + "' ");
                sbSql.Append("where id = " + kvp.Key + " ");
                sbSql.Append("  and isDelete = 0 ");
                listSql.Add(sbSql.ToString());
            }

            return Dal.DBHelper.ExcuteTransaction(listSql);
        }

        public int CancelProduceApply(List<ModelPurchaseApply> _listCancelApply)
        {
            List<string> listSql = new List<string>();

            foreach (ModelPurchaseApply modelPurchaseApply in _listCancelApply)
            {
                sbSql.Clear();
                sbSql.Append("update p_purchase_apply ");
                sbSql.Append("set status = 2,");
                sbSql.Append("    modifyBy = '" + modelPurchaseApply.modifyBy + "',");
                sbSql.Append("    modifyTime = '" + modelPurchaseApply.modifyTime + "' ");
                sbSql.Append("where id = " + modelPurchaseApply.id + " ");
                sbSql.Append("  and isDelete = 0 ");
                listSql.Add(sbSql.ToString());
            }

            return Dal.DBHelper.ExcuteTransaction(listSql);
        }

        public DataTable GetPurchaseById(int _purchaseId)
        {
            sbSql.Clear();
            sbSql.Append("select a.* ");
            sbSql.Append("  from p_purchase a ");
            sbSql.Append(" where a.isDelete = 0 ");
            sbSql.Append("   and a.id = ").Append(_purchaseId).Append(" ");

            return Dal.DBHelper.Select(sbSql.ToString());
        }

        public DataTable GetPurchaseByPurchaseCode(string _purchaseCode)
        {
            sbSql.Clear();
            sbSql.Append("select a.* ");
            sbSql.Append("  from p_purchase a ");
            sbSql.Append(" where a.isDelete = 0 ");
            sbSql.Append("   and a.purchaseCode = '").Append(_purchaseCode).Append("' ");

            return Dal.DBHelper.Select(sbSql.ToString());
        }

        public DataTable GetCompleteInByPurchaseCode(string _purchaseCode)
        {
            sbSql.Clear();
            sbSql.Append("select a.* ");
            sbSql.Append("  from p_materials_in a ");
            sbSql.Append(" where a.isDelete = 0 ");
            sbSql.Append("   and a.status = 1 ");
            sbSql.Append("   and a.purchaseCode = '").Append(_purchaseCode).Append("' ");

            return Dal.DBHelper.Select(sbSql.ToString());
        }

        public DataTable GetPaidByPurchaseCode(string _purchaseCode)
        {
            sbSql.Clear();
            sbSql.Append("select a.* ");
            sbSql.Append("  from p_finance_paid a ");
            sbSql.Append(" where a.isDelete = 0 ");
            sbSql.Append("   and a.paidStatus > 0 ");
            sbSql.Append("   and a.purchaseCode = '").Append(_purchaseCode).Append("' ");

            return Dal.DBHelper.Select(sbSql.ToString());
        }

        public int AddPurchase(ModelPurchase _model)
        {
            List<string> listSql = new List<string>();

            sbSql.Clear();
            sbSql.Append("insert into ");
            sbSql.Append("       p_purchase ( ");
            sbSql.Append("       purchaseCode, ");
            sbSql.Append("       factoryId, ");
            sbSql.Append("       materialsId, ");
            sbSql.Append("       num, ");
            sbSql.Append("       unit, ");
            sbSql.Append("       deliveryDate, ");
            sbSql.Append("       status, ");
            sbSql.Append("       produceCode, ");
            sbSql.Append("       applyType, ");
            sbSql.Append("       applyBy, ");
            sbSql.Append("       applyDate, ");
            sbSql.Append("       customerId, ");
            sbSql.Append("       country, ");
            sbSql.Append("       province, ");
            sbSql.Append("       provinceName, ");
            sbSql.Append("       city, ");
            sbSql.Append("       cityName, ");
            sbSql.Append("       district, ");
            sbSql.Append("       districtName, ");
            sbSql.Append("       address, ");
            sbSql.Append("       manager, ");
            sbSql.Append("       telephone, ");
            sbSql.Append("       price, ");
            sbSql.Append("       remark, ");
            sbSql.Append("       isDelete, ");
            sbSql.Append("       createBy, ");
            sbSql.Append("       createTime");
            sbSql.Append("       ) value ( ");
            sbSql.Append("      '" + _model.purchaseCode + "', ");
            sbSql.Append("       " + _model.factoryId + ", ");
            sbSql.Append("       " + _model.materialsId + ", ");
            sbSql.Append("       " + _model.num + ", ");
            sbSql.Append("       " + _model.unit + ", ");
            sbSql.Append("      '" + _model.deliveryDate + "', ");
            sbSql.Append("       " + _model.status + ", ");
            sbSql.Append("      '" + _model.produceCode + "', ");
            sbSql.Append("       " + _model.applyType + ", ");
            sbSql.Append("      '" + _model.applyBy + "', ");
            sbSql.Append("      '" + _model.applyDate + "', ");
            sbSql.Append("       " + _model.customerId + ", ");
            sbSql.Append("       " + _model.country + ", ");
            sbSql.Append("       " + _model.province + ", ");
            sbSql.Append("      '" + _model.provinceName + "', ");
            sbSql.Append("       " + _model.city + ", ");
            sbSql.Append("      '" + _model.cityName + "', ");
            sbSql.Append("       " + _model.district + ", ");
            sbSql.Append("      '" + _model.districtName + "', ");
            sbSql.Append("      '" + _model.address + "', ");
            sbSql.Append("      '" + _model.manager + "', ");
            sbSql.Append("      '" + _model.telephone + "', ");
            sbSql.Append("       " + _model.price + ", ");
            sbSql.Append("      '" + _model.remark + "', ");
            sbSql.Append("       " + _model.isDelete + ", ");
            sbSql.Append("      '" + _model.createBy + "', ");
            sbSql.Append("      '" + _model.createTime + "')");
            listSql.Add(sbSql.ToString());

            if(_model.status == (int)Enum.EnumPurchaseOrderStatus.Purchasing)
            {
                sbSql.Clear();
                sbSql.Append("insert into ");
                sbSql.Append("       p_materials_in ( ");
                sbSql.Append("       purchaseCode, ");
                sbSql.Append("       factoryId, ");
                sbSql.Append("       materialsId, ");
                sbSql.Append("       num, ");
                sbSql.Append("       unit, ");
                sbSql.Append("       produceCode, ");
                sbSql.Append("       status, ");
                sbSql.Append("       isDelete, ");
                sbSql.Append("       createBy, ");
                sbSql.Append("       createTime");
                sbSql.Append("       ) value ( ");
                sbSql.Append("      '" + _model.purchaseCode + "', ");
                sbSql.Append("       " + _model.factoryId + ", ");
                sbSql.Append("       " + _model.materialsId + ", ");
                sbSql.Append("       " + _model.num + ", ");
                sbSql.Append("       " + _model.unit + ", ");
                sbSql.Append("      '" + _model.produceCode + "', ");
                sbSql.Append("       0, ");
                sbSql.Append("       " + _model.isDelete + ", ");
                sbSql.Append("      '" + _model.createBy + "', ");
                sbSql.Append("      '" + _model.createTime + "')");
                listSql.Add(sbSql.ToString());

                sbSql.Clear();
                sbSql.Append("insert into ");
                sbSql.Append("       p_finance_paid ( ");
                sbSql.Append("       purchaseCode, ");
                sbSql.Append("       factoryId, ");
                sbSql.Append("       materialsId, ");
                sbSql.Append("       num, ");
                sbSql.Append("       unit, ");
                sbSql.Append("       orderPrice, ");
                sbSql.Append("       purchaseBy, ");
                sbSql.Append("       purchaseDate, ");
                sbSql.Append("       customerId, ");
                sbSql.Append("       isDelete, ");
                sbSql.Append("       createBy, ");
                sbSql.Append("       createTime");
                sbSql.Append("       ) value ( ");
                sbSql.Append("      '" + _model.purchaseCode + "', ");
                sbSql.Append("       " + _model.factoryId + ", ");
                sbSql.Append("       " + _model.materialsId + ", ");
                sbSql.Append("       " + _model.num + ", ");
                sbSql.Append("       " + _model.unit + ", ");
                sbSql.Append("       " + _model.price + ", ");
                sbSql.Append("      '" + _model.modifyBy + "', ");
                sbSql.Append("      '" + _model.modifyTime + "', ");
                sbSql.Append("       " + _model.customerId + ", ");
                sbSql.Append("       " + _model.isDelete + ", ");
                sbSql.Append("      '" + _model.createBy + "', ");
                sbSql.Append("      '" + _model.createTime + "')");
                listSql.Add(sbSql.ToString());
            }

            return Dal.DBHelper.ExcuteTransaction(listSql);
        }

        public int UpdatePurchase(ModelPurchase _model)
        {
            List<string> listSql = new List<string>();

            sbSql.Clear();
            sbSql.Append("update p_purchase ");
            sbSql.Append("set factoryId = " + _model.factoryId + ", "); ;
            sbSql.Append("    materialsId = " + _model.materialsId + ",");
            sbSql.Append("    num = " + _model.num + ",");
            sbSql.Append("    unit = " + _model.unit + ",");
            sbSql.Append("    deliveryDate = '" + _model.deliveryDate + "',");
            sbSql.Append("    status = " + _model.status + ",");
            sbSql.Append("    applyType = " + _model.applyType + ",");
            sbSql.Append("    applyBy = '" + _model.applyBy + "',");
            sbSql.Append("    applyDate = '" + _model.applyDate + "',");
            sbSql.Append("    customerId = " + _model.customerId + ",");
            sbSql.Append("    country = " + _model.country + ",");
            sbSql.Append("    province = " + _model.province + ",");
            sbSql.Append("    provinceName = '" + _model.provinceName + "',");
            sbSql.Append("    cityName = '" + _model.cityName + "',");
            sbSql.Append("    district = " + _model.district + ",");
            sbSql.Append("    districtName = '" + _model.districtName + "',");
            sbSql.Append("    address = '" + _model.address + "',");
            sbSql.Append("    manager = '" + _model.manager + "',");
            sbSql.Append("    telephone = '" + _model.telephone + "',");
            sbSql.Append("    price = " + _model.price + ",");
            sbSql.Append("    remark = '" + _model.remark + "',");
            sbSql.Append("    modifyBy = '" + _model.modifyBy + "',");
            sbSql.Append("    modifyTime = '" + _model.modifyTime + "' ");
            sbSql.Append("where id = " + _model.id);
            listSql.Add(sbSql.ToString());

            sbSql.Clear();
            sbSql.Append("update p_materials_in ");
            sbSql.Append("set isDelete = 1,");
            sbSql.Append("    modifyBy = '" + _model.modifyBy + "',");
            sbSql.Append("    modifyTime = '" + _model.modifyTime + "' ");
            sbSql.Append("where isDelete = 0");
            sbSql.Append("  and status = 0 ");
            sbSql.Append("  and purchaseCode = '").Append(_model.purchaseCode).Append("' ");
            listSql.Add(sbSql.ToString());

            sbSql.Clear();
            sbSql.Append("update p_finance_paid ");
            sbSql.Append("set isDelete = 1,");
            sbSql.Append("    modifyBy = '" + _model.modifyBy + "',");
            sbSql.Append("    modifyTime = '" + _model.modifyTime + "' ");
            sbSql.Append("where isDelete = 0");
            sbSql.Append("  and paidStatus = 0 ");
            sbSql.Append("  and purchaseCode = '").Append(_model.purchaseCode).Append("' ");
            listSql.Add(sbSql.ToString());

            if (_model.status == (int)Enum.EnumPurchaseOrderStatus.Purchasing)
            {
                sbSql.Clear();
                sbSql.Append("insert into ");
                sbSql.Append("       p_materials_in ( ");
                sbSql.Append("       purchaseCode, ");
                sbSql.Append("       factoryId, ");
                sbSql.Append("       materialsId, ");
                sbSql.Append("       num, ");
                sbSql.Append("       unit, ");
                sbSql.Append("       produceCode, ");
                sbSql.Append("       status, ");
                sbSql.Append("       isDelete, ");
                sbSql.Append("       createBy, ");
                sbSql.Append("       createTime");
                sbSql.Append("       ) value ( ");
                sbSql.Append("      '" + _model.purchaseCode + "', ");
                sbSql.Append("       " + _model.factoryId + ", ");
                sbSql.Append("       " + _model.materialsId + ", ");
                sbSql.Append("       " + _model.num + ", ");
                sbSql.Append("       " + _model.unit + ", ");
                sbSql.Append("      '" + _model.produceCode + "', ");
                sbSql.Append("       0, ");
                sbSql.Append("       " + _model.isDelete + ", ");
                sbSql.Append("      '" + _model.createBy + "', ");
                sbSql.Append("      '" + _model.createTime + "')");
                listSql.Add(sbSql.ToString());

                sbSql.Clear();
                sbSql.Clear();
                sbSql.Append("insert into ");
                sbSql.Append("       p_finance_paid ( ");
                sbSql.Append("       purchaseCode, ");
                sbSql.Append("       factoryId, ");
                sbSql.Append("       materialsId, ");
                sbSql.Append("       num, ");
                sbSql.Append("       unit, ");
                sbSql.Append("       orderPrice, ");
                sbSql.Append("       purchaseBy, ");
                sbSql.Append("       purchaseDate, ");
                sbSql.Append("       customerId, ");
                sbSql.Append("       isDelete, ");
                sbSql.Append("       createBy, ");
                sbSql.Append("       createTime");
                sbSql.Append("       ) value ( ");
                sbSql.Append("      '" + _model.purchaseCode + "', ");
                sbSql.Append("       " + _model.factoryId + ", ");
                sbSql.Append("       " + _model.materialsId + ", ");
                sbSql.Append("       " + _model.num + ", ");
                sbSql.Append("       " + _model.unit + ", ");
                sbSql.Append("       " + _model.price + ", ");
                sbSql.Append("      '" + _model.modifyBy + "', ");
                sbSql.Append("      '" + _model.modifyTime + "', ");
                sbSql.Append("       " + _model.customerId + ", ");
                sbSql.Append("       " + _model.isDelete + ", ");
                sbSql.Append("      '" + _model.createBy + "', ");
                sbSql.Append("      '" + _model.createTime + "')");
                listSql.Add(sbSql.ToString());
            }
            return Dal.DBHelper.ExcuteTransaction(listSql);
        }

        public int DeletePurchase(ModelPurchase _model)
        {
            List<string> listSql = new List<string>();

            sbSql.Clear();
            sbSql.Append("update p_purchase ");
            sbSql.Append("set isDelete = 1,");
            sbSql.Append("    modifyBy = '" + _model.modifyBy + "',");
            sbSql.Append("    modifyTime = '" + _model.modifyTime + "' ");
            sbSql.Append("where id = " + _model.id);
            listSql.Add(sbSql.ToString());

            sbSql.Clear();
            sbSql.Append("update p_materials_in ");
            sbSql.Append("set isDelete = 1,");
            sbSql.Append("    modifyBy = '" + _model.modifyBy + "',");
            sbSql.Append("    modifyTime = '" + _model.modifyTime + "' ");
            sbSql.Append("where isDelete = 0");
            sbSql.Append("  and status = 0 ");
            sbSql.Append("  and purchaseCode = '").Append(_model.purchaseCode).Append("' ");
            listSql.Add(sbSql.ToString());

            sbSql.Clear();
            sbSql.Append("update p_finance_paid ");
            sbSql.Append("set isDelete = 1,");
            sbSql.Append("    modifyBy = '" + _model.modifyBy + "',");
            sbSql.Append("    modifyTime = '" + _model.modifyTime + "' ");
            sbSql.Append("where isDelete = 0");
            sbSql.Append("  and paidStatus = 0 ");
            sbSql.Append("  and purchaseCode = '").Append(_model.purchaseCode).Append("' ");
            listSql.Add(sbSql.ToString());

            return Dal.DBHelper.ExcuteTransaction(listSql);
        }
    }
}
