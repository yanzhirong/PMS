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

        public DataTable GetStoreProductNum(int _factoryId, int _productId, int _specsId, DateTime _expiresDate)
        {
            sbSql.Clear();
            sbSql.Append("select a.stockNum ");
            sbSql.Append("from p_product_input a ");
            sbSql.Append("where a.isDelete = 0 ");
            sbSql.Append("  and a.factoryId = ").Append(_factoryId).Append(" ");
            sbSql.Append("  and a.productId = ").Append(_productId).Append(" ");
            sbSql.Append("  and a.specsId = ").Append(_specsId).Append(" ");
            sbSql.Append("  and a.expiresDate >= '").Append(_expiresDate).Append("' ");
            sbSql.Append("  and a.inputStatus = 1 ");
            sbSql.Append("  and a.stockNum > 0 ");

            return Dal.DBHelper.Select(sbSql.ToString());
        }

        public DataTable GetStoreMaterialsNum(int _factoryId, int _materialsId, DateTime _expiresDate)
        {
            sbSql.Clear();
            sbSql.Append("select a.stockNum, ");
            sbSql.Append("       a.specsId ");
            sbSql.Append("from p_materials_input a ");
            sbSql.Append("where a.isDelete = 0 ");
            sbSql.Append("  and a.factoryId = ").Append(_factoryId).Append(" ");
            sbSql.Append("  and a.materialsId = ").Append(_materialsId).Append(" ");
            sbSql.Append("  and a.expiresDate >= '").Append(_expiresDate).Append("' ");
            sbSql.Append("  and a.inputStatus = 1 ");
            sbSql.Append("  and a.stockNum > 0 ");

            return Dal.DBHelper.Select(sbSql.ToString());
        }

        public DataTable GetProductStore(int _factoryId, string _productName, string _specsName)
        {
            sbSql.Clear();
            sbSql.Append("select c.name productName, ");
            sbSql.Append("       b.name specsName, ");
            sbSql.Append("       d.name factoryName, ");
            sbSql.Append("       date_format(a.expiresDate, '%Y-%m-%d') expiresDate, ");
            sbSql.Append("       a.stockNum ");
            sbSql.Append("from p_product_input a ");
            sbSql.Append("left join r_product_specs b ");
            sbSql.Append("  on a.specsId = b.id ");
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
            if (Common.Tools.StringUtils.IsNotBlank(_specsName))
            {
                sbSql.Append("   and a.specsId in (");
                sbSql.Append("                     select id ");
                sbSql.Append("                       from r_product_specs ");
                sbSql.Append("                      where name like '%").Append(_specsName).Append("%' ");
                sbSql.Append("                        and isDelete = 0 ) ");
            }
            sbSql.Append("  and a.inputStatus = 1 ");
            sbSql.Append("  and a.stockNum > 0 ");

            return Dal.DBHelper.Select(sbSql.ToString());
        }

        public DataTable GetMaterialsStore(int _factoryId, string _materialsName, string _specsName)
        {
            sbSql.Clear();
            sbSql.Append("select c.name materialsName, ");
            sbSql.Append("       e.name specsName, ");
            sbSql.Append("       d.name factoryName, ");
            sbSql.Append("       date_format(a.expiresDate, '%Y-%m-%d') expiresDate, ");
            sbSql.Append("       a.stockNum numDisplay ");
            sbSql.Append("from p_materials_input a ");
            sbSql.Append("left join p_materials c ");
            sbSql.Append("  on a.materialsId = c.id ");
            sbSql.Append("left join m_factory d ");
            sbSql.Append("  on a.factoryId = d.id ");
            sbSql.Append("left join r_materials_specs e ");
            sbSql.Append("  on a.materialsId = e.materialsId ");
            sbSql.Append(" and a.specsId = e.id ");
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
            if (Common.Tools.StringUtils.IsNotBlank(_specsName))
            {
                sbSql.Append("   and a.specsId in (");
                sbSql.Append("                     select id ");
                sbSql.Append("                       from r_materials_specs ");
                sbSql.Append("                      where name like '%").Append(_specsName).Append("%' ");
                sbSql.Append("                        and isDelete = 0 ) ");
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

        public DataTable GetMaterialsOutputLogByOutputCode(string _outputCode, int _materialsId, int _specsId)
        {
            sbSql.Clear();
            sbSql.Append("select c.name materialsName, ");
            sbSql.Append("       d.name specsName, ");
            sbSql.Append("       a.inputCode, ");
            sbSql.Append("       a.outputNum numDisplay, ");
            sbSql.Append("       date_format(a.outputDate, '%Y-%m-%d') outputDate, ");
            sbSql.Append("       e.userName applyMember ");
            sbSql.Append("  from h_materials_output_log a ");
            sbSql.Append("  left join m_factory b ");
            sbSql.Append("    on a.factoryId = b.id ");
            sbSql.Append("  left join p_materials c ");
            sbSql.Append("    on a.materialsId = c.id ");
            sbSql.Append("  left join r_materials_specs d ");
            sbSql.Append("    on a.materialsId = d.materialsId ");
            sbSql.Append("   and a.specsId = d.id ");
            sbSql.Append("  left join m_user e ");
            sbSql.Append("    on a.applyMemberId = e.userId ");
            sbSql.Append(" where a.isDelete = 0 ");
            sbSql.Append("   and a.outputCode = '").Append(_outputCode).Append("' ");
            sbSql.Append("   and a.materialsId = ").Append(_materialsId).Append(" ");
            sbSql.Append("   and ifnull(a.specsId, 0) = ").Append(_specsId).Append(" ");
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

        public DataTable GetProductOutputLogByOutputCode(string _outputCode)
        {
            sbSql.Clear();
            sbSql.Append("select * ");
            sbSql.Append("  from h_product_output_log ");
            sbSql.Append(" where isDelete = 0 ");
            sbSql.Append("   and outputCode = '").Append(_outputCode).Append("' ");
            sbSql.Append(" order by id ");

            return Dal.DBHelper.Select(sbSql.ToString());
        }

        public DataTable GetProductOutputLog(string _outputCode, int _productId, int _specsId)
        {
            sbSql.Clear();
            sbSql.Append("select a.inputCode, ");
            sbSql.Append("       c.name ProductName, ");
            sbSql.Append("       e.name specsName, ");
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
            sbSql.Append("  left join r_product_specs e ");
            sbSql.Append("    on a.specsId = e.id ");
            sbSql.Append(" where a.isDelete = 0 ");
            sbSql.Append("   and a.outputCode = '").Append(_outputCode).Append("' ");
            sbSql.Append("   and a.productId = ").Append(_productId).Append(" ");
            sbSql.Append("   and a.specsId = ").Append(_specsId).Append(" ");
            sbSql.Append(" order by a.id ");

            return Dal.DBHelper.Select(sbSql.ToString());
        }

        public DataTable GetTransfer(string _name, int _factoryId, int _type, DateTime _beginTime, DateTime _endTime)
        {
            sbSql.Clear();
            sbSql.Append("select a.id, ");
            sbSql.Append("       case a.type when 0 then '成品调拨' else '原料调拨' end type, ");
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

        public DataTable GetStore(int _type, int _qc, string _name, int _factoryId, DateTime _expiresDate, DateTime _inputDate_begin, DateTime _inputDate_end, decimal _stockNum)
        {
            sbSql.Clear();
            sbSql.Append("select a.id, ");
            if (_type == 0)
            {
                sbSql.Append("       '成品' type, ");
                sbSql.Append("       case ifnull(e.inspectResult, 0) when 0 then '不合格' else '合格' end QC , ");
                sbSql.Append("       ifnull(f.minPrice, 0) price, ");
                sbSql.Append("       ifnull(f.minPrice, 0) * a.stockNum money, ");
            }
            else
            {
                sbSql.Append("       '原料' type, ");
                sbSql.Append("       case ifnull(a.isQualified, 0) when 0 then '不合格' else '合格' end QC , ");
                sbSql.Append("       ifnull(f.price, 0) price, ");
                sbSql.Append("       ifnull(f.price, 0) * a.stockNum money, ");
            }
            sbSql.Append("       a.inputCode, ");
            sbSql.Append("       b.name factoryName, ");
            sbSql.Append("       c.name, ");
            sbSql.Append("       d.name specsName, ");
            sbSql.Append("       a.stockNum, ");
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
                sbSql.Append("  left join r_product_specs d ");
                sbSql.Append("    on a.productId = d.productId ");
                sbSql.Append("   and a.specsId = d.id ");
                sbSql.Append("  left join r_product_input_quality e ");
                sbSql.Append("    on a.inputCode = e.inputCode ");
                sbSql.Append("   and e.isDelete = 0 ");
                sbSql.Append("  left join r_product_price f ");
                sbSql.Append("    on a.productId = f.productId ");
                sbSql.Append("   and a.specsId = f.specsId ");
                sbSql.Append("   and f.isDelete = 0 ");
            }
            else
            {
                sbSql.Append("  left join p_materials c ");
                sbSql.Append("    on a.materialsId = c.id ");
                sbSql.Append("  left join r_materials_specs d ");
                sbSql.Append("    on a.materialsId = d.materialsId ");
                sbSql.Append("   and a.specsId = d.id ");
                sbSql.Append("  left join r_materials_price f ");
                sbSql.Append("    on a.materialsId = f.materialsId ");
                sbSql.Append("   and a.specsId = f.specsId ");
                sbSql.Append("   and f.isDelete = 0 ");
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
            if (_qc >= 0)
            {
                if (_type == 0)
                {
                    sbSql.Append("  and ifnull(e.inspectResult, 0) = ").Append(_qc).Append(" ");
                }
                else
                {
                    sbSql.Append("  and ifnull(a.isQualified, 0) = ").Append(_qc).Append(" ");
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

        public DataTable GetStoreExport(int _type, int _qc, string _name, int _factoryId, DateTime _expiresDate, DateTime _inputDate_begin, DateTime _inputDate_end, decimal _stockNum)
        {
            sbSql.Clear();
            sbSql.Append("select ");
            if (_type == 0)
            {
                sbSql.Append("       '成品' 类型, ");
            }
            else
            {
                sbSql.Append("       '原料' 类型, ");
            }
            sbSql.Append("       a.inputCode 入库单号, ");
            sbSql.Append("       b.name 工厂名称, ");
            if (_type == 0)
            {
                sbSql.Append("       c.name 成品名称, ");
                sbSql.Append("       case ifnull(e.inspectResult, 0) when 0 then '不合格' else '合格' end 质检 , ");
            }
            else
            {
                sbSql.Append("       c.name 原料名称, ");
                sbSql.Append("       case ifnull(a.isQualified, 0) when 0 then '不合格' else '合格' end 质检 , ");
            }
            sbSql.Append("       d.name 规格, ");
            sbSql.Append("       a.stockNum 库存数, ");
            if (_type == 0)
            {
                sbSql.Append("       ifnull(f.minPrice, 0) 单价, ");
                sbSql.Append("       ifnull(f.minPrice, 0) * a.stockNum 金额, ");
            }
            else
            {
                sbSql.Append("       ifnull(f.price, 0) 单价, ");
                sbSql.Append("       ifnull(f.price, 0) * a.stockNum 金额, ");
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
                sbSql.Append("  left join r_product_specs d ");
                sbSql.Append("    on a.productId = d.productId ");
                sbSql.Append("   and a.specsId = d.id ");
                sbSql.Append("  left join r_product_input_quality e ");
                sbSql.Append("    on a.inputCode = e.inputCode ");
                sbSql.Append("   and e.isDelete = 0 ");
                sbSql.Append("  left join r_product_price f ");
                sbSql.Append("    on a.productId = f.productId ");
                sbSql.Append("   and a.specsId = f.specsId ");
                sbSql.Append("   and f.isDelete = 0 ");
            }
            else
            {
                sbSql.Append("  left join p_materials c ");
                sbSql.Append("    on a.materialsId = c.id ");
                sbSql.Append("  left join r_materials_specs d ");
                sbSql.Append("    on a.materialsId = d.materialsId ");
                sbSql.Append("   and a.specsId = d.id ");
                sbSql.Append("  left join r_materials_price f ");
                sbSql.Append("    on a.materialsId = f.materialsId ");
                sbSql.Append("   and a.specsId = f.specsId ");
                sbSql.Append("   and f.isDelete = 0 ");
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
            if (_qc >= 0)
            {
                if (_type == 0)
                {
                    sbSql.Append("  and ifnull(e.inspectResult, 0) = ").Append(_qc).Append(" ");
                }
                else
                {
                    sbSql.Append("  and ifnull(a.isQualified, 0) = ").Append(_qc).Append(" ");
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
            sbSql.Append("       specsId, ");
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
            sbSql.Append("       " + _modelInventoryProductLog.specsId + ", ");
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
            sbSql.Append("       specsId, ");
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
            sbSql.Append("       " + _modelInventoryMaterialsLog.specsId + ", ");
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

        public DataTable GetTrace(int _factoryId, int _customerId, DateTime _outputDate_begin, DateTime _outputDate_end, string _productName, string _productSpecs, string _productOutputCode, string _materialsName, string _materislsSpecs, string _materialsInputCode)
        {
            sbSql.Clear();
            sbSql.Append("select distinct ");
            sbSql.Append("       po.id, ");
            sbSql.Append("       f.name factoryName, ");
            sbSql.Append("       c.id customerId, ");
            sbSql.Append("       c.name customerName, ");
            sbSql.Append("       po.orderCode, ");
            sbSql.Append("       p.name productName, ");
            sbSql.Append("       ps.name specsName, ");
            sbSql.Append("       po.outputCode, ");
            sbSql.Append("       pod.realityOutputNum outputNum, ");
            sbSql.Append("       date_format(po.outputDate, '%Y-%m-%d') outputDate ");
            sbSql.Append("  from p_product_output po ");
            sbSql.Append("  join r_product_output_detail pod ");
            sbSql.Append("    on po.outputCode = pod.outputCode ");
            sbSql.Append("   and pod.isDelete = 0 ");
            sbSql.Append("  left join p_product p ");
            sbSql.Append("    on pod.productId = p.id ");
            sbSql.Append("  left join r_product_specs ps ");
            sbSql.Append("    on pod.productId = ps.productId ");
            sbSql.Append("   and pod.specsId = ps.id ");
            sbSql.Append("   and ps.isDelete = 0 ");
            sbSql.Append("  left join p_customer c ");
            sbSql.Append("    on po.customerId = c.id ");
            sbSql.Append("  left join m_factory f ");
            sbSql.Append("    on po.factoryId = f.id ");
            sbSql.Append("  left join h_product_output_log pol ");
            sbSql.Append("    on pol.outputCode = po.outputCode ");
            sbSql.Append("   and pol.isDelete = 0 ");
            sbSql.Append("  left join p_product_input pi ");
            sbSql.Append("    on pol.inputCode = pi.inputCode ");
            sbSql.Append("   and pi.isDelete = 0 ");
            sbSql.Append("  left join p_materials_output mo ");
            sbSql.Append("    on pi.produceCode = mo.produceCode ");
            sbSql.Append("   and mo.isDelete = 0 ");
            sbSql.Append("  left join h_materials_output_log mol ");
            sbSql.Append("    on mo.outputCode = mol.outputCode ");
            sbSql.Append("   and mol.isDelete = 0 ");
            sbSql.Append("  left join p_materials_input mi ");
            sbSql.Append("    on mol.inputCode = mi.inputCode ");
            sbSql.Append("   and mi.isDelete = 0 ");
            sbSql.Append("  left join p_materials m ");
            sbSql.Append("    on mi.materialsId = m.id ");
            sbSql.Append("  left join r_materials_specs ms ");
            sbSql.Append("    on mi.materialsId = ms.materialsId ");
            sbSql.Append("   and mi.specsId = ms.id ");
            sbSql.Append("   and ms.isDelete = 0 ");
            sbSql.Append(" where po.isDelete = 0 ");
            if (_factoryId > 0)
            {
                sbSql.Append("  and po.factoryId = ").Append(_factoryId).Append(" ");
            }
            if (_customerId > 0)
            {
                sbSql.Append("  and po.customerId = ").Append(_customerId).Append(" ");
            }
            sbSql.Append("  and po.outputDate >= '").Append(_outputDate_begin).Append("' ");
            sbSql.Append("  and po.outputDate <= '").Append(_outputDate_end).Append("' ");
            if (StringUtils.IsNotBlank(_productName))
            {
                sbSql.Append("   and pod.productId in (");
                sbSql.Append("                     select productId ");
                sbSql.Append("                       from r_product_search ");
                sbSql.Append("                      where productName like '%").Append(_productName).Append("%' or upper(searchKey) like '%").Append(_productName.ToUpper()).Append("%') ");
            }
            if (StringUtils.IsNotBlank(_productSpecs))
            {
                sbSql.Append("   and pod.specsId in (");
                sbSql.Append("                     select id ");
                sbSql.Append("                       from r_product_specs ");
                sbSql.Append("                      where name like '%").Append(_productSpecs).Append("%' or upper(name) like '%").Append(_productSpecs.ToUpper()).Append("%') ");
            }
            if (StringUtils.IsNotBlank(_productOutputCode))
            {
                sbSql.Append("  and (po.outputCode like '%").Append(_productOutputCode).Append("%' or upper(po.outputCode) like '%").Append(_productOutputCode.ToUpper()).Append("%') ");
            }
            if (StringUtils.IsNotBlank(_materialsName))
            {
                sbSql.Append("   and m.id in (");
                sbSql.Append("                     select materialsId ");
                sbSql.Append("                       from r_materials_search ");
                sbSql.Append("                      where materialsName like '%").Append(_materialsName).Append("%' or upper(searchKey) like '%").Append(_materialsName.ToUpper()).Append("%') ");
            }
            if (StringUtils.IsNotBlank(_materislsSpecs))
            {
                sbSql.Append("   and m.id in (");
                sbSql.Append("                     select id ");
                sbSql.Append("                       from r_materials_specs ");
                sbSql.Append("                      where name like '%").Append(_materislsSpecs).Append("%' or upper(name) like '%").Append(_materislsSpecs.ToUpper()).Append("%') ");
            }
            if (StringUtils.IsNotBlank(_materialsInputCode))
            {
                sbSql.Append("  and (mi.inputCode like '%").Append(_materialsInputCode).Append("%' or upper(mi.inputCode) like '%").Append(_materialsInputCode.ToUpper()).Append("%') ");
            }
            sbSql.Append(" order by po.id ");

            return Dal.DBHelper.Select(sbSql.ToString());
        }

        public DataTable GetTraceExport(int _factoryId, int _customerId, DateTime _outputDate_begin, DateTime _outputDate_end, string _productName, string _productSpecs, string _productOutputCode, string _materialsName, string _materislsSpecs, string _materialsInputCode)
        {
            sbSql.Clear();
            sbSql.Append("select distinct ");
            sbSql.Append("       f.name 工厂, ");
            sbSql.Append("       c.name 客户名称, ");
            sbSql.Append("       concat(c.provinceName, c.cityName, c.districtName, c.address) 客户地址, ");
            sbSql.Append("       c.manager 客户联系人, ");
            sbSql.Append("       c.telephone1 客户电话1, ");
            sbSql.Append("       c.telephone2 客户电话2, ");
            sbSql.Append("       po.orderCode 订单编号, ");
            sbSql.Append("       p.name 成品名称, ");
            sbSql.Append("       ps.name 成品规格, ");
            sbSql.Append("       po.outputCode 出库单号, ");
            sbSql.Append("       pod.realityOutputNum 出库数量, ");
            sbSql.Append("       date_format(po.outputDate, '%Y-%m-%d') 出库日期 ");
            sbSql.Append("  from p_product_output po ");
            sbSql.Append("  join r_product_output_detail pod ");
            sbSql.Append("    on po.outputCode = pod.outputCode ");
            sbSql.Append("   and pod.isDelete = 0 ");
            sbSql.Append("  left join p_product p ");
            sbSql.Append("    on pod.productId = p.id ");
            sbSql.Append("  left join r_product_specs ps ");
            sbSql.Append("    on pod.productId = ps.productId ");
            sbSql.Append("   and pod.specsId = ps.id ");
            sbSql.Append("   and ps.isDelete = 0 ");
            sbSql.Append("  left join p_customer c ");
            sbSql.Append("    on po.customerId = c.id ");
            sbSql.Append("  left join m_factory f ");
            sbSql.Append("    on po.factoryId = f.id ");
            sbSql.Append("  left join h_product_output_log pol ");
            sbSql.Append("    on pol.outputCode = po.outputCode ");
            sbSql.Append("   and pol.isDelete = 0 ");
            sbSql.Append("  left join p_product_input pi ");
            sbSql.Append("    on pol.inputCode = pi.inputCode ");
            sbSql.Append("   and pi.isDelete = 0 ");
            sbSql.Append("  left join p_materials_output mo ");
            sbSql.Append("    on pi.produceCode = mo.produceCode ");
            sbSql.Append("   and mo.isDelete = 0 ");
            sbSql.Append("  left join h_materials_output_log mol ");
            sbSql.Append("    on mo.outputCode = mol.outputCode ");
            sbSql.Append("   and mol.isDelete = 0 ");
            sbSql.Append("  left join p_materials_input mi ");
            sbSql.Append("    on mol.inputCode = mi.inputCode ");
            sbSql.Append("   and mi.isDelete = 0 ");
            sbSql.Append("  left join p_materials m ");
            sbSql.Append("    on mi.materialsId = m.id ");
            sbSql.Append("  left join r_materials_specs ms ");
            sbSql.Append("    on mi.materialsId = ms.materialsId ");
            sbSql.Append("   and mi.specsId = ms.id ");
            sbSql.Append("   and ms.isDelete = 0 ");
            sbSql.Append(" where po.isDelete = 0 ");
            if (_factoryId > 0)
            {
                sbSql.Append("  and po.factoryId = ").Append(_factoryId).Append(" ");
            }
            if (_customerId > 0)
            {
                sbSql.Append("  and po.customerId = ").Append(_customerId).Append(" ");
            }
            sbSql.Append("  and po.outputDate >= '").Append(_outputDate_begin).Append("' ");
            sbSql.Append("  and po.outputDate <= '").Append(_outputDate_end).Append("' ");
            if (StringUtils.IsNotBlank(_productName))
            {
                sbSql.Append("   and pod.productId in (");
                sbSql.Append("                     select productId ");
                sbSql.Append("                       from r_product_search ");
                sbSql.Append("                      where productName like '%").Append(_productName).Append("%' or upper(searchKey) like '%").Append(_productName.ToUpper()).Append("%') ");
            }
            if (StringUtils.IsNotBlank(_productSpecs))
            {
                sbSql.Append("   and pod.specsId in (");
                sbSql.Append("                     select id ");
                sbSql.Append("                       from r_product_specs ");
                sbSql.Append("                      where name like '%").Append(_productSpecs).Append("%' or upper(name) like '%").Append(_productSpecs.ToUpper()).Append("%') ");
            }
            if (StringUtils.IsNotBlank(_productOutputCode))
            {
                sbSql.Append("  and (po.outputCode like '%").Append(_productOutputCode).Append("%' or upper(po.outputCode) like '%").Append(_productOutputCode.ToUpper()).Append("%') ");
            }
            if (StringUtils.IsNotBlank(_materialsName))
            {
                sbSql.Append("   and m.id in (");
                sbSql.Append("                     select materialsId ");
                sbSql.Append("                       from r_materials_search ");
                sbSql.Append("                      where materialsName like '%").Append(_materialsName).Append("%' or upper(searchKey) like '%").Append(_materialsName.ToUpper()).Append("%') ");
            }
            if (StringUtils.IsNotBlank(_materislsSpecs))
            {
                sbSql.Append("   and m.id in (");
                sbSql.Append("                     select id ");
                sbSql.Append("                       from r_materials_specs ");
                sbSql.Append("                      where name like '%").Append(_materislsSpecs).Append("%' or upper(name) like '%").Append(_materislsSpecs.ToUpper()).Append("%') ");
            }
            if (StringUtils.IsNotBlank(_materialsInputCode))
            {
                sbSql.Append("  and (mi.inputCode like '%").Append(_materialsInputCode).Append("%' or upper(mi.inputCode) like '%").Append(_materialsInputCode.ToUpper()).Append("%') ");
            }
            sbSql.Append(" order by po.id ");

            return Dal.DBHelper.Select(sbSql.ToString());
        }
    }
}
