using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Model;

namespace Dal
{
    public class DalMaterials
    {
        string sql;
        StringBuilder sbSql = new StringBuilder();

        public DataTable GetMaterials(string _name)
        {
            sbSql.Clear();
            sbSql.Append("select a.id, ");
            sbSql.Append("       a.name, ");
            sbSql.Append("       a.subName, ");
            sbSql.Append("       b.value1 packingType, ");
            sbSql.Append("       a.weight + c.value1 weight, ");
            sbSql.Append("       b.value1 morphology, ");
            sbSql.Append("       a.shelfLife, ");
            sbSql.Append("       '修改' modifyBtn, ");
            sbSql.Append("       '删除' deleteBtn ");
            sbSql.Append("from m_materials a ");
            sbSql.Append("left join m_code b ");
            sbSql.Append("  on a.packingType = b.subCode and b.code = 1 ");
            sbSql.Append("left join m_code c ");
            sbSql.Append("  on a.weightUnit = c.subCode and c.code = 3 ");
            sbSql.Append("left join m_code d ");
            sbSql.Append("  on a.morphology = d.subCode and d.code = 2 ");
            sbSql.Append("where a.isDelete = 0 ");
            if(Common.Tools.StringUtils.IsNotBlank(_name))
            {
                sbSql.Append("  and a.name like '%").Append(_name).Append("%' ");
            }

            sbSql.Append("order by a.modifyTime desc");

            return Dal.DBHelper.Select(sbSql.ToString());
        }

        public DataTable GetMaterialsById(int _materialsId)
        {
            sql = @"select * 
                      from m_materials
                     where isDelete = 0
                       and id = {0}";

            sql = String.Format(sql, _materialsId);

            return Dal.DBHelper.Select(sql);
        }

        public DataTable GetMaterialsSearchById(int _materialsId)
        {
            sql = @"select * 
                      from m_materialsSearch
                     where isDelete = 0
                       and materialsId = {0}";

            sql = String.Format(sql, _materialsId);

            return Dal.DBHelper.Select(sql);
        }

        public DataTable GetMaterialsPriceById(int _materialsId)
        {
            sql = @"select * 
                      from m_materialsSearchPrice
                     where isDelete = 0
                       and materialsId = {0}";

            sql = String.Format(sql, _materialsId);

            return Dal.DBHelper.Select(sql);
        }

        public DataTable GetMaterialsByName(string _name)
        {
            sql = @"select * 
                      from m_materials
                     where isDelete = 0
                       and name = '{0}'";

            sql = String.Format(sql, _name);

            return Dal.DBHelper.Select(sql);
        }

        public int AddMaterials(ModelMaterials _modelMaterials)
        {
            List<string> listSql = new List<string>();

            sbSql.Clear();
            sbSql.Append("insert into ");
            sbSql.Append("       m_materials ( ");
            sbSql.Append("       name, ");
            sbSql.Append("       subName, ");
            sbSql.Append("       packingType, ");
            sbSql.Append("       packingRemark, ");
            sbSql.Append("       weight, ");
            sbSql.Append("       weightUnit, ");
            sbSql.Append("       morphology, ");
            sbSql.Append("       shelfLife, ");
            sbSql.Append("       expiredDays, ");
            sbSql.Append("       minStockNum, ");
            sbSql.Append("       isDelete, ");
            sbSql.Append("       createBy, ");
            sbSql.Append("       createTime, ");
            sbSql.Append("       modifyBy, ");
            sbSql.Append("       modifyTime ");
            sbSql.Append("       ) value ( ");
            sbSql.Append("      '" + _modelMaterials.name + "', ");
            sbSql.Append("      '" + _modelMaterials.subName + "', ");
            sbSql.Append("       " + _modelMaterials.packingType + ", ");
            sbSql.Append("      '" + _modelMaterials.packingRemark + "', ");
            sbSql.Append("       " + _modelMaterials.weight + ", ");
            sbSql.Append("       " + _modelMaterials.weightUnit + ", ");
            sbSql.Append("       " + _modelMaterials.morphology + ", ");
            sbSql.Append("       " + _modelMaterials.shelfLife + ", ");
            sbSql.Append("       " + _modelMaterials.expiredDays + ", ");
            sbSql.Append("       " + _modelMaterials.minStockNum + ", ");
            sbSql.Append("       " + _modelMaterials.isDelete + ", ");
            sbSql.Append("      '" + _modelMaterials.createBy + "', ");
            sbSql.Append("      '" + _modelMaterials.createTime + "', ");
            sbSql.Append("      '" + _modelMaterials.modifyBy + "', ");
            sbSql.Append("      '" + _modelMaterials.modifyTime + "')");

            listSql.Add(sbSql.ToString());

            if (_modelMaterials.modelMaterialsSearch != null)
            {
                sbSql.Clear();
                sbSql.Append("insert into ");
                sbSql.Append("       m_materialsSearch ( ");
                sbSql.Append("       materialsId, ");
                sbSql.Append("       materialsName, ");
                sbSql.Append("       searchKey) ");
                sbSql.Append("select id, ");
                sbSql.Append("       '" + _modelMaterials.modelMaterialsSearch.materialsName + "', ");
                sbSql.Append("       '" + _modelMaterials.modelMaterialsSearch.searchKey + "' ");
                sbSql.Append("  from m_materials ");
                sbSql.Append(" where name = '" + _modelMaterials.name + "'");
                sbSql.Append(" order by id desc ");
                sbSql.Append(" limit 0,1 ");

                listSql.Add(sbSql.ToString());
            }

            if (_modelMaterials.modelMaterialsPrice != null)
            {
                sbSql.Clear();
                sbSql.Append("insert into ");
                sbSql.Append("       m_materialsPrice ( ");
                sbSql.Append("       materialsId, ");
                sbSql.Append("       materialsName, ");
                sbSql.Append("       price, ");
                sbSql.Append("       priceUnit) ");
                sbSql.Append("select id, ");
                sbSql.Append("       '" + _modelMaterials.modelMaterialsPrice.materialsName + "', ");
                sbSql.Append("        " + _modelMaterials.modelMaterialsPrice.price + ", ");
                sbSql.Append("        " + _modelMaterials.modelMaterialsPrice.priceUnit + " ");
                sbSql.Append("  from m_materials ");
                sbSql.Append(" where name = '" + _modelMaterials.name + "'");
                sbSql.Append(" order by id desc ");
                sbSql.Append(" limit 0,1 ");

                listSql.Add(sbSql.ToString());
            }
            return Dal.DBHelper.ExcuteTransaction(listSql);
        }

        public int UpdateMaterials(ModelMaterials _modelMaterials)
        {
            List<string> listSql = new List<string>();

            sbSql.Clear();
            sbSql.Append("update m_materials ");
            sbSql.Append("set name = '" + _modelMaterials.name + "',");
            sbSql.Append("    subName = '" + _modelMaterials.subName + "',");
            sbSql.Append("    packingType = " + _modelMaterials.packingType + ",");
            sbSql.Append("    packingRemark = '" + _modelMaterials.packingRemark + "',");
            sbSql.Append("    weight = " + _modelMaterials.weight + ",");
            sbSql.Append("    weightUnit = " + _modelMaterials.weightUnit + ",");
            sbSql.Append("    morphology = " + _modelMaterials.morphology + ",");
            sbSql.Append("    shelfLife = " + _modelMaterials.shelfLife + ",");
            sbSql.Append("    expiredDays = " + _modelMaterials.expiredDays + ",");
            sbSql.Append("    minStockNum = " + _modelMaterials.minStockNum + ",");
            sbSql.Append("    modifyBy = '" + _modelMaterials.modifyBy + "',");
            sbSql.Append("    modifyTime = '" + _modelMaterials.modifyTime + "' ");
            sbSql.Append("where id = " + _modelMaterials.id);

            listSql.Add(sbSql.ToString());

            if (_modelMaterials.modelMaterialsSearch != null)
            {
                sbSql.Clear();
                sbSql.Append("update m_materialsSearch ");
                sbSql.Append("set searchKey = '" + _modelMaterials.modelMaterialsSearch.searchKey + "',");
                sbSql.Append("    materialsName = '" + _modelMaterials.modelMaterialsSearch.materialsName + "' ");
                sbSql.Append("where materialsId = " + _modelMaterials.modelMaterialsSearch.materialsId);

                listSql.Add(sbSql.ToString());
            }

            if (_modelMaterials.modelMaterialsPrice != null)
            {
                sbSql.Clear();
                sbSql.Append("update m_materialsPrice ");
                sbSql.Append("set price = " + _modelMaterials.modelMaterialsPrice.materialsName + ",");
                sbSql.Append("    priceUnit = " + _modelMaterials.modelMaterialsPrice.priceUnit + ", ");
                sbSql.Append("    materialsName = '" + _modelMaterials.modelMaterialsPrice.materialsName + "', ");
                sbSql.Append("    modifyBy = '" + _modelMaterials.modelMaterialsPrice.modifyBy + "',");
                sbSql.Append("    modifyTime = '" + _modelMaterials.modelMaterialsPrice.modifyTime + "' ");
                sbSql.Append("where materialsId = " + _modelMaterials.modelMaterialsPrice.materialsId);

                listSql.Add(sbSql.ToString());
            }
            return Dal.DBHelper.ExcuteTransaction(listSql);
        }

        public int DeleteMaterials(ModelMaterials _modelMaterials)
        {
            List<string> listSql = new List<string>();

            sbSql.Clear();
            sbSql.Append("update m_materials ");
            sbSql.Append("set isDelete = 1,");
            sbSql.Append("    modifyBy = '" + _modelMaterials.modifyBy + "',");
            sbSql.Append("    modifyTime = '" + _modelMaterials.modifyTime + "' ");
            sbSql.Append("where id = " + _modelMaterials.id);

            listSql.Add(sbSql.ToString());

            sbSql.Clear();
            sbSql.Append("delete from m_materialsSearch ");
            sbSql.Append("where materialsId = " + _modelMaterials.id);

            listSql.Add(sbSql.ToString());

            sbSql.Clear();
            sbSql.Append("update m_materialsPrice ");
            sbSql.Append("set isDelete = 1,");
            sbSql.Append("    modifyBy = '" + _modelMaterials.modifyBy + "',");
            sbSql.Append("    modifyTime = '" + _modelMaterials.modifyTime + "' ");
            sbSql.Append("where materialsId = " + _modelMaterials.id);

            listSql.Add(sbSql.ToString());

            return Dal.DBHelper.ExcuteTransaction(listSql);
        }
    }
}
