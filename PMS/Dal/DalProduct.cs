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
            sbSql.Append("       a.weight + c.value1 weight, ");
            sbSql.Append("       b.value1 morphology, ");
            sbSql.Append("       a.shelfLife, ");
            sbSql.Append("       '修改' modifyBtn, ");
            sbSql.Append("       '删除' deleteBtn ");
            sbSql.Append("from p_product a ");
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
            sql = @"select a.id,a.searchKey,a.materialsId,a.materialsNum,a.materialsUnit
                      from r_product_materials a join m_code b
                           on a.materialsUnit = b.subcode and b.code = 3
                           join p_materials c on a.materialsId = c.id and c.isDelete = 0
                     where a.isDelete = 0
                       and a.productId = {0}";

            sql = String.Format(sql, _productId);

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

        public int AddProduct(ModelProduct _modelProduct)
        {
            List<string> listSql = new List<string>();

            sbSql.Clear();
            sbSql.Append("insert into ");
            sbSql.Append("       p_product ( ");
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
            sbSql.Append("      '" + _modelProduct.name + "', ");
            sbSql.Append("      '" + _modelProduct.subName + "', ");
            sbSql.Append("       " + _modelProduct.packingType + ", ");
            sbSql.Append("      '" + _modelProduct.packingRemark + "', ");
            sbSql.Append("       " + _modelProduct.weight + ", ");
            sbSql.Append("       " + _modelProduct.weightUnit + ", ");
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

            if (_modelProduct.modelProductPrice != null)
            {
                sbSql.Clear();
                sbSql.Append("insert into ");
                sbSql.Append("       r_product_price ( ");
                sbSql.Append("       productId, ");
                sbSql.Append("       minPrice, ");
                sbSql.Append("       advisePrice, ");
                sbSql.Append("       priceUnit) ");
                sbSql.Append("select id, ");
                sbSql.Append("        " + _modelProduct.modelProductPrice.minPrice + ", ");
                sbSql.Append("        " + _modelProduct.modelProductPrice.advisePrice + ", ");
                sbSql.Append("        " + _modelProduct.modelProductPrice.priceUnit + " ");
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
                    sbSql.Append("       materialsNum, ");
                    sbSql.Append("       materialsUnit, ");
                    sbSql.Append("       isDelete, ");
                    sbSql.Append("       createBy, ");
                    sbSql.Append("       createTime, ");
                    sbSql.Append("       modifyBy, ");
                    sbSql.Append("       modifyTime) ");
                    sbSql.Append("select id, ");
                    sbSql.Append("        " + materials.materialsId + ", ");
                    sbSql.Append("       '" + materials.searchKey + "', ");
                    sbSql.Append("       '" + materials.materialsName + "', ");
                    sbSql.Append("        " + materials.materialsNum + ", ");
                    sbSql.Append("        " + materials.materialsUnit + ", ");
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
            sbSql.Append("    packingType = " + _modelProduct.packingType + ",");
            sbSql.Append("    packingRemark = '" + _modelProduct.packingRemark + "',");
            sbSql.Append("    weight = " + _modelProduct.weight + ",");
            sbSql.Append("    weightUnit = " + _modelProduct.weightUnit + ",");
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

            if (_modelProduct.modelProductPrice != null)
            {
                sbSql.Clear();
                sbSql.Append("update r_product_price ");
                sbSql.Append("set minPrice = " + _modelProduct.modelProductPrice.minPrice + ", ");
                sbSql.Append("    advisePrice = " + _modelProduct.modelProductPrice.advisePrice + ",");
                sbSql.Append("    priceUnit = " + _modelProduct.modelProductPrice.priceUnit + ",");
                sbSql.Append("    modifyBy = '" + _modelProduct.modifyBy + "',");
                sbSql.Append("    modifyTime = '" + _modelProduct.modifyTime + "' ");
                sbSql.Append("where productId = " + _modelProduct.modelProductPrice.productId);

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
                    sbSql.Append("       materialsNum, ");
                    sbSql.Append("       materialsUnit, ");
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
                    sbSql.Append("        " + materials.materialsNum + ", ");
                    sbSql.Append("        " + materials.materialsUnit + ", ");
                    sbSql.Append("        " + _modelProduct.isDelete + ", ");
                    sbSql.Append("       '" + _modelProduct.createBy + "', ");
                    sbSql.Append("       '" + _modelProduct.createTime + "', ");
                    sbSql.Append("       '" + _modelProduct.modifyBy + "', ");
                    sbSql.Append("       '" + _modelProduct.modifyTime + "') ");

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
    }
}
