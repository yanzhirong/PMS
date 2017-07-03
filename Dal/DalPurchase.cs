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

        public DataTable GetPurchaseApply(string _materialsName, int _factoryId, DateTime _beginTime, DateTime _endTime)
        {
            sbSql.Clear();
            sbSql.Append("select a.id, ");
            sbSql.Append("       a.factoryId, ");
            sbSql.Append("       b.name factoryName, ");
            sbSql.Append("       a.materialsId, ");
            sbSql.Append("       c.name materialsName, ");
            sbSql.Append("       a.num requestNum, ");
            sbSql.Append("       case c.type when 2 then concat(cast(a.num as signed integer), '件') else concat(cast(a.num as signed integer), '克') end numDisplay, ");
            sbSql.Append("       a.produceCode , ");
            sbSql.Append("       date_format(a.deliveryDate, '%Y-%m-%d') deliveryDate, ");
            sbSql.Append("       a.applyBy applyMember, ");
            sbSql.Append("       date_format(a.applyDate, '%Y-%m-%d') applyDate, ");
            sbSql.Append("       '查看' queryStore ");
            sbSql.Append("  from p_purchase_apply a ");
            sbSql.Append("  left join m_factory b ");
            sbSql.Append("         on a.factoryId = b.id ");
            sbSql.Append("  left join p_materials c ");
            sbSql.Append("         on a.materialsId = c.id ");
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
            sbSql.Append("   and a.status = 0 ");
            sbSql.Append("   and a.deliveryDate >= '").Append(_beginTime).Append("' ");
            sbSql.Append("   and a.deliveryDate <= '").Append(_endTime).Append("' ");
            sbSql.Append(" order by a.factoryId, materialsId, deliveryDate ");

            return Dal.DBHelper.Select(sbSql.ToString());
        }

        public DataTable GetPurchaseApplyByProcudeCodeAndMaterialsId(string _produceCode, int _materialsId)
        {
            sbSql.Clear();
            sbSql.Append("select a.* ");
            sbSql.Append("  from p_purchase_apply a ");
            sbSql.Append(" where a.isDelete = 0 ");
            sbSql.Append("   and a.produceCode = '").Append(_produceCode).Append("' ");
            sbSql.Append("   and a.materialsId = ").Append(_materialsId).Append(" ");

            return Dal.DBHelper.Select(sbSql.ToString());
        }


        public DataTable GetPurchase(string _materialsName, int _factoryId, DateTime _beginTime, DateTime _endTime, int _status, int _type)
        {
            sbSql.Clear();
            sbSql.Append("select distinct ");
            sbSql.Append("       a.id, ");
            sbSql.Append("       a.factoryId, ");
            sbSql.Append("       b.name factoryName, ");
            sbSql.Append("       c.name customerName, ");
            sbSql.Append("       a.purchaseCode , ");
            sbSql.Append("       a.price orderPrice , ");
            sbSql.Append("       date_format(a.deliveryDate, '%Y-%m-%d') deliveryDate, ");
            sbSql.Append("       d.value1 status, ");
            sbSql.Append("       case a.status when " + (int)Enum.EnumPurchaseOrderStatus.Complete + " then '查看' when " + (int)Enum.EnumPurchaseOrderStatus.Cancel + " then '查看' else '编辑' end modifyBtn, ");
            sbSql.Append("       case a.status when " + (int)Enum.EnumPurchaseOrderStatus.Complete + " then '查看' when " + (int)Enum.EnumPurchaseOrderStatus.Cancel + " then '查看' else '取消' end deleteBtn, ");
            sbSql.Append("       a.status statusCode ");
            sbSql.Append("  from p_purchase a ");
            sbSql.Append("  left join m_factory b ");
            sbSql.Append("         on a.factoryId = b.id ");
            sbSql.Append("  join p_customer c ");
            sbSql.Append("         on a.customerId = c.id ");
            sbSql.Append("  left join m_code d ");
            sbSql.Append("         on a.status = d.subCode ");
            sbSql.Append("        and d.code = 12 ");
            sbSql.Append("  left join r_purchase_detail e ");
            sbSql.Append("         on a.purchaseCode = e.purchaseCode ");
            sbSql.Append("        and e.isDelete = 0 ");
            sbSql.Append(" where a.isDelete = 0 ");
            if (Common.Tools.StringUtils.IsNotBlank(_materialsName))
            {
                sbSql.Append("   and e.materialsId in (");
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
                sbSql.Append("   and e.applyType = ").Append(_type).Append(" ");
            }
            sbSql.Append("   and a.deliveryDate >= '").Append(_beginTime).Append("' ");
            sbSql.Append("   and a.deliveryDate <= '").Append(_endTime).Append("' ");
            sbSql.Append(" order by a.factoryId, a.deliveryDate ");

            return Dal.DBHelper.Select(sbSql.ToString());
        }

        public DataTable GetPurchaseDetailByPurchaseCode(string _purchaseCode)
        {
            sbSql.Clear();
            sbSql.Append("select a.id, ");
            sbSql.Append("       a.materialsId, ");
            sbSql.Append("       b.name materialsName, ");
            sbSql.Append("       a.specsId specs, ");
            sbSql.Append("       a.num, ");
            sbSql.Append("       a.price, ");
            sbSql.Append("       a.produceCode, ");
            sbSql.Append("       a.deliveryDate, ");
            sbSql.Append("       a.applyType, ");
            sbSql.Append("       a.applyBy, ");
            sbSql.Append("       a.applyDate ");
            sbSql.Append("  from r_purchase_detail a ");
            sbSql.Append("  left join p_materials b ");
            sbSql.Append("    on a.materialsId = b.id ");
            sbSql.Append(" where a.isDelete = 0 ");
            sbSql.Append("   and a.purchaseCode ='" + _purchaseCode + "'");

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
                    sbSql.Append("       customerId, ");
                    sbSql.Append("       deliveryDate, ");
                    sbSql.Append("       status, ");
                    sbSql.Append("       price, ");
                    sbSql.Append("       payType, ");
                    sbSql.Append("       purchaserId, ");
                    sbSql.Append("       purchaseDate, ");
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
                    sbSql.Append("       remark, ");
                    sbSql.Append("       isDelete, ");
                    sbSql.Append("       createBy, ");
                    sbSql.Append("       createTime");
                    sbSql.Append("       ) value ( ");
                    sbSql.Append("      '" + modelPurchase.purchaseCode + "', ");
                    sbSql.Append("       " + modelPurchase.factoryId + ", ");
                    sbSql.Append("       " + modelPurchase.customerId + ", ");
                    sbSql.Append("      '" + modelPurchase.deliveryDate + "', ");
                    sbSql.Append("       " + modelPurchase.status + ", ");
                    sbSql.Append("       " + modelPurchase.price + ", ");
                    sbSql.Append("       " + modelPurchase.payType + ", ");
                    sbSql.Append("       " + modelPurchase.purchaserId + ", ");
                    sbSql.Append("      '" + modelPurchase.purchaseDate + "', ");
                    sbSql.Append("       " + modelPurchase.country + ", ");
                    sbSql.Append("       " + modelPurchase.province + ", ");
                    sbSql.Append("      '" + modelPurchase.provinceName + "', ");
                    sbSql.Append("       " + modelPurchase.city + ", ");
                    sbSql.Append("      '" + modelPurchase.cityName + "', ");
                    sbSql.Append("       " + modelPurchase.district + ", ");
                    sbSql.Append("      '" + modelPurchase.districtName + "', ");
                    sbSql.Append("      '" + modelPurchase.address + "', ");
                    sbSql.Append("      '" + modelPurchase.manager + "', ");
                    sbSql.Append("      '" + modelPurchase.telephone + "', ");
                    sbSql.Append("      '" + modelPurchase.remark + "', ");
                    sbSql.Append("       " + modelPurchase.isDelete + ", ");
                    sbSql.Append("      '" + modelPurchase.createBy + "', ");
                    sbSql.Append("      '" + modelPurchase.createTime + "')");
                    listSql.Add(sbSql.ToString());

                    foreach (ModelPurchaseDetail modelPurchaseDetail in modelPurchase.modelPurchaseDetail)
                    {
                        sbSql.Clear();
                        sbSql.Append("insert into ");
                        sbSql.Append("       r_purchase_detail ( ");
                        sbSql.Append("       purchaseCode, ");
                        sbSql.Append("       materialsId, ");
                        sbSql.Append("       specsId, ");
                        sbSql.Append("       num, ");
                        sbSql.Append("       price, ");
                        sbSql.Append("       produceCode, ");
                        sbSql.Append("       deliveryDate, ");
                        sbSql.Append("       applyType, ");
                        sbSql.Append("       applyBy, ");
                        sbSql.Append("       applyDate, ");
                        sbSql.Append("       isDelete, ");
                        sbSql.Append("       createBy, ");
                        sbSql.Append("       createTime");
                        sbSql.Append("       ) value ( ");
                        sbSql.Append("      '" + modelPurchaseDetail.purchaseCode + "', ");
                        sbSql.Append("       " + modelPurchaseDetail.materialsId + ", ");
                        sbSql.Append("       " + modelPurchaseDetail.specsId + ", ");
                        sbSql.Append("       " + modelPurchaseDetail.num + ", ");
                        sbSql.Append("       " + modelPurchaseDetail.price + ", ");
                        sbSql.Append("      '" + modelPurchaseDetail.produceCode + "', ");
                        sbSql.Append("      '" + modelPurchaseDetail.deliveryDate + "', ");
                        sbSql.Append("       " + modelPurchaseDetail.applyType + ", ");
                        sbSql.Append("      '" + modelPurchaseDetail.applyBy + "', ");
                        sbSql.Append("      '" + modelPurchaseDetail.applyDate + "', ");
                        sbSql.Append("       " + modelPurchaseDetail.isDelete + ", ");
                        sbSql.Append("      '" + modelPurchaseDetail.createBy + "', ");
                        sbSql.Append("      '" + modelPurchaseDetail.createTime + "')");
                        listSql.Add(sbSql.ToString());

                        sbSql.Clear();
                        sbSql.Append("insert into ");
                        sbSql.Append("       p_materials_input ( ");
                        sbSql.Append("       inputCode, ");
                        sbSql.Append("       purchaseCode, ");
                        sbSql.Append("       purchaseBy, ");
                        sbSql.Append("       purchaseDate, ");
                        sbSql.Append("       purchaseNum, ");
                        sbSql.Append("       factoryId, ");
                        sbSql.Append("       materialsId, ");
                        sbSql.Append("       specsId, ");
                        sbSql.Append("       inputNum, ");
                        sbSql.Append("       inputType, ");
                        sbSql.Append("       customerId, ");
                        sbSql.Append("       inputStatus, ");
                        sbSql.Append("       isDelete, ");
                        sbSql.Append("       createBy, ");
                        sbSql.Append("       createTime");
                        sbSql.Append("       ) value ( ");
                        sbSql.Append("      '" + modelPurchaseDetail.inputCode + "', ");
                        sbSql.Append("      '" + modelPurchaseDetail.purchaseCode + "', ");
                        sbSql.Append("      '" + modelPurchaseDetail.modifyBy + "', ");
                        sbSql.Append("      '" + modelPurchaseDetail.modifyTime + "', ");
                        sbSql.Append("       " + modelPurchaseDetail.num + ", ");
                        sbSql.Append("       " + modelPurchase.factoryId + ", ");
                        sbSql.Append("       " + modelPurchaseDetail.materialsId + ", ");
                        sbSql.Append("       " + modelPurchaseDetail.specsId + ", ");
                        sbSql.Append("       " + modelPurchaseDetail.num + ", ");
                        sbSql.Append("       " + (int)Enum.EnumMaterialsInType.Purchase + ", ");
                        sbSql.Append("      '" + modelPurchase.customerId + "', ");
                        sbSql.Append("       0, ");
                        sbSql.Append("       " + modelPurchase.isDelete + ", ");
                        sbSql.Append("      '" + modelPurchase.modifyBy + "', ");
                        sbSql.Append("      '" + modelPurchase.modifyTime + "')");
                        listSql.Add(sbSql.ToString());
                    }

                    sbSql.Clear();
                    sbSql.Append("insert into ");
                    sbSql.Append("       p_finance_paid ( ");
                    sbSql.Append("       purchaseCode, ");
                    sbSql.Append("       factoryId, ");
                    sbSql.Append("       paidStatus, ");
                    sbSql.Append("       orderPrice, ");
                    sbSql.Append("       purchaseBy, ");
                    sbSql.Append("       purchaseDate, ");
                    sbSql.Append("       customerId, ");
                    sbSql.Append("       isDelete, ");
                    sbSql.Append("       createBy, ");
                    sbSql.Append("       createTime");
                    sbSql.Append("       ) value ( ");
                    sbSql.Append("      '" + modelPurchase.purchaseCode + "', ");
                    sbSql.Append("       " + modelPurchase.factoryId + ", ");
                    sbSql.Append("       " + (int)Enum.EnumPayStatus.NoPay + ", ");
                    sbSql.Append("       " + modelPurchase.price + ", ");
                    sbSql.Append("      '" + modelPurchase.modifyBy + "', ");
                    sbSql.Append("      '" + modelPurchase.modifyTime + "', ");
                    sbSql.Append("       " + modelPurchase.customerId + ", ");
                    sbSql.Append("       " + modelPurchase.isDelete + ", ");
                    sbSql.Append("      '" + modelPurchase.createBy + "', ");
                    sbSql.Append("      '" + modelPurchase.createTime + "')");
                    listSql.Add(sbSql.ToString());

                    sbSql.Clear();
                    sbSql.Append("insert into ");
                    sbSql.Append("       p_finance_accounts ( ");
                    sbSql.Append("       customerId, ");
                    sbSql.Append("       type, ");
                    sbSql.Append("       orderCode, ");
                    sbSql.Append("       curPricePlan, ");
                    sbSql.Append("       curPrice, ");
                    sbSql.Append("       isDelete, ");
                    sbSql.Append("       createBy, ");
                    sbSql.Append("       createTime ");
                    sbSql.Append("       ) values ( ");
                    sbSql.Append("       " + modelPurchase.customerId + ", ");
                    sbSql.Append("       1, ");
                    sbSql.Append("       '" + modelPurchase.purchaseCode + "', ");
                    sbSql.Append("       " + modelPurchase.price + ", ");
                    sbSql.Append("       0, ");
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

        public DataTable GetLastPurchase(int _materialsId, int _specsId)
        {
            sbSql.Clear();
            sbSql.Append("select a.* ");
            sbSql.Append("  from r_purchase_detail a ");
            sbSql.Append(" where a.isDelete = 0 ");
            sbSql.Append("   and a.materialsId = ").Append(_materialsId).Append(" ");
            sbSql.Append("   and ifnull(a.specsId, 0) = ").Append(_specsId).Append(" ");
            sbSql.Append(" order by a.id desc ");
            sbSql.Append(" limit 0,1 ");

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
            sbSql.Append("  from p_materials_input a ");
            sbSql.Append(" where a.isDelete = 0 ");
            sbSql.Append("   and a.inputStatus = 1 ");
            sbSql.Append("   and a.purchaseCode = '").Append(_purchaseCode).Append("' ");

            return Dal.DBHelper.Select(sbSql.ToString());
        }

        public DataTable GetPaidByPurchaseCode(string _purchaseCode)
        {
            sbSql.Clear();
            sbSql.Append("select a.* ");
            sbSql.Append("  from p_finance_paid a ");
            sbSql.Append(" where a.isDelete = 0 ");
            sbSql.Append("   and a.paidStatus != " + (int)Enum.EnumPayStatus.NoPay + " ");
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
            sbSql.Append("       deliveryDate, ");
            sbSql.Append("       status, ");
            sbSql.Append("       customerId, ");
            sbSql.Append("       payType, ");
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
            sbSql.Append("       purchaserId, ");
            sbSql.Append("       purchaseDate, ");
            sbSql.Append("       remark, ");
            sbSql.Append("       isDelete, ");
            sbSql.Append("       createBy, ");
            sbSql.Append("       createTime");
            sbSql.Append("       ) value ( ");
            sbSql.Append("      '" + _model.purchaseCode + "', ");
            sbSql.Append("       " + _model.factoryId + ", ");
            sbSql.Append("      '" + _model.deliveryDate + "', ");
            sbSql.Append("       " + _model.status + ", ");
            sbSql.Append("       " + _model.customerId + ", ");
            sbSql.Append("       " + _model.payType + ", ");
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
            sbSql.Append("       " + _model.purchaserId + ", ");
            sbSql.Append("      '" + _model.purchaseDate + "', ");
            sbSql.Append("      '" + _model.remark + "', ");
            sbSql.Append("       " + _model.isDelete + ", ");
            sbSql.Append("      '" + _model.createBy + "', ");
            sbSql.Append("      '" + _model.createTime + "')");
            listSql.Add(sbSql.ToString());

            foreach (ModelPurchaseDetail modelPurchaseDetail in _model.modelPurchaseDetail)
            {
                sbSql.Clear();
                sbSql.Append("update r_purchase_detail ");
                sbSql.Append("set specsId = " + modelPurchaseDetail.specsId + ", "); ;
                sbSql.Append("    num = " + modelPurchaseDetail.num + ",");
                sbSql.Append("    price = " + modelPurchaseDetail.price + ",");
                sbSql.Append("    modifyBy = '" + modelPurchaseDetail.modifyBy + "',");
                sbSql.Append("    modifyTime = '" + modelPurchaseDetail.modifyTime + "' ");
                sbSql.Append("where id = " + modelPurchaseDetail.id);
                listSql.Add(sbSql.ToString());

                sbSql.Clear();
                sbSql.Append("insert into ");
                sbSql.Append("       p_materials_input ( ");
                sbSql.Append("       inputCode, ");
                sbSql.Append("       purchaseCode, ");
                sbSql.Append("       purchaseBy, ");
                sbSql.Append("       purchaseDate, ");
                sbSql.Append("       purchaseNum, ");
                sbSql.Append("       factoryId, ");
                sbSql.Append("       materialsId, ");
                sbSql.Append("       inputNum, ");
                sbSql.Append("       inputType, ");
                sbSql.Append("       customerId, ");
                sbSql.Append("       inputStatus, ");
                sbSql.Append("       isDelete, ");
                sbSql.Append("       createBy, ");
                sbSql.Append("       createTime");
                sbSql.Append("       ) value ( ");
                sbSql.Append("      '" + modelPurchaseDetail.inputCode + "', ");
                sbSql.Append("      '" + _model.purchaseCode + "', ");
                sbSql.Append("      '" + _model.modifyBy + "', ");
                sbSql.Append("      '" + _model.modifyTime + "', ");
                sbSql.Append("       " + modelPurchaseDetail.num + ", ");
                sbSql.Append("       " + _model.factoryId + ", ");
                sbSql.Append("       " + modelPurchaseDetail.materialsId + ", ");
                sbSql.Append("       " + modelPurchaseDetail.num + ", ");
                sbSql.Append("       " + (int)Enum.EnumMaterialsInType.Purchase + ", ");
                sbSql.Append("      '" + _model.customerId + "', ");
                sbSql.Append("       0, ");
                sbSql.Append("       " + _model.isDelete + ", ");
                sbSql.Append("      '" + _model.modifyBy + "', ");
                sbSql.Append("      '" + _model.modifyTime + "')");
                listSql.Add(sbSql.ToString());

            }

            sbSql.Clear();
            sbSql.Append("insert into ");
            sbSql.Append("       p_finance_paid ( ");
            sbSql.Append("       purchaseCode, ");
            sbSql.Append("       factoryId, ");
            sbSql.Append("       paidStatus, ");
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
            sbSql.Append("       " + (int)Enum.EnumPayStatus.NoPay + ", ");
            sbSql.Append("       " + _model.price + ", ");
            sbSql.Append("      '" + _model.modifyBy + "', ");
            sbSql.Append("      '" + _model.modifyTime + "', ");
            sbSql.Append("       " + _model.customerId + ", ");
            sbSql.Append("       " + _model.isDelete + ", ");
            sbSql.Append("      '" + _model.createBy + "', ");
            sbSql.Append("      '" + _model.createTime + "')");
            listSql.Add(sbSql.ToString());

            sbSql.Clear();
            sbSql.Append("insert into ");
            sbSql.Append("       p_finance_accounts ( ");
            sbSql.Append("       customerId, ");
            sbSql.Append("       type, ");
            sbSql.Append("       orderCode, ");
            sbSql.Append("       curPricePlan, ");
            sbSql.Append("       curPrice, ");
            sbSql.Append("       isDelete, ");
            sbSql.Append("       createBy, ");
            sbSql.Append("       createTime ");
            sbSql.Append("       ) values ( ");
            sbSql.Append("       " + _model.customerId + ", ");
            sbSql.Append("       1, ");
            sbSql.Append("       '" + _model.purchaseCode + "', ");
            sbSql.Append("       " + _model.price + ", ");
            sbSql.Append("       0, ");
            sbSql.Append("       " + _model.isDelete + ", ");
            sbSql.Append("      '" + _model.createBy + "', ");
            sbSql.Append("      '" + _model.createTime + "')");
            listSql.Add(sbSql.ToString());

            return Dal.DBHelper.ExcuteTransaction(listSql);
        }

        public int UpdatePurchase(ModelPurchase _model)
        {
            List<string> listSql = new List<string>();

            sbSql.Clear();
            sbSql.Append("update p_purchase ");
            sbSql.Append("set factoryId = " + _model.factoryId + ", "); ;
            sbSql.Append("    deliveryDate = '" + _model.deliveryDate + "',");
            sbSql.Append("    status = " + _model.status + ",");
            sbSql.Append("    customerId = " + _model.customerId + ",");
            sbSql.Append("    payType = " + _model.payType + ",");
            sbSql.Append("    country = " + _model.country + ",");
            sbSql.Append("    province = " + _model.province + ",");
            sbSql.Append("    provinceName = '" + _model.provinceName + "',");
            sbSql.Append("    city = " + _model.city + ",");
            sbSql.Append("    cityName = '" + _model.cityName + "',");
            sbSql.Append("    district = " + _model.district + ",");
            sbSql.Append("    districtName = '" + _model.districtName + "',");
            sbSql.Append("    address = '" + _model.address + "',");
            sbSql.Append("    manager = '" + _model.manager + "',");
            sbSql.Append("    telephone = '" + _model.telephone + "',");
            sbSql.Append("    purchaserId = " + _model.purchaserId + ",");
            sbSql.Append("    purchaseDate = '" + _model.purchaseDate + "',");
            sbSql.Append("    price = " + _model.price + ",");
            sbSql.Append("    remark = '" + _model.remark + "',");
            sbSql.Append("    modifyBy = '" + _model.modifyBy + "',");
            sbSql.Append("    modifyTime = '" + _model.modifyTime + "' ");
            sbSql.Append("where id = " + _model.id);
            listSql.Add(sbSql.ToString());

            sbSql.Clear();
            sbSql.Append("delete ");
            sbSql.Append("  from p_materials_input ");
            sbSql.Append(" where purchaseCode = '" + _model.purchaseCode + "' ");
            listSql.Add(sbSql.ToString());

            foreach (ModelPurchaseDetail modelPurchaseDetail in _model.modelPurchaseDetail)
            {
                sbSql.Clear();
                sbSql.Append("update r_purchase_detail ");
                sbSql.Append("set specsId = " + modelPurchaseDetail.specsId + ", "); ;
                sbSql.Append("    num = " + modelPurchaseDetail.num + ",");
                sbSql.Append("    price = " + modelPurchaseDetail.price + ",");
                sbSql.Append("    modifyBy = '" + modelPurchaseDetail.modifyBy + "',");
                sbSql.Append("    modifyTime = '" + modelPurchaseDetail.modifyTime + "' ");
                sbSql.Append("where id = " + modelPurchaseDetail.id);
                listSql.Add(sbSql.ToString());

                sbSql.Clear();
                sbSql.Append("insert into ");
                sbSql.Append("       p_materials_input ( ");
                sbSql.Append("       inputCode, ");
                sbSql.Append("       purchaseCode, ");
                sbSql.Append("       purchaseBy, ");
                sbSql.Append("       purchaseDate, ");
                sbSql.Append("       purchaseNum, ");
                sbSql.Append("       factoryId, ");
                sbSql.Append("       materialsId, ");
                sbSql.Append("       specsId, ");
                sbSql.Append("       inputNum, ");
                sbSql.Append("       inputType, ");
                sbSql.Append("       customerId, ");
                sbSql.Append("       inputStatus, ");
                sbSql.Append("       isDelete, ");
                sbSql.Append("       createBy, ");
                sbSql.Append("       createTime");
                sbSql.Append("       ) value ( ");
                sbSql.Append("      '" + modelPurchaseDetail.inputCode + "', ");
                sbSql.Append("      '" + _model.purchaseCode + "', ");
                sbSql.Append("      '" + _model.modifyBy + "', ");
                sbSql.Append("      '" + _model.modifyTime + "', ");
                sbSql.Append("       " + modelPurchaseDetail.num + ", ");
                sbSql.Append("       " + _model.factoryId + ", ");
                sbSql.Append("       " + modelPurchaseDetail.materialsId + ", ");
                sbSql.Append("       " + modelPurchaseDetail.specsId + ", ");
                sbSql.Append("       " + modelPurchaseDetail.num + ", ");
                sbSql.Append("       " + (int)Enum.EnumMaterialsInType.Purchase + ", ");
                sbSql.Append("      '" + _model.customerId + "', ");
                sbSql.Append("       0, ");
                sbSql.Append("       " + _model.isDelete + ", ");
                sbSql.Append("      '" + _model.modifyBy + "', ");
                sbSql.Append("      '" + _model.modifyTime + "')");
                listSql.Add(sbSql.ToString());

            }
            
            sbSql.Clear();
            sbSql.Append("delete ");
            sbSql.Append("  from p_finance_paid ");
            sbSql.Append(" where purchaseCode = '" + _model.purchaseCode + "' ");
            listSql.Add(sbSql.ToString());

            sbSql.Clear();
            sbSql.Append("insert into ");
            sbSql.Append("       p_finance_paid ( ");
            sbSql.Append("       purchaseCode, ");
            sbSql.Append("       factoryId, ");
            sbSql.Append("       paidStatus, ");
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
            sbSql.Append("       " + (int)Enum.EnumPayStatus.NoPay + ", ");
            sbSql.Append("       " + _model.price + ", ");
            sbSql.Append("      '" + _model.modifyBy + "', ");
            sbSql.Append("      '" + _model.modifyTime + "', ");
            sbSql.Append("       " + _model.customerId + ", ");
            sbSql.Append("       " + _model.isDelete + ", ");
            sbSql.Append("      '" + _model.createBy + "', ");
            sbSql.Append("      '" + _model.createTime + "')");
            listSql.Add(sbSql.ToString());

            sbSql.Clear();
            sbSql.Append("delete ");
            sbSql.Append("  from p_finance_accounts ");
            sbSql.Append(" where orderCode = '" + _model.purchaseCode + "' ");
            listSql.Add(sbSql.ToString());

            sbSql.Clear();
            sbSql.Append("insert into ");
            sbSql.Append("       p_finance_accounts ( ");
            sbSql.Append("       customerId, ");
            sbSql.Append("       type, ");
            sbSql.Append("       orderCode, ");
            sbSql.Append("       curPricePlan, ");
            sbSql.Append("       curPrice, ");
            sbSql.Append("       isDelete, ");
            sbSql.Append("       createBy, ");
            sbSql.Append("       createTime ");
            sbSql.Append("       ) values ( ");
            sbSql.Append("       " + _model.customerId + ", ");
            sbSql.Append("       1, ");
            sbSql.Append("       '" + _model.purchaseCode + "', ");
            sbSql.Append("       " + _model.price + ", ");
            sbSql.Append("       0, ");
            sbSql.Append("       " + _model.isDelete + ", ");
            sbSql.Append("      '" + _model.createBy + "', ");
            sbSql.Append("      '" + _model.createTime + "')");
            listSql.Add(sbSql.ToString());

            return Dal.DBHelper.ExcuteTransaction(listSql);
        }

        //public int ConfirmPurchase(ModelPurchase _model)
        //{
        //    List<string> listSql = new List<string>();

        //    sbSql.Clear();
        //    sbSql.Append("update p_purchase ");
        //    sbSql.Append("set status = " + _model.status + ",");
        //    sbSql.Append("    price = '" + _model.price + "',");
        //    sbSql.Append("    remark = '" + _model.remark + "',");
        //    sbSql.Append("    purchaserId = '" + _model.purchaserId + "',");
        //    sbSql.Append("    modifyBy = '" + _model.modifyBy + "',");
        //    sbSql.Append("    modifyTime = '" + _model.modifyTime + "' ");
        //    sbSql.Append("where id = " + _model.id);
        //    listSql.Add(sbSql.ToString());

        //    sbSql.Clear();
        //    sbSql.Append("insert into ");
        //    sbSql.Append("       p_materials_input ( ");
        //    sbSql.Append("       purchaseCode, ");
        //    sbSql.Append("       purchaseBy, ");
        //    sbSql.Append("       purchaseDate, ");
        //    sbSql.Append("       purchaseNum, ");
        //    sbSql.Append("       factoryId, ");
        //    sbSql.Append("       materialsId, ");
        //    sbSql.Append("       inputNum, ");
        //    sbSql.Append("       inputType, ");
        //    sbSql.Append("       customerId, ");
        //    sbSql.Append("       inputStatus, ");
        //    sbSql.Append("       isDelete, ");
        //    sbSql.Append("       createBy, ");
        //    sbSql.Append("       createTime");
        //    sbSql.Append("       ) value ( ");
        //    sbSql.Append("      '" + _model.purchaseCode + "', ");
        //    sbSql.Append("      '" + _model.modifyBy + "', ");
        //    sbSql.Append("      '" + _model.modifyTime + "', ");
        //    sbSql.Append("       " + _model.num + ", ");
        //    sbSql.Append("       " + _model.factoryId + ", ");
        //    sbSql.Append("       " + _model.materialsId + ", ");
        //    sbSql.Append("       " + _model.num + ", ");
        //    sbSql.Append("       " + (int)Enum.EnumMaterialsInType.Purchase + ", ");
        //    sbSql.Append("      '" + _model.customerId + "', ");
        //    sbSql.Append("       0, ");
        //    sbSql.Append("       " + _model.isDelete + ", ");
        //    sbSql.Append("      '" + _model.modifyBy + "', ");
        //    sbSql.Append("      '" + _model.modifyTime + "')");
        //    listSql.Add(sbSql.ToString());

        //    sbSql.Clear();
        //    sbSql.Clear();
        //    sbSql.Append("insert into ");
        //    sbSql.Append("       p_finance_paid ( ");
        //    sbSql.Append("       purchaseCode, ");
        //    sbSql.Append("       factoryId, ");
        //    sbSql.Append("       materialsId, ");
        //    sbSql.Append("       num, ");
        //    sbSql.Append("       paidStatus, ");
        //    sbSql.Append("       orderPrice, ");
        //    sbSql.Append("       purchaseBy, ");
        //    sbSql.Append("       purchaseDate, ");
        //    sbSql.Append("       customerId, ");
        //    sbSql.Append("       isDelete, ");
        //    sbSql.Append("       createBy, ");
        //    sbSql.Append("       createTime");
        //    sbSql.Append("       ) value ( ");
        //    sbSql.Append("      '" + _model.purchaseCode + "', ");
        //    sbSql.Append("       " + _model.factoryId + ", ");
        //    sbSql.Append("       " + _model.materialsId + ", ");
        //    sbSql.Append("       " + _model.num + ", ");
        //    sbSql.Append("       " + (int)Enum.EnumPayStatus.NoPay + ", ");
        //    sbSql.Append("       " + _model.price + ", ");
        //    sbSql.Append("      '" + _model.modifyBy + "', ");
        //    sbSql.Append("      '" + _model.modifyTime + "', ");
        //    sbSql.Append("       " + _model.customerId + ", ");
        //    sbSql.Append("       " + _model.isDelete + ", ");
        //    sbSql.Append("      '" + _model.createBy + "', ");
        //    sbSql.Append("      '" + _model.createTime + "')");
        //    listSql.Add(sbSql.ToString());

        //    return Dal.DBHelper.ExcuteTransaction(listSql);
        //}

        public int CancelPurchase(ModelPurchase _model)
        {
            List<string> listSql = new List<string>();

            sbSql.Clear();
            sbSql.Append("update p_purchase ");
            sbSql.Append("set status = " + _model.status + ",");
            sbSql.Append("    cancelReason = '" + _model.cancelReason + "',");
            sbSql.Append("    modifyBy = '" + _model.modifyBy + "',");
            sbSql.Append("    modifyTime = '" + _model.modifyTime + "' ");
            sbSql.Append("where id = " + _model.id);
            listSql.Add(sbSql.ToString());

            sbSql.Clear();
            sbSql.Append("update p_materials_input ");
            sbSql.Append("set isDelete = 1,");
            sbSql.Append("    modifyBy = '" + _model.modifyBy + "',");
            sbSql.Append("    modifyTime = '" + _model.modifyTime + "' ");
            sbSql.Append("where isDelete = 0");
            sbSql.Append("  and inputStatus = 0 ");
            sbSql.Append("  and purchaseCode = '").Append(_model.purchaseCode).Append("' ");
            listSql.Add(sbSql.ToString());

            sbSql.Clear();
            sbSql.Append("update p_finance_paid ");
            sbSql.Append("set isDelete = 1,");
            sbSql.Append("    modifyBy = '" + _model.modifyBy + "',");
            sbSql.Append("    modifyTime = '" + _model.modifyTime + "' ");
            sbSql.Append("where isDelete = 0");
            sbSql.Append("  and paidStatus =  " + (int)Enum.EnumPayStatus.NoPay + " ");
            sbSql.Append("  and purchaseCode = '").Append(_model.purchaseCode).Append("' ");
            listSql.Add(sbSql.ToString());

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
            sbSql.Append("update r_purchase_detail ");
            sbSql.Append("set isDelete = 1,");
            sbSql.Append("    modifyBy = '" + _model.modifyBy + "',");
            sbSql.Append("    modifyTime = '" + _model.modifyTime + "' ");
            sbSql.Append("where isDelete = 0");
            sbSql.Append("  and purchaseCode = '").Append(_model.purchaseCode).Append("' ");
            listSql.Add(sbSql.ToString());

            sbSql.Clear();
            sbSql.Append("update p_materials_input ");
            sbSql.Append("set isDelete = 1,");
            sbSql.Append("    modifyBy = '" + _model.modifyBy + "',");
            sbSql.Append("    modifyTime = '" + _model.modifyTime + "' ");
            sbSql.Append("where isDelete = 0");
            sbSql.Append("  and inputStatus = 0 ");
            sbSql.Append("  and purchaseCode = '").Append(_model.purchaseCode).Append("' ");
            listSql.Add(sbSql.ToString());

            sbSql.Clear();
            sbSql.Append("update p_finance_paid ");
            sbSql.Append("set isDelete = 1,");
            sbSql.Append("    modifyBy = '" + _model.modifyBy + "',");
            sbSql.Append("    modifyTime = '" + _model.modifyTime + "' ");
            sbSql.Append("where isDelete = 0");
            sbSql.Append("  and paidStatus = " + (int)Enum.EnumPayStatus.NoPay + " ");
            sbSql.Append("  and purchaseCode = '").Append(_model.purchaseCode).Append("' ");
            listSql.Add(sbSql.ToString());

            return Dal.DBHelper.ExcuteTransaction(listSql);
        }

        public int AddPurchaseDetail(int _factoryId, int _customerId, ModelPurchaseDetail _model)
        {
            List<string> listSql = new List<string>();
            
            sbSql.Clear();
            sbSql.Append("insert into ");
            sbSql.Append("       r_purchase_detail ( ");
            sbSql.Append("       purchaseCode, ");
            sbSql.Append("       materialsId, ");
            sbSql.Append("       specsId, ");
            sbSql.Append("       num, ");
            sbSql.Append("       price, ");
            sbSql.Append("       deliveryDate, ");
            sbSql.Append("       isDelete, ");
            sbSql.Append("       createBy, ");
            sbSql.Append("       createTime ");
            sbSql.Append("       ) values ( ");
            sbSql.Append("      '" + _model.purchaseCode + "', ");
            sbSql.Append("       " + _model.materialsId + ", ");
            sbSql.Append("       " + _model.specsId + ", ");
            sbSql.Append("       " + _model.num + ", ");
            sbSql.Append("       " + _model.price + ", ");
            sbSql.Append("      '" + _model.deliveryDate + "', ");
            sbSql.Append("       " + _model.isDelete + ", ");
            sbSql.Append("      '" + _model.createBy + "', ");
            sbSql.Append("      '" + _model.createTime + "')");
            listSql.Add(sbSql.ToString());

            //sbSql.Clear();
            //sbSql.Append("insert into ");
            //sbSql.Append("       p_materials_input ( ");
            //sbSql.Append("       inputCode, ");
            //sbSql.Append("       purchaseCode, ");
            //sbSql.Append("       purchaseBy, ");
            //sbSql.Append("       purchaseDate, ");
            //sbSql.Append("       purchaseNum, ");
            //sbSql.Append("       factoryId, ");
            //sbSql.Append("       materialsId, ");
            //sbSql.Append("       specsId, ");
            //sbSql.Append("       inputNum, ");
            //sbSql.Append("       inputType, ");
            //sbSql.Append("       customerId, ");
            //sbSql.Append("       inputStatus, ");
            //sbSql.Append("       isDelete, ");
            //sbSql.Append("       createBy, ");
            //sbSql.Append("       createTime");
            //sbSql.Append("       ) value ( ");
            //sbSql.Append("      '" + _model.inputCode + "', ");
            //sbSql.Append("      '" + _model.purchaseCode + "', ");
            //sbSql.Append("      '" + _model.modifyBy + "', ");
            //sbSql.Append("      '" + _model.modifyTime + "', ");
            //sbSql.Append("       " + _model.num + ", ");
            //sbSql.Append("       " + _factoryId + ", ");
            //sbSql.Append("       " + _model.materialsId + ", ");
            //sbSql.Append("       " + _model.specsId + ", ");
            //sbSql.Append("       " + _model.num + ", ");
            //sbSql.Append("       " + (int)Enum.EnumMaterialsInType.Purchase + ", ");
            //sbSql.Append("      '" + _customerId + "', ");
            //sbSql.Append("       0, ");
            //sbSql.Append("       " + _model.isDelete + ", ");
            //sbSql.Append("      '" + _model.modifyBy + "', ");
            //sbSql.Append("      '" + _model.modifyTime + "')");
            //listSql.Add(sbSql.ToString());

            return Dal.DBHelper.ExcuteTransaction(listSql);

        }

        public int DetelePurchaseDetail(ModelPurchaseDetail _model)
        {
            List<string> listSql = new List<string>();

            sbSql.Clear();
            sbSql.Append("update r_purchase_detail ");
            sbSql.Append("set isDelete = 1,");
            sbSql.Append("    modifyBy = '" + _model.modifyBy + "',");
            sbSql.Append("    modifyTime = '" + _model.modifyTime + "' ");
            sbSql.Append("where id = " + _model.id + " ");
            sbSql.Append("  and isDelete = 0 ");
            listSql.Add(sbSql.ToString());

            //sbSql.Clear();
            //sbSql.Append("update p_materials_input ");
            //sbSql.Append("set isDelete = 1,");
            //sbSql.Append("    modifyBy = '" + _model.modifyBy + "',");
            //sbSql.Append("    modifyTime = '" + _model.modifyTime + "' ");
            //sbSql.Append("where purchaseCode = '" + _model.purchaseCode + "' ");
            //sbSql.Append("  and materialsId = " + _model.materialsId + " ");
            //sbSql.Append("  and specsId = " + _model.specsId + " ");
            //sbSql.Append("  and isDelete = 0 ");
            //listSql.Add(sbSql.ToString());

            return Dal.DBHelper.ExcuteTransaction(listSql);

        }
    }
}
