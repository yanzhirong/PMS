using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Model;
using Enum;
using Common.Tools;
using MySql.Data.MySqlClient;

namespace Dal
{
    public class DalMaterialsIn
    {
        StringBuilder sbSql = new StringBuilder();

        public DataTable GetMaterialsIn(String _materialsName, int _customerId, int _factoryId, DateTime _beginTime, DateTime _endTime, int _inputStatus, int _isQC)
        {
            sbSql.Clear();
            sbSql.Append("select a.id, ");
            sbSql.Append("       a.inputCode, ");
            sbSql.Append("       b.name factoryName, ");
            sbSql.Append("       c.name materialsName, ");
            sbSql.Append("       a.inputNum, ");
            sbSql.Append("       a.purchaseCode, ");
            sbSql.Append("       a.purchaseBy purchaseName, ");
            sbSql.Append("       e.name customerName, ");
            sbSql.Append("       case a.inputStatus when 0 then '请求入库' else '完成入库' end inputStatus, ");
            sbSql.Append("       a.inputStatus inputStatusCode, ");
            sbSql.Append("       date_format(a.inputDate, '%Y-%m-%d') inputDate, ");
            sbSql.Append("       ifnull(f.cnt,0) outputCnt, ");
            sbSql.Append("       case ifnull(a.isQualified,0) when 0 then '无' else '有' end isQualified, ");
            sbSql.Append("       case ifnull(f.cnt,0) when 0 then '修改' else '查看' end modifyBtn, ");
            sbSql.Append("       '删除' deleteBtn ");
            sbSql.Append("from p_materials_input a ");
            sbSql.Append("left join m_factory b ");
            sbSql.Append("  on a.factoryId = b.id ");
            sbSql.Append("left join p_materials c ");
            sbSql.Append("  on a.materialsId = c.id ");
            sbSql.Append("left join p_customer e ");
            sbSql.Append("  on a.customerId = e.id ");
            sbSql.Append("left join (select count(*) cnt,inputCode ");
            sbSql.Append("             from h_materials_output_log ");
            sbSql.Append("            where isDelete = 0 ");
            sbSql.Append("            group by inputCode) f ");
            sbSql.Append("  on a.inputCode = f.inputCode ");
            sbSql.Append("where a.isDelete = 0 ");
            if (Common.Tools.StringUtils.IsNotBlank(_materialsName))
            {
                sbSql.Append("   and a.materialsId in (");
                sbSql.Append("                     select materialsId ");
                sbSql.Append("                       from r_materials_search ");
                sbSql.Append("                      where materialsName like '%").Append(_materialsName).Append("%' or upper(searchKey) like '%").Append(_materialsName.ToUpper()).Append("%') ");
            }
            if (_customerId > 0)
            {
                sbSql.Append("  and a.customerId = ").Append(_customerId).Append(" ");
            }
            if (_factoryId > 0)
            {
                sbSql.Append("  and a.factoryId = ").Append(_factoryId).Append(" ");
            }
            if (_inputStatus > -1)
            {
                sbSql.Append("  and a.inputStatus = ").Append(_inputStatus).Append(" ");
            }
            if (_isQC > -1)
            {
                sbSql.Append("  and ifnull(a.isQualified,0) = ").Append(_isQC).Append(" ");
            }
            sbSql.Append("  and (a.inputStatus = 0 or ( a.inputStatus = 1 ");
            sbSql.Append("  and a.inputDate >= '").Append(_beginTime).Append("' ");
            sbSql.Append("  and a.inputDate <= '").Append(_endTime).Append("')) ");
            sbSql.Append("order by a.modifyTime desc");

            return Dal.DBHelper.Select(sbSql.ToString());
        }

        public DataTable GetMaterialsInById(int _id)
        {
            sbSql.Clear();
            sbSql.Append("select a.* ");
            sbSql.Append("from p_materials_input a ");
            sbSql.Append("where a.isDelete = 0 ");
            sbSql.Append("  and a.id = ").Append(_id).Append(" ");

            return Dal.DBHelper.Select(sbSql.ToString());
        }

        public DataTable GetMaterialsInByMaterialsIdSpecsId(int _materialsId, int _specsId)
        {
            sbSql.Clear();
            sbSql.Append("select a.* ");
            sbSql.Append("from p_materials_input a ");
            sbSql.Append("where a.isDelete = 0 ");
            sbSql.Append("  and a.materialsId = ").Append(_materialsId).Append(" ");
            sbSql.Append("  and a.specsId = ").Append(_specsId).Append(" ");

            return Dal.DBHelper.Select(sbSql.ToString());
        }

        public DataTable GetMaterialsInByInputCode(string _inputCode)
        {
            sbSql.Clear();
            sbSql.Append("select a.* ");
            sbSql.Append("from p_materials_input a ");
            sbSql.Append("where a.isDelete = 0 ");
            sbSql.Append("  and a.inputCode = '").Append(_inputCode).Append("'");

            return Dal.DBHelper.Select(sbSql.ToString());
        }

        public int AddMaterialsIn(ModelMaterialsIn _model)
        {
            List<string> listSql = new List<string>();

            sbSql.Clear();
            sbSql.Append("insert into ");
            sbSql.Append("       p_materials_input ( ");
            sbSql.Append("       inputCode, ");
            sbSql.Append("       factoryId, ");
            sbSql.Append("       materialsId, ");
            sbSql.Append("       specsId, ");
            sbSql.Append("       inputNum, ");
            sbSql.Append("       stockNum, ");
            sbSql.Append("       produceDate, ");
            sbSql.Append("       expiresDate, ");
            sbSql.Append("       customerId, ");
            sbSql.Append("       purchaseCode, ");
            sbSql.Append("       purchaseBy, ");
            sbSql.Append("       purchaseDate, ");
            sbSql.Append("       purchaseNum, ");
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
            sbSql.Append("       " + _model.materialsId + ", ");
            sbSql.Append("       " + _model.specsId + ", ");
            sbSql.Append("       " + _model.inputNum + ", ");
            sbSql.Append("       " + _model.stockNum + ", ");
            sbSql.Append("      '" + _model.produceDate + "', ");
            sbSql.Append("      '" + _model.expiresDate + "', ");
            sbSql.Append("       " + _model.customerId + ", ");
            sbSql.Append("      '" + _model.purchaseCode + "', ");
            sbSql.Append("      '" + _model.purchaseBy + "', ");
            sbSql.Append("      '" + _model.purchaseDate + "', ");
            sbSql.Append("       " + _model.purchaseNum + ", ");
            sbSql.Append("       " + _model.inputType + ", ");
            sbSql.Append("      " + _model.inputStatus + ", ");
            sbSql.Append("      '" + _model.inputDate + "', ");
            sbSql.Append("      '" + _model.remark + "', ");
            sbSql.Append("       " + _model.isDelete + ", ");
            sbSql.Append("      '" + _model.createBy + "', ");
            sbSql.Append("      '" + _model.createTime + "')");
            listSql.Add(sbSql.ToString());
            
            if (StringUtils.IsNotBlank(_model.purchaseCode))
            {
                // 更新采购单状态
                sbSql.Clear();
                sbSql.Append("update p_purchase ");
                sbSql.Append("   set status = " + (int)Enum.EnumPurchaseOrderStatus.Complete + ",");
                sbSql.Append("       modifyBy = '" + _model.modifyBy + "',");
                sbSql.Append("       modifyTime = '" + _model.modifyTime + "' ");
                sbSql.Append(" where purchaseCode = '" + _model.purchaseCode + "' ");
                sbSql.Append("   and isDelete = 0 ");
                sbSql.Append("   and (select min(inputStatus) ");
                sbSql.Append("          from p_materials_input ");
                sbSql.Append("         where purchaseCode = '" + _model.purchaseCode + "' ");
                sbSql.Append("           and isDelete = 0) > 0");
                listSql.Add(sbSql.ToString());

                // 更新生产单状态
                sbSql.Clear();
                sbSql.Append("update p_produce ");
                sbSql.Append("   set status = " + (int)Enum.EnumProduceOrderStatus.Producing + ",");
                sbSql.Append("       modifyBy = '" + _model.modifyBy + "',");
                sbSql.Append("       modifyTime = '" + _model.modifyTime + "' ");
                sbSql.Append(" where isDelete = 0 ");
                sbSql.Append("   and (select min(status) ");
                sbSql.Append("          from p_purchase ");
                sbSql.Append("         where isDelete = 0 ");
                sbSql.Append("           and produceCode = (select min(produceCode) ");
                sbSql.Append("                                from p_purchase ");
                sbSql.Append("                               where purchaseCode = '" + _model.purchaseCode + "' ");
                sbSql.Append("                                 and isDelete = 0 ");
                sbSql.Append("                                 and ifnull(produceCode,'') != '') ");
                sbSql.Append("       ) = " + (int)Enum.EnumPurchaseOrderStatus.Complete);
                listSql.Add(sbSql.ToString());
            }

            return Dal.DBHelper.ExcuteTransaction(listSql);
        }

        public int UpdateMaterialsIn(ModelMaterialsIn _model)
        {
            List<string> listSql = new List<string>();

            sbSql.Clear();
            sbSql.Append("update p_materials_input ");
            sbSql.Append("set inputCode = '" + _model.inputCode + "',");
            sbSql.Append("    factoryId = " + _model.factoryId + ",");
            sbSql.Append("    materialsId = " + _model.materialsId + ",");
            sbSql.Append("    specsId = " + _model.specsId + ",");
            sbSql.Append("    inputNum = " + _model.inputNum + ",");
            sbSql.Append("    stockNum = " + _model.stockNum + ",");
            sbSql.Append("    produceDate = '" + _model.produceDate + "',");
            sbSql.Append("    expiresDate = '" + _model.expiresDate + "',");
            sbSql.Append("    customerId = " + _model.customerId + ",");
            sbSql.Append("    purchaseCode = '" + _model.purchaseCode + "',");
            sbSql.Append("    purchaseBy = '" + _model.purchaseBy + "',");
            sbSql.Append("    purchaseDate = '" + _model.purchaseDate + "',");
            sbSql.Append("    purchaseNum = " + _model.purchaseNum + ",");
            sbSql.Append("    inputType = " + _model.inputType + ",");
            sbSql.Append("    inputStatus = " + _model.inputStatus + ",");
            sbSql.Append("    inputDate = '" + _model.inputDate + "',");
            sbSql.Append("    remark = '" + _model.remark + "',");
            sbSql.Append("    modifyBy = '" + _model.modifyBy + "',");
            sbSql.Append("    modifyTime = '" + _model.modifyTime + "' ");
            sbSql.Append("where id = " + _model.id);
            listSql.Add(sbSql.ToString());

            if (StringUtils.IsNotBlank(_model.purchaseCode))
            {
                // 更新采购单状态
                sbSql.Clear();
                sbSql.Append("update p_purchase ");
                sbSql.Append("   set status = " + (int)Enum.EnumPurchaseOrderStatus.Complete + ",");
                sbSql.Append("       modifyBy = '" + _model.modifyBy + "',");
                sbSql.Append("       modifyTime = '" + _model.modifyTime + "' ");
                sbSql.Append(" where purchaseCode = '" + _model.purchaseCode + "' ");
                sbSql.Append("   and isDelete = 0 ");
                sbSql.Append("   and (select min(inputStatus) ");
                sbSql.Append("          from p_materials_input ");
                sbSql.Append("         where purchaseCode = '" + _model.purchaseCode + "' ");
                sbSql.Append("           and isDelete = 0) > 0");
                listSql.Add(sbSql.ToString());

                // 更新生产单状态
                sbSql.Clear();
                sbSql.Append("update p_produce ");
                sbSql.Append("   set status = " + (int)Enum.EnumProduceOrderStatus.Producing + ",");
                sbSql.Append("       modifyBy = '" + _model.modifyBy + "',");
                sbSql.Append("       modifyTime = '" + _model.modifyTime + "' ");
                sbSql.Append(" where isDelete = 0 ");
                sbSql.Append("   and (select min(status) ");
                sbSql.Append("          from p_purchase ");
                sbSql.Append("         where isDelete = 0 ");
                sbSql.Append("           and purchaseCode in ");
                sbSql.Append("               (select purchaseCode ");
                sbSql.Append("                  from p_purchase_apply ");
                sbSql.Append("                 where isDelete = 0 ");
                sbSql.Append("                   and produceCode in ");
                sbSql.Append("                       (select produceCode ");
                sbSql.Append("                          from p_purchase_apply ");
                sbSql.Append("                         where purchaseCode = '" + _model.purchaseCode + "' ");
                sbSql.Append("                           and isDelete = 0 ");
                sbSql.Append("                           and ifnull(produceCode,'') != '') ");
                sbSql.Append("       )) = " + (int)Enum.EnumPurchaseOrderStatus.Complete);
                listSql.Add(sbSql.ToString());
            } 
            
            return Dal.DBHelper.ExcuteTransaction(listSql);
        }

        public int DeleteMaterialsIn(ModelMaterialsIn _model)
        {
            List<string> listSql = new List<string>();

            sbSql.Clear();
            sbSql.Append("update p_materials_input ");
            sbSql.Append("set isDelete = 1,");
            sbSql.Append("    modifyBy = '" + _model.modifyBy + "',");
            sbSql.Append("    modifyTime = '" + _model.modifyTime + "' ");
            sbSql.Append("where id = " + _model.id);
            listSql.Add(sbSql.ToString());

            sbSql.Clear();
            sbSql.Append("update r_materials_input_quality ");
            sbSql.Append("set isDelete = 1,");
            sbSql.Append("    modifyBy = '" + _model.modifyBy + "',");
            sbSql.Append("    modifyTime = '" + _model.modifyTime + "' ");
            sbSql.Append("where inputCode = '" + _model.inputCode + "' ");
            sbSql.Append("  and isDelete = 0 ");
            listSql.Add(sbSql.ToString());
           
            return Dal.DBHelper.ExcuteTransaction(listSql);
        }

        public DataTable GetMaterialsInQCByInputCode(string _inputCode)
        {
            string sql = @"select id,
                                  QCName,
                                  remark,
                                  '参照' reviewBtn,
                                  '删除' deleteBtn  
                      from r_materials_input_quality
                     where isDelete = 0
                       and inputCode = '{0}'";

            sql = String.Format(sql, _inputCode);

            return Dal.DBHelper.Select(sql);
        }

        public DataTable GetQCById(int _QCId)
        {
            string sql = @"select * 
                      from r_materials_input_quality
                     where isDelete = 0
                       and id = {0}";

            sql = String.Format(sql, _QCId);

            return Dal.DBHelper.Select(sql);
        }

        public int AddMaterialsInQC(ModelMaterialsInQC _model)
        {

            sbSql.Clear();
            sbSql.Append("insert into ");
            sbSql.Append("       r_materials_input_quality ( ");
            sbSql.Append("       inputCode, ");
            sbSql.Append("       factoryId, ");
            sbSql.Append("       materialsId, ");
            sbSql.Append("       specsId, ");
            sbSql.Append("       QCName, ");
            sbSql.Append("       QCImage, ");
            sbSql.Append("       remark, ");
            sbSql.Append("       isDelete, ");
            sbSql.Append("       createBy, ");
            sbSql.Append("       createTime ");
            sbSql.Append("       ) value ( ");
            sbSql.Append("      '" + _model.inputCode + "', ");
            sbSql.Append("       " + _model.factoryId + ", ");
            sbSql.Append("       " + _model.materialsId + ", ");
            sbSql.Append("       " + _model.specsId + ", ");
            sbSql.Append("      '" + _model.QCName + "', ");
            sbSql.Append("       @QCImage, ");
            sbSql.Append("      '" + _model.remark + "', ");
            sbSql.Append("       " + _model.isDelete + ", ");
            sbSql.Append("      '" + _model.createBy + "', ");
            sbSql.Append("      '" + _model.createTime + "')");

            List<MySqlParameter> listParam = new List<MySqlParameter>();

            MySqlParameter paramIn = new MySqlParameter();
            paramIn.ParameterName = "@QCImage";
            paramIn.MySqlDbType = MySqlDbType.LongBlob;
            paramIn.Value = _model.QCImage;
            paramIn.Direction = ParameterDirection.Input;
            listParam.Add(paramIn);

            return Dal.DBHelper.ExcuteParam(sbSql.ToString(), listParam);
        }

        public int DeleteMaterialsInQC(ModelMaterialsInQC _model)
        {
            sbSql.Clear();
            sbSql.Append("update r_materials_input_quality ");
            sbSql.Append("set isDelete = 1,");
            sbSql.Append("    modifyBy = '" + _model.modifyBy + "',");
            sbSql.Append("    modifyTime = '" + _model.modifyTime + "' ");
            sbSql.Append("where id = " + _model.id);
            sbSql.Append("  and isDelete = 0");

            return Dal.DBHelper.Excute(sbSql.ToString());
        }

        public int UpdateMaterialsInQC(string _inputCode)
        {
            sbSql.Clear();
            sbSql.Append("update p_materials_input ");
            sbSql.Append("set isQualified = (select case when count(*) > 0 then 1 else 0 end from r_materials_input_quality where inputCode = '" + _inputCode + "' and IsDelete = 0 )");
            sbSql.Append("where inputCode = '" + _inputCode + "'");
            sbSql.Append("  and isDelete = 0");

            return Dal.DBHelper.Excute(sbSql.ToString());
        }
    }
}
