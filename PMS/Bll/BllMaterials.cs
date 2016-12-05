using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dal;
using System.Data;
using Common.Enum;
using Common.Tools;
using Model;

namespace Bll
{
    public class BllMaterials : Bll.BllBase
    {
        private DalMaterials m_dalMaterials = new DalMaterials();

        public DataTable GetMaterials(string _name)
        {
            DataTable dt = m_dalMaterials.GetMaterials(_name);

            return dt;
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
                    modelMaterials.modelMaterialsPrice = ModelUtils<ModelMaterialsPrice>.FillModel(dtPrice.Rows[0]);
                }
                else
                {
                    modelMaterials.modelMaterialsPrice = new ModelMaterialsPrice();
                }

                return modelMaterials;
            }
            else
            {
                return new ModelMaterials();
            }
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
    }

}
