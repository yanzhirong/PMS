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

        public DataTable GetMaterials(string _name, int _type)
        {
            sbSql.Clear();
            sbSql.Append("select a.id, ");
            sbSql.Append("       a.name, ");
            sbSql.Append("       a.subName, ");
            sbSql.Append("       b.value1 packingType, ");
            sbSql.Append("       b.value1 morphology, ");
            sbSql.Append("       a.shelfLife, ");
            sbSql.Append("       case a.type when 0 then '一般原料' when 1 then '自制原料' else '其它' end type, ");
            sbSql.Append("       '修改' modifyBtn, ");
            sbSql.Append("       '删除' deleteBtn ");
            sbSql.Append("from p_materials a ");
            sbSql.Append("left join m_code b ");
            sbSql.Append("  on a.packingType = b.subCode and b.code = 1 ");
            sbSql.Append("left join m_code d ");
            sbSql.Append("  on a.morphology = d.subCode and d.code = 2 ");
            sbSql.Append("where a.isDelete = 0 ");
            if (Common.Tools.StringUtils.IsNotBlank(_name))
            {
                sbSql.Append("  and a.name like '%").Append(_name).Append("%' ");
            }
            if (_type >= 0)
            {
                sbSql.Append("  and a.type = ").Append(_type).Append(" ");
            }
            sbSql.Append("order by a.modifyTime desc");

            return Dal.DBHelper.Select(sbSql.ToString());
        }

        public DataTable GetMaterialsById(int _materialsId)
        {
            sql = @"select * 
                      from p_materials
                     where isDelete = 0
                       and id = {0}";

            sql = String.Format(sql, _materialsId);

            return Dal.DBHelper.Select(sql);
        }

        public DataTable GetMaterialsSearchById(int _materialsId)
        {
            sql = @"select * 
                      from r_materials_search
                     where materialsId = {0}";

            sql = String.Format(sql, _materialsId);

            return Dal.DBHelper.Select(sql);
        }

        public DataTable GetMaterialsPriceById(int _materialsId)
        {
            sql = @"select * 
                      from r_materials_price
                     where isDelete = 0
                       and materialsId = {0}";

            sql = String.Format(sql, _materialsId);

            return Dal.DBHelper.Select(sql);
        }

        public DataTable GetMaterialsByName(string _name)
        {
            sql = @"select * 
                      from p_materials
                     where isDelete = 0
                       and name = '{0}'";

            sql = String.Format(sql, _name);

            return Dal.DBHelper.Select(sql);
        }

        public DataTable GetMaterialsBySearchKey(string _searchKey)
        {
            sql = @"select b.* 
                      from p_materials a
                      join r_materials_search b
                        on a.id = b.materialsId
                     where upper(b.searchKey) like '%{0}%'
                       and a.isDelete = 0
                       and a.type != 2
                     order by a.name";

            sql = String.Format(sql, _searchKey);

            return Dal.DBHelper.Select(sql);
        }

        public DataTable GetMaterialsItemByType(int _type)
        {
            sql = @"select * 
                      from p_materials
                      where isDelete = 0
                        and type = {0}";

            sql = String.Format(sql, _type);

            return Dal.DBHelper.Select(sql);
        }

        public DataTable GetProductMaterialsById(int _materialsId)
        {
            sql = @"select a.*
                      from r_product_materials a 
                     where a.isDelete = 0
                       and a.materialsId = {0}";

            sql = String.Format(sql, _materialsId);

            return Dal.DBHelper.Select(sql);
        }

        public int AddMaterials(ModelMaterials _modelMaterials)
        {
            List<string> listSql = new List<string>();

            sbSql.Clear();
            sbSql.Append("insert into ");
            sbSql.Append("       p_materials ( ");
            sbSql.Append("       name, ");
            sbSql.Append("       subName, ");
            sbSql.Append("       excuteStandard, ");
            sbSql.Append("       CAS, ");
            sbSql.Append("       FEMA, ");
            sbSql.Append("       dangerClasses, ");
            sbSql.Append("       packingType, ");
            sbSql.Append("       packingRemark, ");
            sbSql.Append("       morphology, ");
            sbSql.Append("       shelfLife, ");
            sbSql.Append("       expiredDays, ");
            sbSql.Append("       minStockNum, ");
            sbSql.Append("       type, ");
            sbSql.Append("       isDelete, ");
            sbSql.Append("       createBy, ");
            sbSql.Append("       createTime, ");
            sbSql.Append("       modifyBy, ");
            sbSql.Append("       modifyTime ");
            sbSql.Append("       ) value ( ");
            sbSql.Append("      '" + _modelMaterials.name + "', ");
            sbSql.Append("      '" + _modelMaterials.subName + "', ");
            sbSql.Append("      '" + _modelMaterials.excuteStandard + "', ");
            sbSql.Append("      '" + _modelMaterials.CAS + "', ");
            sbSql.Append("      '" + _modelMaterials.FEMA + "', ");
            sbSql.Append("       " + _modelMaterials.dangerClasses + ", ");
            sbSql.Append("       " + _modelMaterials.packingType + ", ");
            sbSql.Append("      '" + _modelMaterials.packingRemark + "', ");
            sbSql.Append("       " + _modelMaterials.morphology + ", ");
            sbSql.Append("       " + _modelMaterials.shelfLife + ", ");
            sbSql.Append("       " + _modelMaterials.expiredDays + ", ");
            sbSql.Append("       " + _modelMaterials.minStockNum + ", ");
            sbSql.Append("       " + _modelMaterials.type + ", ");
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
                sbSql.Append("       r_materials_search ( ");
                sbSql.Append("       materialsId, ");
                sbSql.Append("       materialsName, ");
                sbSql.Append("       searchKey) ");
                sbSql.Append("select id, ");
                sbSql.Append("       '" + _modelMaterials.modelMaterialsSearch.materialsName + "', ");
                sbSql.Append("       '" + _modelMaterials.modelMaterialsSearch.searchKey + "' ");
                sbSql.Append("  from p_materials ");
                sbSql.Append(" where name = '" + _modelMaterials.name + "'");
                sbSql.Append(" order by id desc ");
                sbSql.Append(" limit 0,1 ");

                listSql.Add(sbSql.ToString());
            }

            if (_modelMaterials.modelMaterialsPrice != null && _modelMaterials.modelMaterialsPrice.Count > 0)
            {
                sbSql.Clear();
                sbSql.Append("insert into ");
                sbSql.Append("       r_materials_price ( ");
                sbSql.Append("       materialsId, ");
                sbSql.Append("       price) ");
                sbSql.Append("select id, ");
                sbSql.Append("        " + _modelMaterials.modelMaterialsPrice[0].price + " ");
                sbSql.Append("  from p_materials ");
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
            sbSql.Append("update p_materials ");
            sbSql.Append("set name = '" + _modelMaterials.name + "',");
            sbSql.Append("    subName = '" + _modelMaterials.subName + "',");
            sbSql.Append("    excuteStandard = '" + _modelMaterials.excuteStandard + "',");
            sbSql.Append("    CAS = '" + _modelMaterials.CAS + "',");
            sbSql.Append("    FEMA = '" + _modelMaterials.FEMA + "',");
            sbSql.Append("    dangerClasses = " + _modelMaterials.dangerClasses + ",");
            sbSql.Append("    packingType = " + _modelMaterials.packingType + ",");
            sbSql.Append("    packingRemark = '" + _modelMaterials.packingRemark + "',");
            sbSql.Append("    morphology = " + _modelMaterials.morphology + ",");
            sbSql.Append("    shelfLife = " + _modelMaterials.shelfLife + ",");
            sbSql.Append("    expiredDays = " + _modelMaterials.expiredDays + ",");
            sbSql.Append("    minStockNum = " + _modelMaterials.minStockNum + ",");
            sbSql.Append("    type = " + _modelMaterials.type + ",");
            sbSql.Append("    modifyBy = '" + _modelMaterials.modifyBy + "',");
            sbSql.Append("    modifyTime = '" + _modelMaterials.modifyTime + "' ");
            sbSql.Append("where id = " + _modelMaterials.id);

            listSql.Add(sbSql.ToString());

            if (_modelMaterials.type == 2)
            {
                sbSql.Clear();
                sbSql.Append("update r_materials_specs ");
                sbSql.Append("set isDelete = 1,");
                sbSql.Append("    modifyBy = '" + _modelMaterials.modifyBy + "',");
                sbSql.Append("    modifyTime = '" + _modelMaterials.modifyTime + "' ");
                sbSql.Append("where materialsId = " + _modelMaterials.id);
                sbSql.Append("  and isDelete = 0");
                listSql.Add(sbSql.ToString());
            }

            sbSql.Clear();
            sbSql.Append("delete from r_materials_search ");
            sbSql.Append("where materialsId = " + _modelMaterials.id);
            listSql.Add(sbSql.ToString());

  
            if (_modelMaterials.modelMaterialsSearch != null)
            {
                sbSql.Clear();
                sbSql.Append("insert into ");
                sbSql.Append("       r_materials_search ( ");
                sbSql.Append("       materialsId, ");
                sbSql.Append("       materialsName, ");
                sbSql.Append("       searchKey) ");
                sbSql.Append("select id, ");
                sbSql.Append("       '" + _modelMaterials.modelMaterialsSearch.materialsName + "', ");
                sbSql.Append("       '" + _modelMaterials.modelMaterialsSearch.searchKey + "' ");
                sbSql.Append("  from p_materials ");
                sbSql.Append(" where name = '" + _modelMaterials.name + "'");
                sbSql.Append(" order by id desc ");
                sbSql.Append(" limit 0,1 ");

                listSql.Add(sbSql.ToString());
            }


            sbSql.Clear();
            sbSql.Append("update r_materials_price ");
            sbSql.Append("set isDelete = 1,");
            sbSql.Append("    modifyBy = '" + _modelMaterials.modifyBy + "',");
            sbSql.Append("    modifyTime = '" + _modelMaterials.modifyTime + "' ");
            sbSql.Append("where materialsId = " + _modelMaterials.id);

            listSql.Add(sbSql.ToString());

            if (_modelMaterials.modelMaterialsPrice != null && _modelMaterials.modelMaterialsPrice.Count > 0)
            {
                foreach (ModelMaterialsPrice modelPrice in _modelMaterials.modelMaterialsPrice)
                {
                    sbSql.Clear();
                    sbSql.Append("insert into ");
                    sbSql.Append("       r_materials_price ( ");
                    sbSql.Append("       materialsId, ");
                    sbSql.Append("       specsId, ");
                    sbSql.Append("       price, ");
                    sbSql.Append("       isDelete, ");
                    sbSql.Append("       createBy, ");
                    sbSql.Append("       createTime ");
                    sbSql.Append("       ) value ( ");
                    sbSql.Append("      '" + modelPrice.materialsId + "', ");
                    sbSql.Append("      '" + modelPrice.specsId + "', ");
                    sbSql.Append("       " + modelPrice.price + ", ");
                    sbSql.Append("       " + modelPrice.isDelete + ", ");
                    sbSql.Append("      '" + modelPrice.createBy + "', ");
                    sbSql.Append("      '" + modelPrice.createTime + "')");

                    listSql.Add(sbSql.ToString());
                }
            }
            return Dal.DBHelper.ExcuteTransaction(listSql);
        }

        public int UpdateMaterialsPrice(List<ModelMaterialsPrice> _listModelMaterialsPrice)
        {
            List<string> listSql = new List<string>();

            foreach (ModelMaterialsPrice modelMaterialsPrice in _listModelMaterialsPrice)
            {
                sbSql.Clear();
                sbSql.Append("update r_materials_price ");
                sbSql.Append("set isDelete = 1,");
                sbSql.Append("    modifyBy = '" + modelMaterialsPrice.modifyBy + "',");
                sbSql.Append("    modifyTime = '" + modelMaterialsPrice.modifyTime + "' ");
                sbSql.Append("where materialsId = " + modelMaterialsPrice.materialsId);
                sbSql.Append("  and specsId = " + modelMaterialsPrice.specsId);
                sbSql.Append("  and isDelete = 0 ");

                listSql.Add(sbSql.ToString());

                sbSql.Clear();
                sbSql.Append("insert into ");
                sbSql.Append("       r_materials_price ( ");
                sbSql.Append("       materialsId, ");
                sbSql.Append("       specsId, ");
                sbSql.Append("       price, ");
                sbSql.Append("       isDelete, ");
                sbSql.Append("       createBy, ");
                sbSql.Append("       createTime ");
                sbSql.Append("       ) value ( ");
                sbSql.Append("      '" + modelMaterialsPrice.materialsId + "', ");
                sbSql.Append("      '" + modelMaterialsPrice.specsId + "', ");
                sbSql.Append("       " + modelMaterialsPrice.price + ", ");
                sbSql.Append("       " + modelMaterialsPrice.isDelete + ", ");
                sbSql.Append("      '" + modelMaterialsPrice.createBy + "', ");
                sbSql.Append("      '" + modelMaterialsPrice.createTime + "')");

                listSql.Add(sbSql.ToString());
            }
            return Dal.DBHelper.ExcuteTransaction(listSql);
        }

        public int DeleteMaterials(ModelMaterials _modelMaterials)
        {
            List<string> listSql = new List<string>();

            sbSql.Clear();
            sbSql.Append("update p_materials ");
            sbSql.Append("set isDelete = 1,");
            sbSql.Append("    modifyBy = '" + _modelMaterials.modifyBy + "',");
            sbSql.Append("    modifyTime = '" + _modelMaterials.modifyTime + "' ");
            sbSql.Append("where id = " + _modelMaterials.id);

            listSql.Add(sbSql.ToString());

            sbSql.Clear();
            sbSql.Append("delete from r_materials_search ");
            sbSql.Append("where materialsId = " + _modelMaterials.id);

            listSql.Add(sbSql.ToString());

            sbSql.Clear();
            sbSql.Append("update r_materials_price ");
            sbSql.Append("set isDelete = 1,");
            sbSql.Append("    modifyBy = '" + _modelMaterials.modifyBy + "',");
            sbSql.Append("    modifyTime = '" + _modelMaterials.modifyTime + "' ");
            sbSql.Append("where materialsId = " + _modelMaterials.id);
            sbSql.Append("  and isDelete = 0");

            listSql.Add(sbSql.ToString());

            sbSql.Clear();
            sbSql.Append("update r_materials_specs ");
            sbSql.Append("set isDelete = 1,");
            sbSql.Append("    modifyBy = '" + _modelMaterials.modifyBy + "',");
            sbSql.Append("    modifyTime = '" + _modelMaterials.modifyTime + "' ");
            sbSql.Append("where materialsId = " + _modelMaterials.id);
            sbSql.Append("  and isDelete = 0");

            listSql.Add(sbSql.ToString());

            return Dal.DBHelper.ExcuteTransaction(listSql);
        }

        public DataTable GetExcuteStandard()
        {
            sql = @"select distinct excuteStandard 
                      from p_materials
                     where isDelete = 0
                       and ifnull(excuteStandard,'') != ''";

            return Dal.DBHelper.Select(sql);
        }

        public int AddMaterialsSpecs(ModelMaterialsSpecs _model)
        {
            sbSql.Clear();
            sbSql.Append("insert into ");
            sbSql.Append("       r_materials_specs ( ");
            sbSql.Append("       materialsId, ");
            sbSql.Append("       name, ");
            sbSql.Append("       weight, ");
            sbSql.Append("       num, ");
            sbSql.Append("       isDelete, ");
            sbSql.Append("       createBy, ");
            sbSql.Append("       createTime )");
            sbSql.Append("values ( ");
            sbSql.Append("        " + _model.materialsId + ", ");
            sbSql.Append("       '" + _model.name + "', ");
            sbSql.Append("        " + _model.weight + ", ");
            sbSql.Append("        " + _model.num + ", ");
            sbSql.Append("        " + _model.isDelete + ", ");
            sbSql.Append("       '" + _model.createBy + "', ");
            sbSql.Append("       '" + _model.createTime + "') ");

            return Dal.DBHelper.Excute(sbSql.ToString());

        }

        public int AddMaterialsPrice(ModelMaterialsPrice _model)
        {
            sbSql.Clear();
            sbSql.Append("insert into ");
            sbSql.Append("       r_materials_price ( ");
            sbSql.Append("       materialsId, ");
            sbSql.Append("       specsId, ");
            sbSql.Append("       price, ");
            sbSql.Append("       isDelete, ");
            sbSql.Append("       createBy, ");
            sbSql.Append("       createTime )");
            sbSql.Append("values ( ");
            sbSql.Append("        " + _model.materialsId + ", ");
            sbSql.Append("       '" + _model.specsId + "', ");
            sbSql.Append("        " + _model.price + ", ");
            sbSql.Append("        " + _model.isDelete + ", ");
            sbSql.Append("       '" + _model.createBy + "', ");
            sbSql.Append("       '" + _model.createTime + "') ");

            return Dal.DBHelper.Excute(sbSql.ToString());

        }

        public int DeleteMaterialsSpecs(ModelMaterialsSpecs _model)
        {
            List<string> listSql = new List<string>();

            sbSql.Clear();
            sbSql.Append("update r_materials_specs ");
            sbSql.Append("set isDelete = 1,");
            sbSql.Append("    modifyBy = '" + _model.modifyBy + "',");
            sbSql.Append("    modifyTime = '" + _model.modifyTime + "' ");
            sbSql.Append("where id = " + _model.id);

            listSql.Add(sbSql.ToString());

            sbSql.Clear();
            sbSql.Append("update r_materials_price ");
            sbSql.Append("set isDelete = 1,");
            sbSql.Append("    modifyBy = '" + _model.modifyBy + "',");
            sbSql.Append("    modifyTime = '" + _model.modifyTime + "' ");
            sbSql.Append("where specsId = " + _model.id);

            listSql.Add(sbSql.ToString());

            return Dal.DBHelper.ExcuteTransaction(listSql);

        }

        public DataTable GetMaterialsSpecsListByMaterialsId(int _materialsId)
        {

            sql = @"select a.id specsId, 
                           a.name, 
                           b.id priceId, 
                           b.price, 
                           '删除' deleteBtn 
                      from r_materials_specs a
                      left join r_materials_price b
                        on a.materialsId = b.materialsId
                       and a.id = b.specsId
                       and b.isDelete = 0
                     where a.isDelete = 0
                       and a.materialsId = {0}";

            sql = String.Format(sql, _materialsId);

            return Dal.DBHelper.Select(sql);
        }

        public DataTable GetMaterialsSpecsListById(int _specsId)
        {

            sql = @"select a.*
                      from r_materials_specs a
                     where a.isDelete = 0
                       and a.id = {0}";

            sql = String.Format(sql, _specsId);

            return Dal.DBHelper.Select(sql);
        }

        public DataTable GetMaterialsPriceById(int _materialsId, int _specsId)
        {

            sql = @"select a.*
                      from r_materials_price a
                     where a.isDelete = 0
                       and a.materialsId = {0}
                       and a.specsId = {1}";

            sql = String.Format(sql, _materialsId, _specsId);

            return Dal.DBHelper.Select(sql);
        }

        public DataTable GetMaterialsPriceByMaterialsId(int _materialsId)
        {

            sql = @"select a.*
                      from r_materials_price a
                     where a.isDelete = 0
                       and a.materialsId = {0}
                     order by a.modifyTime desc
                     limit 0,1";

            sql = String.Format(sql, _materialsId);

            return Dal.DBHelper.Select(sql);
        }

        public DataTable GetMaterialsSpecsByName(string _specsName)
        {
            sql = @"select a.* 
                      from r_materials_specs a
                     where a.isDelete = 0
                       and a.name = '{0}'
                     order by a.id desc
                     limit 0,1";

            sql = String.Format(sql, _specsName);

            return Dal.DBHelper.Select(sql);
        }

        public DataTable GetMaterialsSpecsListForCombo(int _materialsId)
        {
            if (_materialsId > 0)
            {
                sql = @"select a.id , 
                           a.name name
                      from r_materials_specs a
                     where a.isDelete = 0
                       and a.materialsId = {0}";
                sql = String.Format(sql, _materialsId);
            }
            else
            {
                sql = @"select a.id , 
                           a.name name
                      from r_materials_specs a
                     where a.isDelete = 0";
            }

            return Dal.DBHelper.Select(sql);
        }
    }
}
