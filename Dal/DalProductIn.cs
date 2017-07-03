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

        public DataTable GetProductIn(String _productName, int _factoryId, DateTime _beginTime, DateTime _endTime, int _inputStatus, int _isQC)
        {
            sbSql.Clear();
            sbSql.Append("select a.id, ");
            sbSql.Append("       a.inputCode, ");
            sbSql.Append("       b.name factoryName, ");
            sbSql.Append("       c.name productName, ");
            sbSql.Append("       e.name specsName, ");
            sbSql.Append("       a.inputNum, ");
            sbSql.Append("       a.produceCode, ");
            sbSql.Append("       date_format(a.produceDate, '%Y-%m-%d') produceDate, ");
            sbSql.Append("       date_format(a.expiresDate, '%Y-%m-%d') expiresDate, ");
            sbSql.Append("       case a.inputStatus when 0 then '请求入库' else '完成入库' end inputStatus, ");
            sbSql.Append("       a.inputStatus inputStatusCode, ");
            sbSql.Append("       date_format(a.inputDate, '%Y-%m-%d') inputDate, ");
            sbSql.Append("       ifnull(f.cnt,0) outputCnt, ");
            sbSql.Append("       case g.inspectResult when 0 then '不合格' when 1 then '合格' else '未检验' end QC, ");
            sbSql.Append("       case ifnull(f.cnt,0) when 0 then '修改' else '查看' end modifyBtn, ");
            sbSql.Append("       '删除' deleteBtn ");
            sbSql.Append("from p_product_input a ");
            sbSql.Append("left join m_factory b ");
            sbSql.Append("  on a.factoryId = b.id ");
            sbSql.Append("left join p_product c ");
            sbSql.Append("  on a.productId = c.id ");
            sbSql.Append("left join r_product_specs e ");
            sbSql.Append("  on a.productId = e.productId ");
            sbSql.Append(" and a.specsId = e.id ");
            sbSql.Append("left join (select count(*) cnt,inputCode ");
            sbSql.Append("             from h_product_output_log ");
            sbSql.Append("            where isDelete = 0 ");
            sbSql.Append("            group by inputCode) f ");
            sbSql.Append("  on a.inputCode = f.inputCode ");
            sbSql.Append("left join p_produce d ");
            sbSql.Append("  on a.produceCode = d.produceCode ");
            sbSql.Append("left join r_product_input_quality g ");
            sbSql.Append("  on a.inputCode = g.inputCode ");
            sbSql.Append(" and g.isDelete = 0 ");
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
            if (_isQC == 2)
            {
                sbSql.Append("  and g.id is null ");
            }
            if (_isQC == 1)
            {
                sbSql.Append("  and g.inspectResult = 1 ");
            }
            if (_isQC == 0)
            {
                sbSql.Append("  and g.inspectResult = 0 ");
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

        public DataTable GetProductInByInputCode(string _inputCode)
        {
            sbSql.Clear();
            sbSql.Append("select a.* ");
            sbSql.Append("from p_product_input a ");
            sbSql.Append("where a.isDelete = 0 ");
            sbSql.Append("  and a.inputCode = '").Append(_inputCode).Append("' ");

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
            sbSql.Append("       specsId, ");
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
            sbSql.Append("       " + _model.specsId + ", ");
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
            sbSql.Append("    specsId = " + _model.specsId + ",");
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

            sbSql.Clear();
            sbSql.Append("update r_product_input_quality ");
            sbSql.Append("set isDelete = 1,");
            sbSql.Append("    modifyBy = '" + _model.modifyBy + "',");
            sbSql.Append("    modifyTime = '" + _model.modifyTime + "' ");
            sbSql.Append("where inputCode = '" + _model.inputCode + "' ");
            sbSql.Append("  and isDelete = 0 ");
            listSql.Add(sbSql.ToString());

            sbSql.Clear();
            sbSql.Append("update r_product_input_quality_detail ");
            sbSql.Append("set isDelete = 1,");
            sbSql.Append("    modifyBy = '" + _model.modifyBy + "',");
            sbSql.Append("    modifyTime = '" + _model.modifyTime + "' ");
            sbSql.Append("where inputCode = '" + _model.inputCode + "' ");
            sbSql.Append("  and isDelete = 0 ");
            listSql.Add(sbSql.ToString());
           
            return Dal.DBHelper.ExcuteTransaction(listSql);
        }

        public DataTable GetProductInQC(string _inputCode)
        {
            sbSql.Clear();
            sbSql.Append("select ifnull(f.id, 0) QCid, ");
            sbSql.Append("       b.name factoryName, ");
            sbSql.Append("       a.inputNum , ");
            sbSql.Append("       c.name productName, ");
            sbSql.Append("       d.value1 morphology, ");
            sbSql.Append("       e.name specsName, ");
            sbSql.Append("       c.excuteStandard, ");
            sbSql.Append("       a.produceCode , ");
            sbSql.Append("       date_format(a.produceDate, '%Y-%m-%d') produceDate, ");
            sbSql.Append("       ifnull(f.inspectResult ,-1) inspectResult, ");
            sbSql.Append("       f.inspecterId , ");
            sbSql.Append("       f.checkerId , ");
            sbSql.Append("       date_format(f.inspectDate, '%Y-%m-%d') inspectDate ");
            sbSql.Append("from p_product_input a ");
            sbSql.Append("left join m_factory b ");
            sbSql.Append("on   a.factoryId = b.id ");
            sbSql.Append("left join p_product c ");
            sbSql.Append("on   a.productId = c.id ");
            sbSql.Append("left join m_code d ");
            sbSql.Append("on   c.morphology = d.subCode ");
            sbSql.Append("and  d.code = 2 ");
            sbSql.Append("left join r_product_specs e ");
            sbSql.Append("on   a.productId = e.productId ");
            sbSql.Append("and  a.specsId = e.id ");
            sbSql.Append("left join r_product_input_quality f ");
            sbSql.Append("on   a.inputCode = f.inputCode ");
            sbSql.Append("and  f.isDelete = 0 ");
            sbSql.Append("where a.isDelete = 0 ");
            sbSql.Append("  and a.inputCode = '").Append(_inputCode).Append("' ");

            return Dal.DBHelper.Select(sbSql.ToString());

        }
        public DataTable GetProductInQCDetail(string _inputCode)
        {
            sbSql.Clear();
            sbSql.Append("select id, ");
            sbSql.Append("       name, ");
            sbSql.Append("       target , ");
            sbSql.Append("       case result when 0 then '不合格' when 1 then '合格' else '' end result ");
            sbSql.Append("from r_product_input_quality_detail ");
            sbSql.Append("where isDelete = 0 ");
            sbSql.Append("  and inputCode = '").Append(_inputCode).Append("' ");
            sbSql.Append("order by id ");

            return Dal.DBHelper.Select(sbSql.ToString());

        }

        public int AddUpdateProductInQC(ModelProductInQC _model)
        {
            List<string> listSql = new List<string>();

            if (_model.id > 0)
            {
                sbSql.Clear();
                sbSql.Append("update r_product_input_quality ");
                sbSql.Append("set inputCode = '" + _model.inputCode + "',");
                sbSql.Append("    inspecterId = " + _model.inspecterId + ",");
                sbSql.Append("    checkerId = " + _model.checkerId + ",");
                sbSql.Append("    inspectDate = '" + _model.inspectDate + "',");
                sbSql.Append("    inspectResult = " + _model.inspectResult + ",");
                sbSql.Append("    modifyBy = '" + _model.modifyBy + "',");
                sbSql.Append("    modifyTime = '" + _model.modifyTime + "' ");
                sbSql.Append("where id = " + _model.id);
                listSql.Add(sbSql.ToString());

                sbSql.Clear();
                sbSql.Append("update r_product_input_quality_detail ");
                sbSql.Append("set isDelete = 1,");
                sbSql.Append("    modifyBy = '" + _model.modifyBy + "',");
                sbSql.Append("    modifyTime = '" + _model.modifyTime + "' ");
                sbSql.Append("where inputCode = '" + _model.inputCode + "' ");
                listSql.Add(sbSql.ToString());

                if (_model.modelProductInQCDetail != null && _model.modelProductInQCDetail.Count > 0)
                {
                    foreach (ModelProductInQCDetail qcDetail in _model.modelProductInQCDetail)
                    {
                        if (qcDetail.id > 0)
                        {
                            sbSql.Clear();
                            sbSql.Append("update r_product_input_quality_detail ");
                            sbSql.Append("set inputCode = '" + qcDetail.inputCode + "',");
                            sbSql.Append("    name = '" + qcDetail.name + "',");
                            sbSql.Append("    target = '" + qcDetail.target + "',");
                            sbSql.Append("    result = '" + qcDetail.result + "',");
                            sbSql.Append("    isDelete = " + qcDetail.isDelete + ",");
                            sbSql.Append("    modifyBy = '" + qcDetail.modifyBy + "',");
                            sbSql.Append("    modifyTime = '" + qcDetail.modifyTime + "' ");
                            sbSql.Append("where id = " + qcDetail.id);
                            listSql.Add(sbSql.ToString());
                        }
                        else
                        {
                            sbSql.Clear();
                            sbSql.Append("insert into ");
                            sbSql.Append("       r_product_input_quality_detail ( ");
                            sbSql.Append("       inputCode, ");
                            sbSql.Append("       name, ");
                            sbSql.Append("       target, ");
                            sbSql.Append("       result, ");
                            sbSql.Append("       isDelete, ");
                            sbSql.Append("       createBy, ");
                            sbSql.Append("       createTime ");
                            sbSql.Append("       ) values ( ");
                            sbSql.Append("      '" + qcDetail.inputCode + "', ");
                            sbSql.Append("      '" + qcDetail.name + "', ");
                            sbSql.Append("      '" + qcDetail.target + "', ");
                            sbSql.Append("       " + qcDetail.result + ", ");
                            sbSql.Append("       " + qcDetail.isDelete + ", ");
                            sbSql.Append("      '" + qcDetail.createBy + "', ");
                            sbSql.Append("      '" + qcDetail.createTime + "')");
                            listSql.Add(sbSql.ToString());
                        }
                    }
                }
           }
            else
            {
                sbSql.Clear();
                sbSql.Append("insert into ");
                sbSql.Append("       r_product_input_quality ( ");
                sbSql.Append("       inputCode, ");
                sbSql.Append("       inspecterId, ");
                sbSql.Append("       checkerId, ");
                sbSql.Append("       inspectDate, ");
                sbSql.Append("       inspectResult, ");
                sbSql.Append("       isDelete, ");
                sbSql.Append("       createBy, ");
                sbSql.Append("       createTime ");
                sbSql.Append("       ) values ( ");
                sbSql.Append("      '" + _model.inputCode + "', ");
                sbSql.Append("       " + _model.inspecterId + ", ");
                sbSql.Append("       " + _model.checkerId + ", ");
                sbSql.Append("      '" + _model.inspectDate + "', ");
                sbSql.Append("       " + _model.inspectResult + ", ");
                sbSql.Append("       " + _model.isDelete + ", ");
                sbSql.Append("      '" + _model.createBy + "', ");
                sbSql.Append("      '" + _model.createTime + "')");
                listSql.Add(sbSql.ToString());

                if (_model.modelProductInQCDetail != null && _model.modelProductInQCDetail.Count > 0)
                {
                    foreach (ModelProductInQCDetail qcDetail in _model.modelProductInQCDetail)
                    {
                        sbSql.Clear();
                        sbSql.Append("insert into ");
                        sbSql.Append("       r_product_input_quality_detail ( ");
                        sbSql.Append("       inputCode, ");
                        sbSql.Append("       name, ");
                        sbSql.Append("       target, ");
                        sbSql.Append("       result, ");
                        sbSql.Append("       isDelete, ");
                        sbSql.Append("       createBy, ");
                        sbSql.Append("       createTime ");
                        sbSql.Append("       ) values ( ");
                        sbSql.Append("      '" + qcDetail.inputCode + "', ");
                        sbSql.Append("      '" + qcDetail.name + "', ");
                        sbSql.Append("      '" + qcDetail.target + "', ");
                        sbSql.Append("       " + qcDetail.result + ", ");
                        sbSql.Append("       " + qcDetail.isDelete + ", ");
                        sbSql.Append("      '" + qcDetail.createBy + "', ");
                        sbSql.Append("      '" + qcDetail.createTime + "')");
                        listSql.Add(sbSql.ToString());
                    }
                }
            }

            return Dal.DBHelper.ExcuteTransaction(listSql);
        }
    }
}
