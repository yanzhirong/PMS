using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Model;

namespace Dal
{
    public class DalProduct
    {
        string sql;
        StringBuilder sbSql = new StringBuilder();

        public DataTable GetProducts(string _name)
        {
            sbSql.Clear();
            sbSql.Append("select a.id, ");
            sbSql.Append("       a.name, ");
            sbSql.Append("       a.subName, ");
            sbSql.Append("       b.value1 packingType, ");
            sbSql.Append("       c.value1 morphology, ");
            sbSql.Append("       a.shelfLife, ");
            sbSql.Append("       '修改' modifyBtn, ");
            sbSql.Append("       '删除' deleteBtn ");
            sbSql.Append("from p_product a ");
            sbSql.Append("left join m_code b ");
            sbSql.Append("  on a.packingType = b.subCode and b.code = 1 ");
            sbSql.Append("left join m_code c ");
            sbSql.Append("  on a.morphology = c.subCode and c.code = 2 ");
            sbSql.Append("where a.isDelete = 0 ");
            if(Common.Tools.StringUtils.IsNotBlank(_name))
            {
                sbSql.Append("   and a.id in (");
                sbSql.Append("                     select productId ");
                sbSql.Append("                       from r_product_search ");
                sbSql.Append("                      where productName like '%").Append(_name).Append("%' or upper(searchKey) like '%").Append(_name.ToUpper()).Append("%') ");
            }

            sbSql.Append("order by a.modifyTime desc");

            return Dal.DBHelper.Select(sbSql.ToString());
        }

        public DataTable GetProductsQuery(string _name)
        {
            sbSql.Clear();
            sbSql.Append("select a.id, ");
            sbSql.Append("       a.name, ");
            sbSql.Append("       a.subName, ");
            sbSql.Append("       b.value1 packingType, ");
            sbSql.Append("       c.value1 morphology, ");
            sbSql.Append("       a.shelfLife, ");
            sbSql.Append("       '查看' queryStore  ");
            sbSql.Append("from p_product a ");
            sbSql.Append("left join m_code b ");
            sbSql.Append("  on a.packingType = b.subCode and b.code = 1 ");
            sbSql.Append("left join m_code c ");
            sbSql.Append("  on a.morphology = c.subCode and c.code = 2 ");
            sbSql.Append("where a.isDelete = 0 ");
            if (Common.Tools.StringUtils.IsNotBlank(_name))
            {
                sbSql.Append("   and a.id in (");
                sbSql.Append("                     select productId ");
                sbSql.Append("                       from r_product_search ");
                sbSql.Append("                      where productName like '%").Append(_name).Append("%' or upper(searchKey) like '%").Append(_name.ToUpper()).Append("%') ");
            }

            sbSql.Append("order by a.modifyTime desc");

            return Dal.DBHelper.Select(sbSql.ToString());
        }

        public DataTable GetProductById(int _productId)
        {
            sql = @"select * 
                      from p_product
                     where isDelete = 0
                       and id = {0}";

            sql = String.Format(sql, _productId);

            return Dal.DBHelper.Select(sql);
        }

        public DataTable GetProductSearchById(int _productId)
        {
            sql = @"select * 
                      from r_product_search
                     where productId = {0}";

            sql = String.Format(sql, _productId);

            return Dal.DBHelper.Select(sql);
        }

        public DataTable GetProductPriceById(int _productId)
        {
            sql = @"select * 
                      from r_product_price
                     where isDelete = 0
                       and productId = {0}";

            sql = String.Format(sql, _productId);

            return Dal.DBHelper.Select(sql);
        }

        public DataTable GetProductMaterialsById(int _productId)
        {
            sql = @"select a.id,a.searchKey,a.materialsId,a.percent
                      from r_product_materials a
                     where a.isDelete = 0
                       and a.productId = {0}";

            sql = String.Format(sql, _productId);

            return Dal.DBHelper.Select(sql);
        }

        public DataTable GetProductSpecsByMaterialsId(int _materialsId)
        {
            sql = @"select distinct a.productId, b.id specsId, b.weight, b.num 
                      from r_product_materials a
                      join r_product_specs b
                        on a.productId = b.productId
                       and b.isDelete = 0
                     where a.isDelete = 0
                       and a.materialsId = {0}";

            sql = String.Format(sql, _materialsId);

            return Dal.DBHelper.Select(sql);
        }

        public DataTable GetProductSpecsListByProdcutId(int _productId)
        {
            sql = @"select a.id specsId, 
                           a.name, 
                           b.id priceId, 
                           b.minPrice, 
                           b.advisePrice,
                           '删除' deleteBtn 
                      from r_product_specs a
                      left join r_product_price b
                        on a.productId = b.productId
                       and a.id = b.specsId
                       and b.isDelete = 0
                     where a.isDelete = 0
                       and a.productId = {0}";

            sql = String.Format(sql, _productId);

            return Dal.DBHelper.Select(sql);
        }

        public DataTable GetSpecsForCmbByProdcutId(int _productId)
        {
            sql = @"select a.id itemKey, 
                           a.name itemValue
                      from r_product_specs a
                     where a.isDelete = 0
                       and a.productId = {0}";

            sql = String.Format(sql, _productId);

            return Dal.DBHelper.Select(sql);
        }

        public DataTable GetProductSpecsById(int _specsId)
        {
            sql = @"select a.* 
                      from r_product_specs a
                     where a.isDelete = 0
                       and a.id = {0}";

            sql = String.Format(sql, _specsId);

            return Dal.DBHelper.Select(sql);
        }

        public DataTable GetProductSpecsByName(string _specsName)
        {
            sql = @"select a.* 
                      from r_product_specs a
                     where a.isDelete = 0
                       and a.name = '{0}'
                     order by a.id desc
                     limit 0,1";

            sql = String.Format(sql, _specsName);

            return Dal.DBHelper.Select(sql);
        }
        public DataTable GetProductByName(string _name)
        {
            sql = @"select * 
                      from p_product
                     where isDelete = 0
                       and name = '{0}'";

            sql = String.Format(sql, _name);

            return Dal.DBHelper.Select(sql);
        }

        public DataTable GetProductBySearchKey(string _searchKey)
        {
            sql = @"select * 
                      from r_product_search
                     where upper(searchKey) like '%{0}%'";

            sql = String.Format(sql, _searchKey);

            return Dal.DBHelper.Select(sql);
        }

        public DataTable GetProductPriceById(int _productId, int _specsId)
        {
            sql = @"select * 
                      from r_product_price
                     where isDelete = 0
                       and productId = {0}
                       and specsId = {1}";

            sql = String.Format(sql, _productId, _specsId);

            return Dal.DBHelper.Select(sql);
        }

        public int AddProduct(ModelProduct _modelProduct)
        {
            List<string> listSql = new List<string>();

            sbSql.Clear();
            sbSql.Append("insert into ");
            sbSql.Append("       p_product ( ");
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
            sbSql.Append("       isDelete, ");
            sbSql.Append("       createBy, ");
            sbSql.Append("       createTime, ");
            sbSql.Append("       modifyBy, ");
            sbSql.Append("       modifyTime ");
            sbSql.Append("       ) value ( ");
            sbSql.Append("      '" + _modelProduct.name + "', ");
            sbSql.Append("      '" + _modelProduct.subName + "', ");
            sbSql.Append("      '" + _modelProduct.excuteStandard + "', ");
            sbSql.Append("      '" + _modelProduct.CAS + "', ");
            sbSql.Append("      '" + _modelProduct.FEMA + "', ");
            sbSql.Append("       " + _modelProduct.dangerClasses + ", ");
            sbSql.Append("       " + _modelProduct.packingType + ", ");
            sbSql.Append("      '" + _modelProduct.packingRemark + "', ");
            sbSql.Append("       " + _modelProduct.morphology + ", ");
            sbSql.Append("       " + _modelProduct.shelfLife + ", ");
            sbSql.Append("       " + _modelProduct.expiredDays + ", ");
            sbSql.Append("       " + _modelProduct.minStockNum + ", ");
            sbSql.Append("       " + _modelProduct.isDelete + ", ");
            sbSql.Append("      '" + _modelProduct.createBy + "', ");
            sbSql.Append("      '" + _modelProduct.createTime + "', ");
            sbSql.Append("      '" + _modelProduct.modifyBy + "', ");
            sbSql.Append("      '" + _modelProduct.modifyTime + "')");

            listSql.Add(sbSql.ToString());

            if (_modelProduct.modelProductSearch != null)
            {
                sbSql.Clear();
                sbSql.Append("insert into ");
                sbSql.Append("       r_product_search ( ");
                sbSql.Append("       productId, ");
                sbSql.Append("       productName, ");
                sbSql.Append("       searchKey) ");
                sbSql.Append("select id, ");
                sbSql.Append("       '" + _modelProduct.modelProductSearch.productName + "', ");
                sbSql.Append("       '" + _modelProduct.modelProductSearch.searchKey + "' ");
                sbSql.Append("  from p_product ");
                sbSql.Append(" where name = '" + _modelProduct.name + "'");
                sbSql.Append(" order by id desc ");
                sbSql.Append(" limit 0,1 ");

                listSql.Add(sbSql.ToString());
            }

            if (_modelProduct.modelProductMaterials != null)
            {
                foreach (ModelProductMaterials materials in _modelProduct.modelProductMaterials)
                {
                    sbSql.Clear();
                    sbSql.Append("insert into ");
                    sbSql.Append("       r_product_materials ( ");
                    sbSql.Append("       productId, ");
                    sbSql.Append("       materialsId, ");
                    sbSql.Append("       searchKey, ");
                    sbSql.Append("       materialsName, ");
                    sbSql.Append("       percent, ");
                    sbSql.Append("       isDelete, ");
                    sbSql.Append("       createBy, ");
                    sbSql.Append("       createTime, ");
                    sbSql.Append("       modifyBy, ");
                    sbSql.Append("       modifyTime) ");
                    sbSql.Append("select id, ");
                    sbSql.Append("        " + materials.materialsId + ", ");
                    sbSql.Append("       '" + materials.searchKey + "', ");
                    sbSql.Append("       '" + materials.materialsName + "', ");
                    sbSql.Append("        " + materials.percent + ", ");
                    sbSql.Append("        " + _modelProduct.isDelete + ", ");
                    sbSql.Append("       '" + _modelProduct.createBy + "', ");
                    sbSql.Append("       '" + _modelProduct.createTime + "', ");
                    sbSql.Append("       '" + _modelProduct.modifyBy + "', ");
                    sbSql.Append("       '" + _modelProduct.modifyTime + "' ");
                    sbSql.Append("  from p_product ");
                    sbSql.Append(" where name = '" + _modelProduct.name + "'");
                    sbSql.Append(" order by id desc ");
                    sbSql.Append(" limit 0,1 ");

                    listSql.Add(sbSql.ToString());
                }
            } 
            
            return Dal.DBHelper.ExcuteTransaction(listSql);
        }

        public int UpdateProduct(ModelProduct _modelProduct)
        {
            List<string> listSql = new List<string>();

            sbSql.Clear();
            sbSql.Append("update p_product ");
            sbSql.Append("set name = '" + _modelProduct.name + "',");
            sbSql.Append("    subName = '" + _modelProduct.subName + "',");
            sbSql.Append("    excuteStandard = '" + _modelProduct.excuteStandard + "',");
            sbSql.Append("    CAS = '" + _modelProduct.CAS + "',");
            sbSql.Append("    FEMA = '" + _modelProduct.FEMA + "',");
            sbSql.Append("    dangerClasses = " + _modelProduct.dangerClasses + ",");
            sbSql.Append("    packingType = " + _modelProduct.packingType + ",");
            sbSql.Append("    packingRemark = '" + _modelProduct.packingRemark + "',");
            sbSql.Append("    morphology = " + _modelProduct.morphology + ",");
            sbSql.Append("    shelfLife = " + _modelProduct.shelfLife + ",");
            sbSql.Append("    expiredDays = " + _modelProduct.expiredDays + ",");
            sbSql.Append("    minStockNum = " + _modelProduct.minStockNum + ",");
            sbSql.Append("    modifyBy = '" + _modelProduct.modifyBy + "',");
            sbSql.Append("    modifyTime = '" + _modelProduct.modifyTime + "' ");
            sbSql.Append("where id = " + _modelProduct.id);

            listSql.Add(sbSql.ToString());

            if (_modelProduct.modelProductSearch != null)
            {
                sbSql.Clear();
                sbSql.Append("update r_product_search ");
                sbSql.Append("set searchKey = '" + _modelProduct.modelProductSearch.searchKey + "',");
                sbSql.Append("    productName = '" + _modelProduct.modelProductSearch.productName + "' ");
                sbSql.Append("where productId = " + _modelProduct.modelProductSearch.productId);

                listSql.Add(sbSql.ToString());
            }

            sbSql.Clear();
            sbSql.Append("delete from r_product_materials ");
            sbSql.Append("where productId = " + _modelProduct.id);

            listSql.Add(sbSql.ToString());

            if (_modelProduct.modelProductMaterials != null)
            {
                foreach (ModelProductMaterials materials in _modelProduct.modelProductMaterials)
                {
                    sbSql.Clear();
                    sbSql.Append("insert into ");
                    sbSql.Append("       r_product_materials ( ");
                    sbSql.Append("       productId, ");
                    sbSql.Append("       materialsId, ");
                    sbSql.Append("       searchKey, ");
                    sbSql.Append("       materialsName, ");
                    sbSql.Append("       percent, ");
                    sbSql.Append("       isDelete, ");
                    sbSql.Append("       createBy, ");
                    sbSql.Append("       createTime, ");
                    sbSql.Append("       modifyBy, ");
                    sbSql.Append("       modifyTime )");
                    sbSql.Append("values ( ");
                    sbSql.Append("        " + materials.productId + ", ");
                    sbSql.Append("        " + materials.materialsId + ", ");
                    sbSql.Append("       '" + materials.searchKey + "', ");
                    sbSql.Append("       '" + materials.materialsName + "', ");
                    sbSql.Append("        " + materials.percent + ", ");
                    sbSql.Append("        " + _modelProduct.isDelete + ", ");
                    sbSql.Append("       '" + _modelProduct.createBy + "', ");
                    sbSql.Append("       '" + _modelProduct.createTime + "', ");
                    sbSql.Append("       '" + _modelProduct.modifyBy + "', ");
                    sbSql.Append("       '" + _modelProduct.modifyTime + "') ");

                    listSql.Add(sbSql.ToString());
                }
            }

            foreach (ModelProductPrice modelProductPrice in _modelProduct.modelProductPrice)
            {
                if (modelProductPrice.id > 0)
                {
                    sbSql.Clear();
                    sbSql.Append("update r_product_price ");
                    sbSql.Append("set minPrice = " + modelProductPrice.minPrice + ", ");
                    sbSql.Append("    advisePrice = " + modelProductPrice.advisePrice + ",");
                    sbSql.Append("    modifyBy = '" + modelProductPrice.modifyBy + "',");
                    sbSql.Append("    modifyTime = '" + modelProductPrice.modifyTime + "' ");
                    sbSql.Append("where id = " + modelProductPrice.id);
                    listSql.Add(sbSql.ToString());
                }
                else
                {
                    sbSql.Clear();
                    sbSql.Append("insert into ");
                    sbSql.Append("       r_product_price ( ");
                    sbSql.Append("       productId, ");
                    sbSql.Append("       specsId, ");
                    sbSql.Append("       minPrice, ");
                    sbSql.Append("       advisePrice, ");
                    sbSql.Append("       isDelete, ");
                    sbSql.Append("       createBy, ");
                    sbSql.Append("       createTime )");
                    sbSql.Append("values ( ");
                    sbSql.Append("        " + modelProductPrice.productId + ", ");
                    sbSql.Append("        " + modelProductPrice.specsId + ", ");
                    sbSql.Append("        " + modelProductPrice.minPrice + ", ");
                    sbSql.Append("        " + modelProductPrice.advisePrice + ", ");
                    sbSql.Append("        " + modelProductPrice.isDelete + ", ");
                    sbSql.Append("       '" + modelProductPrice.createBy + "', ");
                    sbSql.Append("       '" + modelProductPrice.createTime + "') ");
                    listSql.Add(sbSql.ToString());
                }
            }
            return Dal.DBHelper.ExcuteTransaction(listSql);
        }

        public int DeleteProduct(ModelProduct _modelProduct)
        {
            List<string> listSql = new List<string>();

            sbSql.Clear();
            sbSql.Append("update p_product ");
            sbSql.Append("set isDelete = 1,");
            sbSql.Append("    modifyBy = '" + _modelProduct.modifyBy + "',");
            sbSql.Append("    modifyTime = '" + _modelProduct.modifyTime + "' ");
            sbSql.Append("where id = " + _modelProduct.id);

            listSql.Add(sbSql.ToString());

            sbSql.Clear();
            sbSql.Append("delete from r_product_search ");
            sbSql.Append("where productId = " + _modelProduct.id);

            listSql.Add(sbSql.ToString());

            sbSql.Clear();
            sbSql.Append("update r_product_price ");
            sbSql.Append("set isDelete = 1,");
            sbSql.Append("    modifyBy = '" + _modelProduct.modifyBy + "',");
            sbSql.Append("    modifyTime = '" + _modelProduct.modifyTime + "' ");
            sbSql.Append("where productId = " + _modelProduct.id);

            listSql.Add(sbSql.ToString());

            sbSql.Clear();
            sbSql.Append("delete from r_product_materials ");
            sbSql.Append("where productId = " + _modelProduct.id);

            listSql.Add(sbSql.ToString());

            return Dal.DBHelper.ExcuteTransaction(listSql);
        }

        public int SetProductPrice(List<ModelProductPrice> _listModelProductPrice)
        {
            List<string> listSql = new List<string>();

            foreach (ModelProductPrice modelProductPrice in _listModelProductPrice)
            {
                if (modelProductPrice.id > 0)
                {
                    sbSql.Clear();
                    sbSql.Append("update r_product_price ");
                    sbSql.Append("set minPrice = " + modelProductPrice.minPrice + ", ");
                    sbSql.Append("    advisePrice = " + modelProductPrice.advisePrice + ",");
                    sbSql.Append("    modifyBy = '" + modelProductPrice.modifyBy + "',");
                    sbSql.Append("    modifyTime = '" + modelProductPrice.modifyTime + "' ");
                    sbSql.Append("where id = " + modelProductPrice.id);
                }
                else
                {
                    sbSql.Clear();
                    sbSql.Append("insert into ");
                    sbSql.Append("       r_product_price ( ");
                    sbSql.Append("       productId, ");
                    sbSql.Append("       specsId, ");
                    sbSql.Append("       minPrice, ");
                    sbSql.Append("       advisePrice, ");
                    sbSql.Append("       isDelete, ");
                    sbSql.Append("       createBy, ");
                    sbSql.Append("       createTime )");
                    sbSql.Append("values ( ");
                    sbSql.Append("        " + modelProductPrice.productId + ", ");
                    sbSql.Append("        " + modelProductPrice.specsId + ", ");
                    sbSql.Append("        " + modelProductPrice.minPrice + ", ");
                    sbSql.Append("        " + modelProductPrice.advisePrice + ", ");
                    sbSql.Append("        " + modelProductPrice.isDelete + ", ");
                    sbSql.Append("       '" + modelProductPrice.createBy + "', ");
                    sbSql.Append("       '" + modelProductPrice.createTime + "') ");
                }
            }
            return Dal.DBHelper.ExcuteTransaction(listSql);
        }

        public int AddProductSpecs(ModelProductSpecs _modelProductSpecs)
        {
            sbSql.Clear();
            sbSql.Append("insert into ");
            sbSql.Append("       r_product_specs ( ");
            sbSql.Append("       productId, ");
            sbSql.Append("       name, ");
            sbSql.Append("       weight, ");
            sbSql.Append("       num, ");
            sbSql.Append("       isDelete, ");
            sbSql.Append("       createBy, ");
            sbSql.Append("       createTime )");
            sbSql.Append("values ( ");
            sbSql.Append("        " + _modelProductSpecs.productId + ", ");
            sbSql.Append("       '" + _modelProductSpecs.name + "', ");
            sbSql.Append("        " + _modelProductSpecs.weight + ", ");
            sbSql.Append("        " + _modelProductSpecs.num + ", ");
            sbSql.Append("        " + _modelProductSpecs.isDelete + ", ");
            sbSql.Append("       '" + _modelProductSpecs.createBy + "', ");
            sbSql.Append("       '" + _modelProductSpecs.createTime + "') ");

            return Dal.DBHelper.Excute(sbSql.ToString());

        }

        public int AddProductPrice(ModelProductPrice _modelProductPrice)
        {
            sbSql.Clear();
            sbSql.Append("insert into ");
            sbSql.Append("       r_product_price ( ");
            sbSql.Append("       productId, ");
            sbSql.Append("       specsId, ");
            sbSql.Append("       minPrice, ");
            sbSql.Append("       advisePrice, ");
            sbSql.Append("       isDelete, ");
            sbSql.Append("       createBy, ");
            sbSql.Append("       createTime )");
            sbSql.Append("values ( ");
            sbSql.Append("        " + _modelProductPrice.productId + ", ");
            sbSql.Append("        " + _modelProductPrice.specsId + ", ");
            sbSql.Append("        " + _modelProductPrice.minPrice + ", ");
            sbSql.Append("        " + _modelProductPrice.advisePrice + ", ");
            sbSql.Append("        " + _modelProductPrice.isDelete + ", ");
            sbSql.Append("       '" + _modelProductPrice.createBy + "', ");
            sbSql.Append("       '" + _modelProductPrice.createTime + "') ");

            return Dal.DBHelper.Excute(sbSql.ToString());

        }

        public int DeleteProductSpecs(ModelProductSpecs _modelProductSpecs)
        {
            List<string> listSql = new List<string>();

            sbSql.Clear();
            sbSql.Append("update r_product_specs ");
            sbSql.Append("set isDelete = 1,");
            sbSql.Append("    modifyBy = '" + _modelProductSpecs.modifyBy + "',");
            sbSql.Append("    modifyTime = '" + _modelProductSpecs.modifyTime + "' ");
            sbSql.Append("where id = " + _modelProductSpecs.id);

            listSql.Add(sbSql.ToString());

            sbSql.Clear();
            sbSql.Append("update r_product_price ");
            sbSql.Append("set isDelete = 1,");
            sbSql.Append("    modifyBy = '" + _modelProductSpecs.modifyBy + "',");
            sbSql.Append("    modifyTime = '" + _modelProductSpecs.modifyTime + "' ");
            sbSql.Append("where specsId = " + _modelProductSpecs.id);

            listSql.Add(sbSql.ToString());

            return Dal.DBHelper.ExcuteTransaction(listSql);

        }

        public DataTable GetProductSpecsListForCombo(int _productId)
        {
            if (_productId > 0)
            {
                sql = @"select a.id , 
                           a.name name
                      from r_product_specs a
                     where a.isDelete = 0
                       and a.productId = {0}";
                sql = String.Format(sql, _productId);
            }
            else
            {
                sql = @"select a.id , 
                           a.name name
                      from r_product_specs a
                     where a.isDelete = 0";
            }

            return Dal.DBHelper.Select(sql);
        }

        public DataTable GetExcuteStandard()
        {
            sql = @"select distinct excuteStandard 
                      from p_product
                     where isDelete = 0
                       and ifnull(excuteStandard,'') != ''";

            return Dal.DBHelper.Select(sql);
        }

        public int UpdateProductPrice(List<ModelProductPrice> _listModelProductPrice)
        {
            List<string> listSql = new List<string>();

            foreach (ModelProductPrice modelProductPrice in _listModelProductPrice)
            {
                sbSql.Clear();
                sbSql.Append("update r_product_price ");
                sbSql.Append("set isDelete = 1,");
                sbSql.Append("    modifyBy = '" + modelProductPrice.modifyBy + "',");
                sbSql.Append("    modifyTime = '" + modelProductPrice.modifyTime + "' ");
                sbSql.Append("where productId = " + modelProductPrice.productId);
                sbSql.Append("  and specsId = " + modelProductPrice.specsId);
                sbSql.Append("  and isDelete = 0 ");

                listSql.Add(sbSql.ToString());

                sbSql.Clear();
                sbSql.Append("insert into ");
                sbSql.Append("       r_product_price ( ");
                sbSql.Append("       productId, ");
                sbSql.Append("       specsId, ");
                sbSql.Append("       minPrice, ");
                sbSql.Append("       advisePrice, ");
                sbSql.Append("       isDelete, ");
                sbSql.Append("       createBy, ");
                sbSql.Append("       createTime ");
                sbSql.Append("       ) value ( ");
                sbSql.Append("      '" + modelProductPrice.productId + "', ");
                sbSql.Append("      '" + modelProductPrice.specsId + "', ");
                sbSql.Append("       " + modelProductPrice.minPrice + ", ");
                sbSql.Append("       " + modelProductPrice.advisePrice + ", ");
                sbSql.Append("       " + modelProductPrice.isDelete + ", ");
                sbSql.Append("      '" + modelProductPrice.createBy + "', ");
                sbSql.Append("      '" + modelProductPrice.createTime + "')");

                listSql.Add(sbSql.ToString());
            }
            return Dal.DBHelper.ExcuteTransaction(listSql);
        }
    }
}
