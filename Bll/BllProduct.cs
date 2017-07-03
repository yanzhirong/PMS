using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dal;
using System.Data;
using Enum;
using Common.Tools;
using Model;

namespace Bll
{
    public class BllProduct : Bll.BllBase
    {
        private DalProduct m_dalProduct = new DalProduct();

        public DataTable GetProducts(string _name)
        {
            DataTable dt = m_dalProduct.GetProducts(_name);

            return dt;
        }
        public DataTable GetProductsQuery(string _name)
        {
            DataTable dt = m_dalProduct.GetProductsQuery(_name);

            return dt;
        }       
        public ModelProduct GetProductById(int _productId)
        {
            DataTable dt = m_dalProduct.GetProductById(_productId);

            if (dt != null && dt.Rows.Count > 0)
            {
                ModelProduct modelProduct = new ModelProduct();
                modelProduct = ModelUtils<ModelProduct>.FillModel(dt.Rows[0]);

                DataTable dtSearch = m_dalProduct.GetProductSearchById(_productId);
                if (dtSearch != null && dtSearch.Rows.Count > 0)
                {
                    modelProduct.modelProductSearch = ModelUtils<ModelProductSearch>.FillModel(dtSearch.Rows[0]);
                }
                else
                {
                    modelProduct.modelProductSearch = new ModelProductSearch();
                }

                DataTable dtMaterials = m_dalProduct.GetProductMaterialsById(_productId);
                if (dtMaterials != null && dtMaterials.Rows.Count > 0)
                {
                    modelProduct.modelProductMaterials = ModelUtils<ModelProductMaterials>.FillModel(dtMaterials);
                }
                else
                {
                    modelProduct.modelProductMaterials = new List<ModelProductMaterials>();
                }
                return modelProduct;
            }
            else
            {
                return new ModelProduct();
            }
        }

        public DataTable GetProductMaterialsById(int _productId)
        {
            return m_dalProduct.GetProductMaterialsById(_productId);
        }

        public DataTable GetProductSpecsByMaterialsId(int _materialsId)
        {
            return m_dalProduct.GetProductSpecsByMaterialsId(_materialsId);
        }

        public List<ModelItem> GetSpecsForCmbByProdcutId(int _productId)
        {

            DataTable dt = m_dalProduct.GetSpecsForCmbByProdcutId(_productId);

            if (dt != null && dt.Rows.Count > 0)
            {
                return ModelUtils<ModelItem>.FillModel(dt);
            }
            return null; 
        }

        public DataTable GetProductSpecsListByProdcutId(int _productId)
        {
            return m_dalProduct.GetProductSpecsListByProdcutId(_productId);
        }

        public ModelProductSpecs GetProductSpecsById(int _specsId)
        {
            DataTable dt = m_dalProduct.GetProductSpecsById(_specsId);
            if (dt != null && dt.Rows.Count > 0)
            {
                return ModelUtils<ModelProductSpecs>.FillModel(dt.Rows[0]); ;
            }
            return new ModelProductSpecs();
        }

        public ModelProductSpecs GetProductSpecsByName(string _specsName)
        {
            DataTable dt = m_dalProduct.GetProductSpecsByName(_specsName);
            if (dt != null && dt.Rows.Count > 0)
            {
                return ModelUtils<ModelProductSpecs>.FillModel(dt.Rows[0]); ;
            }
            return new ModelProductSpecs();
        }

        public DataTable GetProductBySearchKey(string _searchKey)
        {
            return m_dalProduct.GetProductBySearchKey(_searchKey);
        }

        public ModelProductPrice GetProductPriceById(int _productId, int _specsId)
        {
            DataTable dt = m_dalProduct.GetProductPriceById(_productId, _specsId);
            if (dt != null && dt.Rows.Count > 0)
            {
                return ModelUtils<ModelProductPrice>.FillModel(dt.Rows[0]); ;
            }
            return null;
        }

        public List<ModelItem> GetProductItem(string _searchKey)
        {
            List<ModelItem> listItem = new List<ModelItem>();

            DataTable dt = m_dalProduct.GetProductBySearchKey(_searchKey);

            if (dt != null && dt.Rows.Count > 0)
            {
                foreach (DataRow dr in dt.Rows)
                {
                    ModelItem modelItem = new ModelItem();
                    modelItem.itemKey = ConvertUtils.ConvertToInt(dr["productId"]);
                    modelItem.itemValue = ConvertUtils.ConvertToString(dr["productName"]);

                    listItem.Add(modelItem);
                }
            }
            return listItem;
        }
        public ModelProduct GetProductByName(string _name)
        {
            DataTable dt = m_dalProduct.GetProductByName(_name);

            if (dt != null && dt.Rows.Count > 0)
            {
                return ModelUtils<ModelProduct>.FillModel(dt.Rows[0]); ;
            }
            return new ModelProduct();
        }

        public Boolean AddProduct(ModelProduct _modelProduct)
        {
            int rtn = 0;
            rtn = m_dalProduct.AddProduct(_modelProduct);

            return rtn == 0 ? false : true;
        }

        public Boolean UpdateProduct(ModelProduct _modelProduct)
        {
            int rtn = 0;
            rtn = m_dalProduct.UpdateProduct(_modelProduct);

            return rtn == 0 ? false : true;
        }

        public Boolean DeleteProduct(ModelProduct _modelProduct)
        {
            int rtn = 0;
            rtn = m_dalProduct.DeleteProduct(_modelProduct);

            return rtn == 0 ? false : true;
        }

        public Boolean SetProductPrice(List<ModelProductPrice> _listModelProductPrice)
        {
            int rtn = 0;
            rtn = m_dalProduct.SetProductPrice(_listModelProductPrice);

            return rtn == 0 ? false : true;
        }

        public int AddProductSpecs(ModelProductSpecs _modelProductSpecs)
        {
            int rtn = 0;
            rtn = m_dalProduct.AddProductSpecs(_modelProductSpecs);

            if (rtn > 0)
            {
                DataTable dt = m_dalProduct.GetProductSpecsByName(_modelProductSpecs.name);
                if (dt != null && dt.Rows.Count > 0)
                {
                    return ModelUtils<ModelProductSpecs>.FillModel(dt.Rows[0]).id;
                }
                else
                {
                    return 0;
                }
            }

            return rtn;

        }

        public int AddProductPrice(ModelProductPrice _modelProductPrice)
        {
            int rtn = 0;
            rtn = m_dalProduct.AddProductPrice(_modelProductPrice);

            if (rtn > 0)
            {
                DataTable dt = m_dalProduct.GetProductPriceById(_modelProductPrice.productId, _modelProductPrice.specsId);
                if (dt != null && dt.Rows.Count > 0)
                {
                    return ModelUtils<ModelProductPrice>.FillModel(dt.Rows[0]).id;
                }
                else
                {
                    return 0;
                }
            }

            return rtn;
        }

        public List<ModelItem> GetProductSpecsListForCombo(int _productId)
        {
            List<ModelItem> listItem = new List<ModelItem>();

            DataTable dt = m_dalProduct.GetProductSpecsListForCombo(_productId);

            if (dt != null && dt.Rows.Count > 0)
            {
                foreach (DataRow dr in dt.Rows)
                {
                    ModelItem modelItem = new ModelItem();
                    modelItem.itemKey = ConvertUtils.ConvertToInt(dr["id"]);
                    modelItem.itemValue = ConvertUtils.ConvertToString(dr["name"]);

                    listItem.Add(modelItem);
                }
            }
            return listItem; 
            
        }

        public Boolean DeleteProductSpecs(ModelProductSpecs _modelProductSpecs)
        {
            int rtn = 0;
            rtn = m_dalProduct.DeleteProductSpecs(_modelProductSpecs);

            return rtn == 0 ? false : true;
        }

        public List<ModelItem> GetExcuteStandard()
        {
            List<ModelItem> listItem = new List<ModelItem>();

            DataTable dt = m_dalProduct.GetExcuteStandard();

            if (dt != null && dt.Rows.Count > 0)
            {
                foreach (DataRow dr in dt.Rows)
                {
                    ModelItem modelItem = new ModelItem();
                    modelItem.itemKey = 1;
                    modelItem.itemValue = ConvertUtils.ConvertToString(dr["excuteStandard"]);

                    listItem.Add(modelItem);
                }
            }
            return listItem;
        }

        public Boolean UpdateProductPrice(List<ModelProductPrice> _listModelProductPrice)
        {
            int rtn = 0;
            rtn = m_dalProduct.UpdateProductPrice(_listModelProductPrice);

            return rtn == 0 ? false : true;
        }
    }

}
