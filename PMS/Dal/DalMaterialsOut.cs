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
    public class DalMaterialsOut
    {
        StringBuilder sbSql = new StringBuilder();

        public DataTable GetMaterialsOut(String _materialsName, int _applyMemberId, int _factoryId, DateTime _beginTime, DateTime _endTime, int _outputStatus)
        {
            sbSql.Clear();
            sbSql.Append("select a.id, ");
            sbSql.Append("       b.name factoryName, ");
            sbSql.Append("       a.outputCode, ");
            sbSql.Append("       c.name materialsName, ");
            sbSql.Append("       d.userName applyBy, ");
            sbSql.Append("       a.produceCode, ");
            sbSql.Append("       concat(a.outputNum,e.value1) numDisplay, ");
            sbSql.Append("       date_format(a.applyDate, '%Y-%m-%d') applyDate, ");
            sbSql.Append("       a.outputStatus outputStatusCode, ");
            sbSql.Append("       ifnull(f.cnt,0) outputCnt, ");
            sbSql.Append("       case a.outputStatus when 0 then '请求出库' else '完成出库' end outputStatus, ");
            sbSql.Append("       case a.outputStatus when 0 then '修改' else '查看' end modifyBtn, ");
            sbSql.Append("       '删除' deleteBtn ");
            sbSql.Append("from p_materials_output a ");
            sbSql.Append("left join m_factory b ");
            sbSql.Append("  on a.factoryId = b.id ");
            sbSql.Append("left join p_materials c ");
            sbSql.Append("  on a.materialsId = c.id ");
            sbSql.Append("left join m_user d ");
            sbSql.Append("  on a.applyMemberId = d.userId ");
            sbSql.Append("left join m_code e ");
            sbSql.Append("  on a.outputUnit = e.subCode ");
            sbSql.Append(" and e.code = 3 ");
            sbSql.Append("left join (select count(*) cnt,outputCode ");
            sbSql.Append("             from h_materials_output_log ");
            sbSql.Append("            where isDelete = 0 ");
            sbSql.Append("            group by outputCode) f ");
            sbSql.Append("  on a.outputCode = f.outputCode ");
            sbSql.Append("where a.isDelete = 0 ");
            if (Common.Tools.StringUtils.IsNotBlank(_materialsName))
            {
                sbSql.Append("   and a.materialsId in (");
                sbSql.Append("                     select materialsId ");
                sbSql.Append("                       from r_materials_search ");
                sbSql.Append("                      where materialsName like '%").Append(_materialsName).Append("%' or upper(searchKey) like '%").Append(_materialsName.ToUpper()).Append("%') ");
            }
            if (_applyMemberId > 0)
            {
                sbSql.Append("  and c.applyMemberId = ").Append(_applyMemberId).Append(" ");
            }
            if (_factoryId > 0)
            {
                sbSql.Append("  and a.factoryId = ").Append(_factoryId).Append(" ");
            }
            if (_outputStatus > -1)
            {
                sbSql.Append("  and a.outputStatus = ").Append(_outputStatus).Append(" ");
            }
            sbSql.Append("  and (a.outputStatus = 0 or ( a.outputStatus = 1 ");
            sbSql.Append("  and a.outputDate >= '").Append(_beginTime).Append("' ");
            sbSql.Append("  and a.outputDate <= '").Append(_endTime).Append("')) ");
            sbSql.Append("order by a.modifyTime desc");

            return Dal.DBHelper.Select(sbSql.ToString());
        }

        public DataTable GetMaterialsOutById(int _materialsOutId)
        {
            sbSql.Clear();
            sbSql.Append("select a.* ");
            sbSql.Append("from p_materials_output a ");
            sbSql.Append("where a.isDelete = 0 ");
            sbSql.Append("  and a.id = ").Append(_materialsOutId).Append(" ");

            return Dal.DBHelper.Select(sbSql.ToString());
        }

        public DataTable GetOutputNum(string _outputCode)
        {
            sbSql.Clear();
            sbSql.Append("select a.outputNum num, a.outputUnit unit ");
            sbSql.Append("from h_materials_output_log a ");
            sbSql.Append("where a.isDelete = 0 ");
            sbSql.Append("  and a.outputCode = '").Append(_outputCode).Append("' ");

            return Dal.DBHelper.Select(sbSql.ToString());
        }

        public DataTable GetMaterialsOutByOutputCode(string _outputCode)
        {
            sbSql.Clear();
            sbSql.Append("select a.* ");
            sbSql.Append("from p_materials_output a ");
            sbSql.Append("where a.isDelete = 0 ");
            sbSql.Append("  and a.outputCode = '").Append(_outputCode).Append("'");

            return Dal.DBHelper.Select(sbSql.ToString());
        }

        public int AddMaterialsOut(ModelMaterialsOutput _model)
        {
            List<string> listSql = new List<string>();

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
            sbSql.Append("       outputDate, ");
            sbSql.Append("       outputType, ");
            sbSql.Append("       applyMemberId, ");
            sbSql.Append("       applyDate, ");
            sbSql.Append("       remark, ");
            sbSql.Append("       isDelete, ");
            sbSql.Append("       createBy, ");
            sbSql.Append("       createTime ");
            sbSql.Append("       ) values ( ");
            sbSql.Append("      '" + _model.outputCode + "', ");
            sbSql.Append("      '" + _model.produceCode + "', ");
            sbSql.Append("       " + _model.factoryId + ", ");
            sbSql.Append("       " + _model.materialsId + ", ");
            sbSql.Append("       " + _model.outputNum + ", ");
            sbSql.Append("       " + _model.outputUnit + ", ");
            sbSql.Append("       " + _model.outputStatus + ", ");
            sbSql.Append("      '" + _model.outputDate + "', ");
            sbSql.Append("       " + _model.outputType + ", ");
            sbSql.Append("       " + _model.applyMemberId + ", ");
            sbSql.Append("      '" + _model.applyDate + "', ");
            sbSql.Append("      '" + _model.remark + "', ");
            sbSql.Append("       " + _model.isDelete + ", ");
            sbSql.Append("      '" + _model.createBy + "', ");
            sbSql.Append("      '" + _model.createTime + "')");
            listSql.Add(sbSql.ToString());
            
            return Dal.DBHelper.ExcuteTransaction(listSql);
        }

        public int UpdateMaterialsOut(ModelMaterialsOutput _model)
        {
            List<string> listSql = new List<string>();

            sbSql.Clear();
            sbSql.Append("update p_materials_output ");
            sbSql.Append("set outputCode = '" + _model.outputCode + "',");
            sbSql.Append("    produceCode = '" + _model.produceCode + "',");
            sbSql.Append("    factoryId = " + _model.factoryId + ",");
            sbSql.Append("    materialsId = " + _model.materialsId + ",");
            sbSql.Append("    outputNum = " + _model.outputNum + ",");
            sbSql.Append("    outputUnit = " + _model.outputUnit + ",");
            sbSql.Append("    outputStatus = " + _model.outputStatus + ",");
            sbSql.Append("    outputDate = '" + _model.outputDate + "',");
            sbSql.Append("    outputType = " + _model.outputType + ",");
            sbSql.Append("    applyMemberId = " + _model.applyMemberId + ",");
            sbSql.Append("    applyDate = '" + _model.applyDate + "',");
            sbSql.Append("    remark = '" + _model.remark + "',");
            sbSql.Append("    modifyBy = '" + _model.modifyBy + "',");
            sbSql.Append("    modifyTime = '" + _model.modifyTime + "' ");
            sbSql.Append("where id = " + _model.id);
            listSql.Add(sbSql.ToString());

            return Dal.DBHelper.ExcuteTransaction(listSql);
        }

        public int DeleteMaterialsOut(ModelMaterialsOutput _model)
        {
            List<string> listSql = new List<string>();

            sbSql.Clear();
            sbSql.Append("update p_materials_output ");
            sbSql.Append("set isDelete = 1,");
            sbSql.Append("    modifyBy = '" + _model.modifyBy + "',");
            sbSql.Append("    modifyTime = '" + _model.modifyTime + "' ");
            sbSql.Append("where id = " + _model.id);
            listSql.Add(sbSql.ToString());
            
            return Dal.DBHelper.ExcuteTransaction(listSql);
        }

        public DataTable GetMaterialsOutSelect(int _factoryId, int _materialsId)
        {
            sbSql.Clear();
            sbSql.Append("select a.id, ");
            sbSql.Append("       a.inputCode, ");
            sbSql.Append("       b.name materialsName, ");
            sbSql.Append("       concat(a.inputNum, c.value1) numDisplay, ");
            sbSql.Append("       a.inputNum, ");
            sbSql.Append("       a.inputUnit, ");
            sbSql.Append("       date_format(a.expiresDate, '%Y-%m-%d') expiresDate ");
            sbSql.Append("from p_materials_input a ");
            sbSql.Append("join p_materials b ");
            sbSql.Append("  on a.materialsId = b.id ");
            sbSql.Append("join m_code c ");
            sbSql.Append("  on a.inputUnit = c.subCode ");
            sbSql.Append(" and c.code = 3 ");
            sbSql.Append("where a.isDelete = 0 ");
            sbSql.Append("  and a.factoryId = ").Append(_factoryId).Append(" ");
            sbSql.Append("  and a.materialsId = ").Append(_materialsId).Append(" ");
            sbSql.Append("  and a.inputNum > 0 ");
            sbSql.Append("  and a.inputStatus = 1 ");
            sbSql.Append("order by a.expiresDate ");

            return Dal.DBHelper.Select(sbSql.ToString());

        }

        public int doOutPut(string _outputCode, int _factoryId, int _materialsId, decimal _outputNum, int _applyMemberId, List<Dictionary<string, object>> listOutput, string userName)
        {
            List<string> listSql = new List<string>();

            foreach (Dictionary<string, object> dc in listOutput)
            {
                //出库记录
                sbSql.Clear();
                sbSql.Append("insert into ");
                sbSql.Append("       h_materials_output_log ( ");
                sbSql.Append("       outputCode, ");
                sbSql.Append("       inputCode, ");
                sbSql.Append("       factoryId, ");
                sbSql.Append("       materialsId, ");
                sbSql.Append("       applyMemberId, ");
                sbSql.Append("       outputNum, ");
                sbSql.Append("       outputUnit, ");
                sbSql.Append("       outputDate, ");
                sbSql.Append("       isDelete, ");
                sbSql.Append("       createBy, ");
                sbSql.Append("       createTime ");
                sbSql.Append("       ) values ( ");
                sbSql.Append("      '" + _outputCode + "', ");
                sbSql.Append("      '" + ConvertUtils.ConvertToString(dc["inputCode"]) + "', ");
                sbSql.Append("       " + _factoryId + ", ");
                sbSql.Append("       " + _materialsId + ", ");
                sbSql.Append("       " + _applyMemberId + ", ");
                sbSql.Append("       " + ConvertUtils.ConvertToDecimal(dc["outputNum"]) + ", ");
                sbSql.Append("       " + ConvertUtils.ConvertToInt(dc["outputUnit"]) + ", ");
                sbSql.Append("      '" + DateTime.Now + "', ");
                sbSql.Append("       0, ");
                sbSql.Append("      '" + userName + "', ");
                sbSql.Append("      '" + DateTime.Now + "')");
                listSql.Add(sbSql.ToString());

                //减少库存
                sbSql.Clear();
                sbSql.Append("update p_materials_input ");
                sbSql.Append("set inputNum = ").Append(ConvertUtils.ConvertToDecimal(dc["stockNum"])).Append(",");
                sbSql.Append("    modifyBy = '" + userName + "',");
                sbSql.Append("    modifyTime = '" + DateTime.Now + "' ");
                sbSql.Append("where id = " + ConvertUtils.ConvertToInt(dc["inputId"]));
                listSql.Add(sbSql.ToString());

            }

            sbSql.Clear();
            sbSql.Append("update p_materials_output ");
            sbSql.Append("   set realityOutputNum = ifnull(realityOutputNum,0) + " + _outputNum + ", ");
            sbSql.Append("       outputDate = '" + DateTime.Now + "', ");
            sbSql.Append("       modifyBy = '" + userName + "',");
            sbSql.Append("       modifyTime = '" + DateTime.Now + "' ");
            sbSql.Append(" where outputCode = '").Append(_outputCode).Append("'");
            sbSql.Append("   and isDelete = 0 ");
            listSql.Add(sbSql.ToString());

            sbSql.Clear();
            sbSql.Append("update p_materials_output ");
            sbSql.Append("   set outputStatus = 1, ");
            sbSql.Append("       modifyBy = '" + userName + "',");
            sbSql.Append("       modifyTime = '" + DateTime.Now + "' ");
            sbSql.Append(" where outputCode = '").Append(_outputCode).Append("'");
            sbSql.Append("   and isDelete = 0 ");
            sbSql.Append("   and (realityOutputNum >= outputNum or ifnull(outputNum, 0) <= 0) ");
            listSql.Add(sbSql.ToString());
            return Dal.DBHelper.ExcuteTransaction(listSql);

        }
    }
}
