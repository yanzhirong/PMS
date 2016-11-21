using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Model;

namespace Dal
{
    public class DalCode
    {
        string sql;
        StringBuilder sbSql = new StringBuilder();

        public DataTable GetAllCodeName()
        {
            sql = @"select code itemKey,
                           remark itemValue 
                      from m_code
                     where isDelete = 0
                       and ifnull(subCode,0) = 0
                       and ifnull(remark,'') <> ''
                     order by code";

            return Dal.DBHelper.Select(sql);
        }
        public DataTable GetCodeByName(string _codeName)
        {
       
            sql = @"select * 
                    from m_code
                    where remark = '{0}'
                    and ifnull(subCode,0) = 0
                    and isDelete = 0
                    order by id desc";

            sql = string.Format(sql, _codeName);
            
            return Dal.DBHelper.Select(sql);
        }

        public DataTable GetCode(int _code, Boolean _isSearchBlank)
        {
            if (_isSearchBlank)
            {
                sql = @"select * 
                      from m_code
                     where code = {0}
                       and isDelete = 0
                     order by id";

                sql = string.Format(sql, _code);
            }
            else
            {
                sql = @"select * 
                      from m_code
                     where code = {0}
                       and ifnull(subCode, 0) > 0
                       and isDelete = 0
                     order by id";

                sql = string.Format(sql, _code);
            }

            return Dal.DBHelper.Select(sql);
        }

        public DataTable GetSubCode(int _code, int _subCode)
        {
            sql = @"select * 
                      from m_code
                     where code = {0}
                       and subCode = {1}
                       and isDelete = 0
                     order by id desc";

            sql = string.Format(sql, _code, _subCode);

            return Dal.DBHelper.Select(sql);
        }

        public int AddCode(ModelCode _modelCode)
        {
            sbSql.Clear();
            sbSql.Append("insert into  ");
            sbSql.Append(" m_code ( ");
            sbSql.Append(" code, ");
            sbSql.Append(" remark, ");
            sbSql.Append(" isDelete, ");
            sbSql.Append(" createBy, ");
            sbSql.Append(" createTime, ");
            sbSql.Append(" modifyBy, ");
            sbSql.Append(" modifyTime) ");
            sbSql.Append(" select max(code) + 1 code, ");
            sbSql.Append("       '" + _modelCode.remark + "', ");
            sbSql.Append("        " + _modelCode.isDelete + ", ");
            sbSql.Append("       '" + _modelCode.createBy + "', ");
            sbSql.Append("       '" + _modelCode.createTime + "', ");
            sbSql.Append("       '" + _modelCode.modifyBy + "', ");
            sbSql.Append("       '" + _modelCode.modifyTime + "'");
            sbSql.Append(" from m_code ");

            return DBHelper.Excute(sbSql.ToString());
        }

        public int UpdateCode(List<ModelCode> _listCode)
        {
            List<string> listSql = new List<string>();

            sbSql.Clear();
            sbSql.Append("update m_code ");
            sbSql.Append("   set isDelete = 1, ");
            sbSql.Append("       modifyBy = '" + _listCode[0].modifyBy + "', ");
            sbSql.Append("       modifyTime = '" + _listCode[0].modifyTime + "' ");
            sbSql.Append(" where code = " + _listCode[0].code + ", ");
            sbSql.Append("   and ifnull(subCode,0) > 0 ");
            sbSql.Append("   and isDelete = 0 ");

            listSql.Add(sbSql.ToString());

            foreach (ModelCode modelCode in _listCode)
            {
                sbSql.Clear();
                if (modelCode.id > 0)
                {
                    sbSql.Append("update m_code ");
                    sbSql.Append("   set value1 = '" + modelCode.value1 + "', ");
                    sbSql.Append("       value2 = '" + modelCode.value2 + "', ");
                    sbSql.Append("       value3 = '" + modelCode.value3 + "', ");
                    sbSql.Append("       remark = '" + modelCode.remark + "', ");
                    sbSql.Append("       isDelete = 0, ");
                    sbSql.Append("       modifyBy = '" + modelCode.modifyBy + "', ");
                    sbSql.Append("       modifyTime = '" + modelCode.modifyTime + "' ");
                    sbSql.Append(" where id = " + modelCode.id + ", ");
                }
                else
                {
                    sbSql.Append("insert into  ");
                    sbSql.Append(" m_code ( ");
                    sbSql.Append(" code, ");
                    sbSql.Append(" subCode, ");
                    sbSql.Append(" value1, ");
                    sbSql.Append(" value2, ");
                    sbSql.Append(" value3, ");
                    sbSql.Append(" remark, ");
                    sbSql.Append(" isDelete, ");
                    sbSql.Append(" createBy, ");
                    sbSql.Append(" createTime, ");
                    sbSql.Append(" modifyBy, ");
                    sbSql.Append(" modifyTime) ");
                    sbSql.Append(" select ");
                    sbSql.Append("        " + modelCode.code + ", ");
                    sbSql.Append("        max(subCode) + 1 subCode, ");
                    sbSql.Append("       '" + modelCode.value1 + "', ");
                    sbSql.Append("       '" + modelCode.value2 + "', ");
                    sbSql.Append("       '" + modelCode.value3 + "', ");
                    sbSql.Append("       '" + modelCode.remark + "', ");
                    sbSql.Append("        " + modelCode.isDelete + ", ");
                    sbSql.Append("       '" + modelCode.createBy + "', ");
                    sbSql.Append("       '" + modelCode.createTime + "', ");
                    sbSql.Append("       '" + modelCode.modifyTime + "', ");
                    sbSql.Append("       '" + modelCode.modifyTime + "'");
                }

                listSql.Add(sbSql.ToString());
            }
            return DBHelper.ExcuteTransaction(listSql);
        }

    }
}
