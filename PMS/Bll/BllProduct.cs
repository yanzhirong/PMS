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

                DataTable dtPrice = m_dalProduct.GetProductPriceById(_productId);
                if (dtPrice != null && dtPrice.Rows.Count > 0)
                {
                    modelProduct.modelProductPrice = ModelUtils<ModelProductPrice>.FillModel(dtPrice.Rows[0]);
                }
                else
                {
                    modelProduct.modelProductPrice = new ModelProductPrice();
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
    }

}
