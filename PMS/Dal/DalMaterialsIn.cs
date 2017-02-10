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
    public class DalMaterialsIn
    {
        string sql;
        StringBuilder sbSql = new StringBuilder();

        public DataTable GetMaterialsIn(String _materialsName, int _customerId, int _factoryId, DateTime _beginTime, DateTime _endTime, int _inputStatus)
        {
            sbSql.Clear();
            sbSql.Append("select a.id, ");
            sbSql.Append("       a.inputCode, ");
            sbSql.Append("       b.name factoryName, ");
            sbSql.Append("       c.name materialsName, ");
            sbSql.Append("       concat(a.inputNum, d.value1) numDisplay, ");
            sbSql.Append("       a.inputNum, ");
            sbSql.Append("       a.inputUnit, ");
            sbSql.Append("       a.purchaseCode, ");
            sbSql.Append("       a.purchaseBy purchaseName, ");
            sbSql.Append("       e.name customerName, ");
            sbSql.Append("       case a.inputStatus when 0 then '请求入库' else '完成入库' end inputStatus, ");
            sbSql.Append("       a.inputStatus inputStatusCode, ");
            sbSql.Append("       date_format(a.inputDate, '%Y-%m-%d') inputDate, ");
            sbSql.Append("       ifnull(f.cnt,0) outputCnt, ");
            sbSql.Append("       case ifnull(f.cnt,0) when 0 then '修改' else '查看' end modifyBtn, ");
            sbSql.Append("       '删除' deleteBtn ");
            sbSql.Append("from p_materials_input a ");
            sbSql.Append("left join m_factory b ");
            sbSql.Append("  on a.factoryId = b.id ");
            sbSql.Append("left join p_materials c ");
            sbSql.Append("  on a.materialsId = c.id ");
            sbSql.Append("left join m_code d ");
            sbSql.Append("  on a.inputUnit = d.subCode ");
            sbSql.Append(" and d.code = 3 ");
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
            sbSql.Append("  and (a.inputStatus = 0 or ( a.inputStatus = 1 ");
            sbSql.Append("  and a.inputDate >= '").Append(_beginTime).Append("' ");
            sbSql.Append("  and a.inputDate <= '").Append(_endTime).Append("')) ");
            sbSql.Append("order by a.modifyTime desc");

            return Dal.DBHelper.Select(sbSql.ToString());
        }

        public DataTable GetMaterialsInById(int _materialsId)
        {
            sbSql.Clear();
            sbSql.Append("select a.* ");
            sbSql.Append("from p_materials_input a ");
            sbSql.Append("where a.isDelete = 0 ");
            sbSql.Append("  and a.id = ").Append(_materialsId).Append(" ");

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
            sbSql.Append("       inputNum, ");
            sbSql.Append("       inputUnit, ");
            sbSql.Append("       produceDate, ");
            sbSql.Append("       expiresDate, ");
            sbSql.Append("       customerId, ");
            sbSql.Append("       purchaseCode, ");
            sbSql.Append("       purchaseBy, ");
            sbSql.Append("       purchaseDate, ");
            sbSql.Append("       purchaseNum, ");
            sbSql.Append("       purchaseUnit, ");
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
            sbSql.Append("       " + _model.inputNum + ", ");
            sbSql.Append("       " + _model.inputUnit + ", ");
            sbSql.Append("      '" + _model.produceDate + "', ");
            sbSql.Append("      '" + _model.expiresDate + "', ");
            sbSql.Append("       " + _model.customerId + ", ");
            sbSql.Append("      '" + _model.purchaseCode + "', ");
            sbSql.Append("      '" + _model.purchaseBy + "', ");
            sbSql.Append("      '" + _model.purchaseDate + "', ");
            sbSql.Append("       " + _model.purchaseNum + ", ");
            sbSql.Append("       " + _model.purchaseUnit + ", ");
            sbSql.Append("       " + _model.inputType + ", ");
            sbSql.Append("      " + _model.inputStatus + ", ");
            sbSql.Append("      '" + _model.inputDate + "', ");
            sbSql.Append("      '" + _model.remark + "', ");
            sbSql.Append("       " + _model.isDelete + ", ");
            sbSql.Append("      '" + _model.createBy + "', ");
            sbSql.Append("      '" + _model.createTime + "')");
            listSql.Add(sbSql.ToString());
            
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
            sbSql.Append("    inputNum = " + _model.inputNum + ",");
            sbSql.Append("    inputUnit = " + _model.inputUnit + ",");
            sbSql.Append("    produceDate = '" + _model.produceDate + "',");
            sbSql.Append("    expiresDate = '" + _model.expiresDate + "',");
            sbSql.Append("    customerId = " + _model.customerId + ",");
            sbSql.Append("    purchaseCode = '" + _model.purchaseCode + "',");
            sbSql.Append("    purchaseBy = '" + _model.purchaseBy + "',");
            sbSql.Append("    purchaseDate = '" + _model.purchaseDate + "',");
            sbSql.Append("    purchaseNum = " + _model.purchaseNum + ",");
            sbSql.Append("    purchaseUnit = " + _model.purchaseUnit + ",");
            sbSql.Append("    inputType = " + _model.inputType + ",");
            sbSql.Append("    inputStatus = " + _model.inputStatus + ",");
            sbSql.Append("    inputDate = '" + _model.inputDate + "',");
            sbSql.Append("    remark = '" + _model.remark + "',");
            sbSql.Append("    modifyBy = '" + _model.modifyBy + "',");
            sbSql.Append("    modifyTime = '" + _model.modifyTime + "' ");
            sbSql.Append("where id = " + _model.id);
            listSql.Add(sbSql.ToString());

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
            
            return Dal.DBHelper.ExcuteTransaction(listSql);
        }

    }
}
