using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Model;
using Enum;
using Common.Tools;

namespace Dal
{
    public class DalStore
    {
        StringBuilder sbSql = new StringBuilder();

        public DataTable GetStoreProductNum(int _factoryId, int _productId, DateTime _expiresDate)
        {
            sbSql.Clear();
            sbSql.Append("select a.stockNum ");
            sbSql.Append("from p_product_input a ");
            sbSql.Append("where a.isDelete = 0 ");
            sbSql.Append("  and a.factoryId = ").Append(_factoryId).Append(" ");
            sbSql.Append("  and a.productId = ").Append(_productId).Append(" ");
            sbSql.Append("  and a.expiresDate >= '").Append(_expiresDate).Append("' ");
            sbSql.Append("  and a.inputStatus = 1 ");
            sbSql.Append("  and a.stockNum > 0 ");

            return Dal.DBHelper.Select(sbSql.ToString());
        }

        public DataTable GetStoreMaterialsNum(int _factoryId, int _materialsId, DateTime _expiresDate)
        {
            sbSql.Clear();
            sbSql.Append("select a.stockNum, ");
            sbSql.Append("       b.value2 unit ");
            sbSql.Append("from p_materials_input a ");
            sbSql.Append("left join m_code b ");
            sbSql.Append("  on a.inputUnit = b.subCode ");
            sbSql.Append(" and b.code = 3 ");
            sbSql.Append("where a.isDelete = 0 ");
            sbSql.Append("  and a.factoryId = ").Append(_factoryId).Append(" ");
            sbSql.Append("  and a.materialsId = ").Append(_materialsId).Append(" ");
            sbSql.Append("  and a.expiresDate >= '").Append(_expiresDate).Append("' ");
            sbSql.Append("  and a.inputStatus = 1 ");
            sbSql.Append("  and a.stockNum > 0 ");

            return Dal.DBHelper.Select(sbSql.ToString());
        }

        public DataTable GetProductStore(string _productName, int _factoryId)
        {
            sbSql.Clear();
            sbSql.Append("select c.name productName, ");
            sbSql.Append("       d.name factoryName, ");
            sbSql.Append("       date_format(a.expiresDate, '%Y-%m-%d') expiresDate, ");
            sbSql.Append("       a.stockNum ");
            sbSql.Append("from p_product_input a ");
            sbSql.Append("left join p_product c ");
            sbSql.Append("  on a.productId = c.id ");
            sbSql.Append("left join m_factory d ");
            sbSql.Append("  on a.factoryId = d.id ");
            sbSql.Append("where a.isDelete = 0 ");
            if (_factoryId > 0)
            {
                sbSql.Append("  and a.factoryId = ").Append(_factoryId).Append(" ");
            }
            if (Common.Tools.StringUtils.IsNotBlank(_productName))
            {
                sbSql.Append("   and a.productId in (");
                sbSql.Append("                     select productId ");
                sbSql.Append("                       from r_product_search ");
                sbSql.Append("                      where productName like '%").Append(_productName).Append("%' or upper(searchKey) like '%").Append(_productName.ToUpper()).Append("%') ");
            }
            sbSql.Append("  and a.inputStatus = 1 ");
            sbSql.Append("  and a.stockNum > 0 ");

            return Dal.DBHelper.Select(sbSql.ToString());
        }

        public DataTable GetMaterialsStore(string _materialsName, int _factoryId)
        {
            sbSql.Clear();
            sbSql.Append("select c.name materialsName, ");
            sbSql.Append("       d.name factoryName, ");
            sbSql.Append("       date_format(a.expiresDate, '%Y-%m-%d') expiresDate, ");
            sbSql.Append("       concat(a.stockNum, b.value1) numDisplay ");
            sbSql.Append("from p_materials_input a ");
            sbSql.Append("left join m_code b ");
            sbSql.Append("  on a.inputUnit = b.subCode ");
            sbSql.Append(" and b.code = 3 ");
            sbSql.Append("left join p_materials c ");
            sbSql.Append("  on a.materialsId = c.id ");
            sbSql.Append("left join m_factory d ");
            sbSql.Append("  on a.factoryId = d.id ");
            sbSql.Append("where a.isDelete = 0 ");
            if (_factoryId > 0)
            {
                sbSql.Append("  and a.factoryId = ").Append(_factoryId).Append(" ");
            }
            if (Common.Tools.StringUtils.IsNotBlank(_materialsName))
            {
                sbSql.Append("   and a.materialsId in (");
                sbSql.Append("                     select materialsId ");
                sbSql.Append("                       from r_materials_search ");
                sbSql.Append("                      where materialsName like '%").Append(_materialsName).Append("%' or upper(searchKey) like '%").Append(_materialsName.ToUpper()).Append("%') ");
            }
            sbSql.Append("  and a.inputStatus = 1 ");
            sbSql.Append("  and a.stockNum > 0 ");

            return Dal.DBHelper.Select(sbSql.ToString());
        }

        public DataTable GetMaterialsOutputLogByInputCode(string _inputCode)
        {
            sbSql.Clear();
            sbSql.Append("select * ");
            sbSql.Append("  from h_materials_output_log ");
            sbSql.Append(" where isDelete = 0 ");
            sbSql.Append("   and inputCode = '").Append(_inputCode).Append("' ");
            sbSql.Append(" order by id ");

            return Dal.DBHelper.Select(sbSql.ToString());
        }

        public DataTable GetMaterialsOutputLogByOutputCode(string _outputCode)
        {
            sbSql.Clear();
            sbSql.Append("select b.name factoryName, ");
            sbSql.Append("       c.name materialsName, ");
            sbSql.Append("       concat(a.outputNum, d.value1) numDisplay, ");
            sbSql.Append("       date_format(a.outputDate, '%Y-%m-%d') outputDate, ");
            sbSql.Append("       e.userName applyMember ");
            sbSql.Append("  from h_materials_output_log a ");
            sbSql.Append("  left join m_factory b ");
            sbSql.Append("    on a.factoryId = b.id ");
            sbSql.Append("  left join p_materials c ");
            sbSql.Append("    on a.materialsId = c.id ");
            sbSql.Append("  left join m_code d ");
            sbSql.Append("    on a.outputUnit = d.subCode ");
            sbSql.Append("   and d.code = 3 ");
            sbSql.Append("  left join m_user e ");
            sbSql.Append("    on a.applyMemberId = e.userId ");
            sbSql.Append(" where a.isDelete = 0 ");
            sbSql.Append("   and a.outputCode = '").Append(_outputCode).Append("' ");
            sbSql.Append(" order by a.id ");

            return Dal.DBHelper.Select(sbSql.ToString());
        }

        public DataTable GetProductOutputLogByInputCode(string _inputCode)
        {
            sbSql.Clear();
            sbSql.Append("select * ");
            sbSql.Append("  from h_product_output_log ");
            sbSql.Append(" where isDelete = 0 ");
            sbSql.Append("   and inputCode = '").Append(_inputCode).Append("' ");
            sbSql.Append(" order by id ");

            return Dal.DBHelper.Select(sbSql.ToString());
        }

        public DataTable GetProductOutputLog(string _outputCode, int _productId)
        {
            sbSql.Clear();
            sbSql.Append("select b.name factoryName, ");
            sbSql.Append("       c.name ProductName, ");
            sbSql.Append("       a.outputNum num, ");
            sbSql.Append("       date_format(a.outputDate, '%Y-%m-%d') outputDate, ");
            sbSql.Append("       d.userName applyMember ");
            sbSql.Append("  from h_product_output_log a ");
            sbSql.Append("  left join m_factory b ");
            sbSql.Append("    on a.factoryId = b.id ");
            sbSql.Append("  left join p_product c ");
            sbSql.Append("    on a.productId = c.id ");
            sbSql.Append("  left join m_user d ");
            sbSql.Append("    on a.applyMemberId = d.userId ");
            sbSql.Append(" where a.isDelete = 0 ");
            sbSql.Append("   and a.outputCode = '").Append(_outputCode).Append("' ");
            sbSql.Append("   and a.productId = ").Append(_productId).Append(" ");
            sbSql.Append(" order by a.id ");

            return Dal.DBHelper.Select(sbSql.ToString());
        }

        public DataTable GetTransfer(string _name, int _factoryId, int _type, DateTime _beginTime, DateTime _endTime)
        {
            sbSql.Clear();
            sbSql.Append("select a.id, ");
            sbSql.Append("       case a.type when 0 then '产品调拨' else '物料调拨' end type, ");
            sbSql.Append("       case a.type when 0 then d.name else e.name end name, ");
            sbSql.Append("       b.name fromFactoryName, ");
            sbSql.Append("       e.name toFactoryName, ");
            sbSql.Append("       case a.type when 0 then a.num else concat(a.num, h.value1) end transferNum, ");
            sbSql.Append("       f.userName applyMember, ");
            sbSql.Append("       date_format(a.applyDate, '%Y-%m-%d') applyDate, ");
            sbSql.Append("       g.userName transferBy, ");
            sbSql.Append("       date_format(a.transferDate, '%Y-%m-%d') transferDate, ");
            sbSql.Append("       '查看' detailBtn ");
            sbSql.Append("  from h_transfer_log a ");
            sbSql.Append("  left join m_factory b ");
            sbSql.Append("    on a.fromFactoryId = b.id ");
            sbSql.Append("  left join m_factory c ");
            sbSql.Append("    on a.toFactoryId = c.id ");
            sbSql.Append("  left join p_product d ");
            sbSql.Append("    on a.productId = d.id ");
            sbSql.Append("  left join p_materials e ");
            sbSql.Append("    on a.materialsId = e.id ");
            sbSql.Append("  left join m_user f ");
            sbSql.Append("    on a.applyMemberId = f.userId ");
            sbSql.Append("  left join m_user g ");
            sbSql.Append("    on a.transferMemberId = g.userId ");
            sbSql.Append("  left join m_code h ");
            sbSql.Append("    on a.unit = h.subCode ");
            sbSql.Append("   and h.code = 3 ");
            sbSql.Append(" where a.isDelete = 0 ");
            sbSql.Append("   and a.type = ").Append(_type).Append(" ");
            if (_factoryId > 0)
            {
                sbSql.Append("   and a.toFactoryId = ").Append(_factoryId).Append(" ");
            }
            if (StringUtils.IsNotBlank(_name))
            {
                if (_type == 0)
                {
                    sbSql.Append("   and a.productId in (");
                    sbSql.Append("                     select productId ");
                    sbSql.Append("                       from r_product_search ");
                    sbSql.Append("                      where productName like '%").Append(_name).Append("%' or upper(searchKey) like '%").Append(_name.ToUpper()).Append("%') ");
                }
                else
                {
                    sbSql.Append("   and a.materialsId in (");
                    sbSql.Append("                     select materialsId ");
                    sbSql.Append("                       from r_materials_search ");
                    sbSql.Append("                      where materialsName like '%").Append(_name).Append("%' or upper(searchKey) like '%").Append(_name.ToUpper()).Append("%') ");
                }
            }
            sbSql.Append("  and a.transferDate >= '").Append(_beginTime).Append("' ");
            sbSql.Append("  and a.transferDate <= '").Append(_endTime).Append("' ");
            sbSql.Append(" order by a.id desc");

            return Dal.DBHelper.Select(sbSql.ToString()); 
        }

        public DataTable GetStore(int _type, string _name, int _factoryId, DateTime _expiresDate, DateTime _inputDate_begin, DateTime _inputDate_end, decimal _stockNum)
        {
            sbSql.Clear();
            sbSql.Append("select a.id, ");
            if (_type == 0)
            {
                sbSql.Append("       '产品' type, ");
            }
            else
            {
                sbSql.Append("       '物料' type, ");
            }
            sbSql.Append("       a.inputCode, ");
            sbSql.Append("       b.name factoryName, ");
            sbSql.Append("       c.name, ");
            if (_type == 0)
            {
                sbSql.Append("      a.inputNum, ");
            }
            else
            {
                sbSql.Append("       concat(a.inputNum, d.value1) inputNum, ");
            }
            if (_type == 0)
            {
                sbSql.Append("      a.stockNum, ");
            }
            else
            {
                sbSql.Append("      concat(a.stockNum, d.value1) stockNum, ");
            }
            sbSql.Append("       date_format(a.produceDate, '%Y-%m-%d') produceDate, ");
            sbSql.Append("       date_format(a.inputDate, '%Y-%m-%d') inputDate, ");
            sbSql.Append("       date_format(a.expiresDate, '%Y-%m-%d') expiresDate, ");
            sbSql.Append("       '编辑' modifyBtn ");
            if (_type == 0)
            {
                sbSql.Append("  from p_product_input a ");
            }
            else
            {
                sbSql.Append("  from p_materials_input a ");
            }
            sbSql.Append("  left join m_factory b ");
            sbSql.Append("    on a.factoryId = b.id ");
            if (_type == 0)
            {
                sbSql.Append("  left join p_product c ");
                sbSql.Append("    on a.productId = c.id ");
            }
            else
            {
                sbSql.Append("  left join p_materials c ");
                sbSql.Append("    on a.materialsId = c.id ");
                sbSql.Append("  left join m_code d ");
                sbSql.Append("    on a.inputUnit = d.subCode ");
                sbSql.Append("   and d.code = 3 ");
            }
            sbSql.Append(" where a.isDelete = 0 ");
            if (_factoryId > 0)
            {
                sbSql.Append("  and a.factoryId = ").Append(_factoryId).Append(" ");
            }
            if (StringUtils.IsNotBlank(_name))
            {
                if (_type == 0)
                {
                    sbSql.Append("   and a.productId in (");
                    sbSql.Append("                     select productId ");
                    sbSql.Append("                       from r_product_search ");
                    sbSql.Append("                      where productName like '%").Append(_name).Append("%' or upper(searchKey) like '%").Append(_name.ToUpper()).Append("%') ");
                }
                else
                {
                    sbSql.Append("   and a.materialsId in (");
                    sbSql.Append("                     select materialsId ");
                    sbSql.Append("                       from r_materials_search ");
                    sbSql.Append("                      where materialsName like '%").Append(_name).Append("%' or upper(searchKey) like '%").Append(_name.ToUpper()).Append("%') ");
                }
            }
            sbSql.Append("  and a.expiresDate <= '").Append(_expiresDate).Append("' ");
            sbSql.Append("  and a.inputDate >= '").Append(_inputDate_begin).Append("' ");
            sbSql.Append("  and a.inputDate <= '").Append(_inputDate_end).Append("' ");
            if (_stockNum > 0)
            {
                sbSql.Append("  and a.stockNum <= ").Append(_stockNum).Append(" ");
            }
            sbSql.Append("  and a.stockNum > 0 ");
            sbSql.Append(" order by a.expiresDate, stockNum desc");

            return Dal.DBHelper.Select(sbSql.ToString());
        }

        public DataTable GetStoreExport(int _type, string _name, int _factoryId, DateTime _expiresDate, DateTime _inputDate_begin, DateTime _inputDate_end, decimal _stockNum)
        {
            sbSql.Clear();
            sbSql.Append("select ");
            if (_type == 0)
            {
                sbSql.Append("       '产品' 类型, ");
            }
            else
            {
                sbSql.Append("       '物料' 类型, ");
            }
            sbSql.Append("       a.inputCode 入库单号, ");
            sbSql.Append("       b.name 工厂名称, ");
            if (_type == 0)
            {
                sbSql.Append("       c.name 产品名称, ");
            }
            else
            {
                sbSql.Append("       c.name 物料名称, ");
            }
            if (_type == 0)
            {
                sbSql.Append("      a.inputNum 入库数, ");
            }
            else
            {
                sbSql.Append("       concat(a.inputNum, d.value1) 入库数, ");
            }
            if (_type == 0)
            {
                sbSql.Append("      a.stockNum 库存数, ");
            }
            else
            {
                sbSql.Append("      concat(a.stockNum, d.value1) 库存数, ");
            }
            sbSql.Append("       date_format(a.produceDate, '%Y-%m-%d') 生产日, ");
            sbSql.Append("       date_format(a.inputDate, '%Y-%m-%d') 入库日, ");
            sbSql.Append("       date_format(a.expiresDate, '%Y-%m-%d') 过期日 ");
            if (_type == 0)
            {
                sbSql.Append("  from p_product_input a ");
            }
            else
            {
                sbSql.Append("  from p_materials_input a ");
            }
            sbSql.Append("  left join m_factory b ");
            sbSql.Append("    on a.factoryId = b.id ");
            if (_type == 0)
            {
                sbSql.Append("  left join p_product c ");
                sbSql.Append("    on a.productId = c.id ");
            }
            else
            {
                sbSql.Append("  left join p_materials c ");
                sbSql.Append("    on a.materialsId = c.id ");
                sbSql.Append("  left join m_code d ");
                sbSql.Append("    on a.inputUnit = d.subCode ");
                sbSql.Append("   and d.code = 3 ");
            }
            sbSql.Append(" where a.isDelete = 0 ");
            if (_factoryId > 0)
            {
                sbSql.Append("  and a.factoryId = ").Append(_factoryId).Append(" ");
            }
            if (StringUtils.IsNotBlank(_name))
            {
                if (_type == 0)
                {
                    sbSql.Append("   and a.productId in (");
                    sbSql.Append("                     select productId ");
                    sbSql.Append("                       from r_product_search ");
                    sbSql.Append("                      where productName like '%").Append(_name).Append("%' or upper(searchKey) like '%").Append(_name.ToUpper()).Append("%') ");
                }
                else
                {
                    sbSql.Append("   and a.materialsId in (");
                    sbSql.Append("                     select materialsId ");
                    sbSql.Append("                       from r_materials_search ");
                    sbSql.Append("                      where materialsName like '%").Append(_name).Append("%' or upper(searchKey) like '%").Append(_name.ToUpper()).Append("%') ");
                }
            }
            sbSql.Append("  and a.expiresDate <= '").Append(_expiresDate).Append("' ");
            sbSql.Append("  and a.inputDate >= '").Append(_inputDate_begin).Append("' ");
            sbSql.Append("  and a.inputDate <= '").Append(_inputDate_end).Append("' ");
            if (_stockNum > 0)
            {
                sbSql.Append("  and a.stockNum <= ").Append(_stockNum).Append(" ");
            }
            sbSql.Append("  and a.stockNum > 0 ");
            sbSql.Append(" order by a.expiresDate, stockNum desc");

            return Dal.DBHelper.Select(sbSql.ToString());
        }

        public int UpdateInventoryProduct(ModelProductIn _modelProductIn, ModelInventoryProductLog _modelInventoryProductLog)
        {
            List<string> listSql = new List<string>();

            sbSql.Clear();
            sbSql.Append("update p_product_input ");
            sbSql.Append("set stockNum = " + _modelProductIn.stockNum + ",");
            sbSql.Append("    produceDate = '" + _modelProductIn.produceDate + "',");
            sbSql.Append("    expiresDate = '" + _modelProductIn.expiresDate + "',");
            sbSql.Append("    remark = '" + _modelProductIn.remark + "',");
            sbSql.Append("    modifyBy = '" + _modelProductIn.modifyBy + "',");
            sbSql.Append("    modifyTime = '" + _modelProductIn.modifyTime + "' ");
            sbSql.Append("where id = " + _modelProductIn.id);
            listSql.Add(sbSql.ToString());

            sbSql.Clear();
            sbSql.Append("insert into ");
            sbSql.Append("       h_inventory_product_log ( ");
            sbSql.Append("       inputCode, ");
            sbSql.Append("       factoryId, ");
            sbSql.Append("       productId, ");
            sbSql.Append("       stockNumOld, ");
            sbSql.Append("       stockNumNew, ");
            sbSql.Append("       produceDateOld, ");
            sbSql.Append("       produceDateNew, ");
            sbSql.Append("       expiresDateOld, ");
            sbSql.Append("       expiresDateNew, ");
            sbSql.Append("       remark, ");
            sbSql.Append("       isDelete, ");
            sbSql.Append("       createBy, ");
            sbSql.Append("       createTime ");
            sbSql.Append("       ) values ( ");
            sbSql.Append("      '" + _modelInventoryProductLog.inputCode + "', ");
            sbSql.Append("       " + _modelInventoryProductLog.factoryId + ", ");
            sbSql.Append("       " + _modelInventoryProductLog.productId + ", ");
            sbSql.Append("       " + _modelInventoryProductLog.stockNumOld + ", ");
            sbSql.Append("       " + _modelInventoryProductLog.stockNumNew + ", ");
            sbSql.Append("      '" + _modelInventoryProductLog.produceDateOld + "', ");
            sbSql.Append("      '" + _modelInventoryProductLog.produceDateNew + "', ");
            sbSql.Append("      '" + _modelInventoryProductLog.expiresDateOld + "', ");
            sbSql.Append("      '" + _modelInventoryProductLog.expiresDateNew + "', ");
            sbSql.Append("      '" + _modelInventoryProductLog.remark + "', ");
            sbSql.Append("       " + _modelInventoryProductLog.isDelete + ", ");
            sbSql.Append("      '" + _modelInventoryProductLog.createBy + "', ");
            sbSql.Append("      '" + _modelInventoryProductLog.createTime + "')");
            listSql.Add(sbSql.ToString());

            return Dal.DBHelper.ExcuteTransaction(listSql);

        }

        public int UpdateInventoryMaterials(ModelMaterialsIn _modelMaterialsIn, ModelInventoryMaterialsLog _modelInventoryMaterialsLog)
        {
            List<string> listSql = new List<string>();

            sbSql.Clear();
            sbSql.Append("update p_materials_input ");
            sbSql.Append("set stockNum = " + _modelMaterialsIn.stockNum + ",");
            sbSql.Append("    produceDate = '" + _modelMaterialsIn.produceDate + "',");
            sbSql.Append("    expiresDate = '" + _modelMaterialsIn.expiresDate + "',");
            sbSql.Append("    remark = '" + _modelMaterialsIn.remark + "',");
            sbSql.Append("    modifyBy = '" + _modelMaterialsIn.modifyBy + "',");
            sbSql.Append("    modifyTime = '" + _modelMaterialsIn.modifyTime + "' ");
            sbSql.Append("where id = " + _modelMaterialsIn.id);
            listSql.Add(sbSql.ToString());

            sbSql.Clear();
            sbSql.Append("insert into ");
            sbSql.Append("       h_inventory_materials_log ( ");
            sbSql.Append("       inputCode, ");
            sbSql.Append("       factoryId, ");
            sbSql.Append("       materialsId, ");
            sbSql.Append("       unit, ");
            sbSql.Append("       stockNumOld, ");
            sbSql.Append("       stockNumNew, ");
            sbSql.Append("       produceDateOld, ");
            sbSql.Append("       produceDateNew, ");
            sbSql.Append("       expiresDateOld, ");
            sbSql.Append("       expiresDateNew, ");
            sbSql.Append("       remark, ");
            sbSql.Append("       isDelete, ");
            sbSql.Append("       createBy, ");
            sbSql.Append("       createTime ");
            sbSql.Append("       ) values ( ");
            sbSql.Append("      '" + _modelInventoryMaterialsLog.inputCode + "', ");
            sbSql.Append("       " + _modelInventoryMaterialsLog.factoryId + ", ");
            sbSql.Append("       " + _modelInventoryMaterialsLog.materialsId + ", ");
            sbSql.Append("       " + _modelInventoryMaterialsLog.unit + ", ");
            sbSql.Append("       " + _modelInventoryMaterialsLog.stockNumOld + ", ");
            sbSql.Append("       " + _modelInventoryMaterialsLog.stockNumNew + ", ");
            sbSql.Append("      '" + _modelInventoryMaterialsLog.produceDateOld + "', ");
            sbSql.Append("      '" + _modelInventoryMaterialsLog.produceDateNew + "', ");
            sbSql.Append("      '" + _modelInventoryMaterialsLog.expiresDateOld + "', ");
            sbSql.Append("      '" + _modelInventoryMaterialsLog.expiresDateNew + "', ");
            sbSql.Append("      '" + _modelInventoryMaterialsLog.remark + "', ");
            sbSql.Append("       " + _modelInventoryMaterialsLog.isDelete + ", ");
            sbSql.Append("      '" + _modelInventoryMaterialsLog.createBy + "', ");
            sbSql.Append("      '" + _modelInventoryMaterialsLog.createTime + "')");
            listSql.Add(sbSql.ToString());

            return Dal.DBHelper.ExcuteTransaction(listSql);

        }
    }
}
