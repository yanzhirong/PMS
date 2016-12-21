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
    public static class BllArea
    {
        private static DalArea m_dalArea = new DalArea();

        private static List<ModelArea> listAllArea = GetAllArea();

        public static List<ModelArea> GetAllArea()
        {
            DataTable dt = m_dalArea.GetAllArea();

            if(dt != null && dt.Rows.Count > 0)
            {
                return ModelUtils<ModelArea>.FillModel(dt);
            }
            return null;
        }

        public static List<ModelItem> GetProvince()
        {
            List<ModelItem> listProvince = new List<ModelItem>();

            DataTable dt = m_dalArea.GetProvince();

            if(dt != null && dt.Rows.Count > 0)
            {
 
                foreach(DataRow dr in dt.Rows)
                {
                    ModelItem item = new ModelItem();
                    item.itemKey = dr["areaId"];
                    item.itemValue = (String)dr["areaName"];

                    listProvince.Add(item);
                }
            }
            return listProvince;
        }

        public static List<ModelItem> GetCity(int _provinceId)
        {
            List<ModelItem> listCity = new List<ModelItem>();

            if (listAllArea == null || listAllArea.Count <= 0)
            {
                listAllArea = GetAllArea();
            }

            foreach (ModelArea area in listAllArea)
            {
                if (area.parentId != null && area.parentId == _provinceId)
                {
                    ModelItem item = new ModelItem();
                    item.itemKey = area.areaId;
                    item.itemValue = area.areaName;

                    listCity.Add(item);
                }
            }

            return listCity;
        }


        public static List<ModelItem> GetDistrict(int _cityId)
        {
            List<ModelItem> listDistrict = new List<ModelItem>();

            if (listAllArea == null || listAllArea.Count <= 0)
            {
                listAllArea = GetAllArea();
            }

            foreach (ModelArea area in listAllArea)
            {
                if (area.parentId != null && area.parentId == _cityId)
                {
                    ModelItem item = new ModelItem();
                    item.itemKey = area.areaId;
                    item.itemValue = area.areaName;

                    listDistrict.Add(item);
                }
            }

            return listDistrict;
        }
    }
}
