using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dal;
using System.Data;
using Common.Tools;
using Model;

namespace Bll
{
    public class BllMaterials : Bll.BllBase
    {
        private DalMaterials m_dalMaterials = new DalMaterials();

        public DataTable GetMaterials(string _name, int _type)
        {
            DataTable dt = m_dalMaterials.GetMaterials(_name, _type);

            return dt;
        }

        public DataTable GetMaterialsBySearchKey(string _searchKey)
        {
            DataTable dt = m_dalMaterials.GetMaterialsBySearchKey(_searchKey);

            return dt;
        }

        public List<ModelItem> GetMaterialsItem(string _searchKey)
        {
            List<ModelItem> listItem = new List<ModelItem>();

            DataTable dt = m_dalMaterials.GetMaterialsBySearchKey(_searchKey);

            if (dt != null && dt.Rows.Count > 0)
            {
                foreach (DataRow dr in dt.Rows)
                {
                    ModelItem modelItem = new ModelItem();
                    modelItem.itemKey = ConvertUtils.ConvertToInt(dr["materialsId"]);
                    modelItem.itemValue = ConvertUtils.ConvertToString(dr["materialsName"]);

                    listItem.Add(modelItem);
                }
            }
            return listItem;
        }

        public List<ModelItem> GetMaterialsItemByType(int _type)
        {
            List<ModelItem> listItem = new List<ModelItem>();

            DataTable dt = m_dalMaterials.GetMaterialsItemByType(_type);

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

        public ModelMaterials GetMaterialsById(int _materialsId)
        {
            DataTable dt = m_dalMaterials.GetMaterialsById(_materialsId);

            if (dt != null && dt.Rows.Count > 0)
            {
                ModelMaterials modelMaterials = new ModelMaterials();
                modelMaterials = ModelUtils<ModelMaterials>.FillModel(dt.Rows[0]);

                DataTable dtSearch = m_dalMaterials.GetMaterialsSearchById(_materialsId);
                if (dtSearch != null && dtSearch.Rows.Count > 0)
                {
                    modelMaterials.modelMaterialsSearch = ModelUtils<ModelMaterialsSearch>.FillModel(dtSearch.Rows[0]);
                }
                else
                {
                    modelMaterials.modelMaterialsSearch = new ModelMaterialsSearch();
                }

                DataTable dtPrice = m_dalMaterials.GetMaterialsPriceById(_materialsId);
                if (dtPrice != null && dtPrice.Rows.Count > 0)
                {
                    modelMaterials.modelMaterialsPrice = ModelUtils<ModelMaterialsPrice>.FillModel(dtPrice);
                }
                else
                {
                    modelMaterials.modelMaterialsPrice = new List<ModelMaterialsPrice>();
                }

                return modelMaterials;
            }
            else
            {
                return new ModelMaterials();
            }
        }

        public DataTable GetProductMaterialsById(int _materialsId)
        {
            return m_dalMaterials.GetProductMaterialsById(_materialsId);
        }

        public ModelMaterials GetMaterialsByName(string _name)
        {
            DataTable dt = m_dalMaterials.GetMaterialsByName(_name);

            if (dt != null && dt.Rows.Count > 0)
            {
                return ModelUtils<ModelMaterials>.FillModel(dt.Rows[0]); ;
            }
            return new ModelMaterials();
        }

        public Boolean AddMaterials(ModelMaterials _modelMaterials)
        {
            int rtn = 0;
            rtn = m_dalMaterials.AddMaterials(_modelMaterials);

            return rtn == 0 ? false : true;
        }

        public int AddMaterialsSpecs(ModelMaterialsSpecs _model)
        {
            int rtn = 0;
            rtn = m_dalMaterials.AddMaterialsSpecs(_model);

            if (rtn > 0)
            {
                DataTable dt = m_dalMaterials.GetMaterialsSpecsByName(_model.name);
                if (dt != null && dt.Rows.Count > 0)
                {
                    return ModelUtils<ModelMaterialsSpecs>.FillModel(dt.Rows[0]).id;
                }
                else
                {
                    return 0;
                }
            }

            return rtn;

        }

        public int AddMaterialsPrice(ModelMaterialsPrice _model)
        {
            int rtn = 0;
            rtn = m_dalMaterials.AddMaterialsPrice(_model);

            if (rtn > 0)
            {
                DataTable dt = m_dalMaterials.GetMaterialsPriceById(_model.materialsId, _model.specsId);
                if (dt != null && dt.Rows.Count > 0)
                {
                    return ConvertUtils.ConvertToInt(dt.Rows[0]["id"]);
                }
                else
                {
                    return 0;
                }
            }
            return 0 ;
        }

        public Boolean UpdateMaterials(ModelMaterials _modelMaterials)
        {
            int rtn = 0;
            rtn = m_dalMaterials.UpdateMaterials(_modelMaterials);

            return rtn == 0 ? false : true;
        }

        public Boolean DeleteMaterials(ModelMaterials _modelMaterials)
        {
            int rtn = 0;
            rtn = m_dalMaterials.DeleteMaterials(_modelMaterials);

            return rtn == 0 ? false : true;
        }

        public DataTable GetMaterialsSpecsListByMaterialsId(int _materialsId)
        {
            return m_dalMaterials.GetMaterialsSpecsListByMaterialsId(_materialsId);
        }

        public ModelMaterialsSpecs GetMaterialsSpecsById(int _specsId)
        {
            DataTable dt =  m_dalMaterials.GetMaterialsSpecsListById(_specsId);
            if (dt != null && dt.Rows.Count > 0)
            {
                return ModelUtils<ModelMaterialsSpecs>.FillModel(dt.Rows[0]); ;
            }
            return new ModelMaterialsSpecs();
        }

        public ModelMaterialsPrice GetMaterialsPriceById(int _materialsId, int _specsId)
        {
            DataTable dt = m_dalMaterials.GetMaterialsPriceById(_materialsId, _specsId);
            if (dt != null && dt.Rows.Count > 0)
            {
                return ModelUtils<ModelMaterialsPrice>.FillModel(dt.Rows[0]); ;
            }
            return new ModelMaterialsPrice();
        }

        public ModelMaterialsPrice GetMaterialsPriceByMaterialsId(int _materialsId)
        {
            DataTable dt = m_dalMaterials.GetMaterialsPriceByMaterialsId(_materialsId);
            if (dt != null && dt.Rows.Count > 0)
            {
                return ModelUtils<ModelMaterialsPrice>.FillModel(dt.Rows[0]); ;
            }
            return new ModelMaterialsPrice();
        }

        public List<ModelItem> GetMaterialsSpecsListForCombo(int _materialsId)
        {
            List<ModelItem> listItem = new List<ModelItem>();

            DataTable dt = m_dalMaterials.GetMaterialsSpecsListForCombo(_materialsId);

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

        public Boolean DeleteMaterialsSpecs(ModelMaterialsSpecs _modelMaterialsSpecs)
        {
            int rtn = 0;
            rtn = m_dalMaterials.DeleteMaterialsSpecs(_modelMaterialsSpecs);

            return rtn == 0 ? false : true;
        }

        public List<ModelItem> GetExcuteStandard()
        {
            List<ModelItem> listItem = new List<ModelItem>();

            DataTable dt = m_dalMaterials.GetExcuteStandard();

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
    }

}
