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
    public class BllProductIn : Bll.BllBase
    {
        private BllSaleOrder m_bllSaleOrder = new BllSaleOrder();
        private BllProduce m_bllProduce = new BllProduce();
        private DalProductIn m_dalProductIn = new DalProductIn();
        private DalStore m_dalStore = new DalStore();

        public DataTable GetProductIn(String _productName, int _factoryId, DateTime _beginTime, DateTime _endTime, int _inputStatus, int _isQC)
        {
            DataTable dt = m_dalProductIn.GetProductIn(_productName, _factoryId, _beginTime, _endTime, _inputStatus, _isQC);

            return dt;
        }

        public ModelProductIn GetProductInById(int _productInId)
        {
            DataTable dt = m_dalProductIn.GetProductInById(_productInId);
            
            if(dt != null && dt.Rows.Count > 0)
            {
                return ModelUtils<ModelProductIn>.FillModel(dt.Rows[0]);
            }

            return new ModelProductIn();

        }

        public ModelProductIn GetProductInByInputCode(string _inputCode)
        {
            DataTable dt = m_dalProductIn.GetProductInByInputCode(_inputCode);

            if (dt != null && dt.Rows.Count > 0)
            {
                return ModelUtils<ModelProductIn>.FillModel(dt.Rows[0]);
            }

            return new ModelProductIn();

        }

        public string AddProductIn(ModelProductIn _model)
        {
            int rtn = 0;
            _model.inputCode = BllSeq.GetCode("cprk", "productInCode");
            _model.inputStatus = 1;

            rtn = m_dalProductIn.AddProductIn(_model);

            if (rtn > 0)
            {
                //更新销售订单状态
                List<ModelSaleOrder> listSaleOrder = new List<ModelSaleOrder>();

                DataTable dt = m_bllProduce.GetProduceApplyByProduceCode(_model.produceCode);
                if (dt != null && dt.Rows.Count > 0)
                {
                    foreach (DataRow dr in dt.Rows)
                    {
                        string saleOrderCode = ConvertUtils.ConvertToString(dr["saleOrderCode"]);

                        if (StringUtils.IsNotBlank(saleOrderCode))
                        {
                            bool isNeedUpdate = true;
                            DataTable dt2 = m_bllProduce.GetProduceApplyBySaleOrderCode(saleOrderCode);

                            if (dt2 != null && dt2.Rows.Count > 0)
                            {
                                foreach (DataRow dr2 in dt2.Rows)
                                {
                                    int status = ConvertUtils.ConvertToInt(dr2["status"]);
                                    if (status == 0)
                                    {
                                        isNeedUpdate = false;
                                        break;
                                    }

                                    string produceCode = ConvertUtils.ConvertToString(dr2["produceCode"]);
                                    if (StringUtils.IsBlank(produceCode))
                                    {
                                        isNeedUpdate = false;
                                        break;
                                    }

                                    ModelProduce modelProduce = m_bllProduce.GetProduceyByProduceCode(produceCode);
                                    if (modelProduce.status != (int)Enum.EnumProduceOrderStatus.Complete)
                                    {
                                        isNeedUpdate = false;
                                        break;
                                    }
                                }
                            }

                            if (isNeedUpdate)
                            {
                                ModelSaleOrder modelSaleOrder = new ModelSaleOrder();
                                modelSaleOrder.orderCode = saleOrderCode;
                                modelSaleOrder.orderStatus = (int)Enum.EnumSaleOrderStatus.Transporting;
                                modelSaleOrder.modifyBy = _model.createBy;
                                modelSaleOrder.modifyTime = _model.createTime;
                                listSaleOrder.Add(modelSaleOrder);
                            }
                        }
                    }
                }

                if (listSaleOrder.Count > 0)
                {
                    m_bllSaleOrder.UpdateSaleOrderStatus(listSaleOrder);
                }
            }

            return _model.inputCode;
        }

        public Boolean UpdateProductIn(ModelProductIn _model)
        {
            int rtn = 0;
            if (StringUtils.IsBlank(_model.inputCode))
            {
                _model.inputCode = BllSeq.GetCode("cprk", "productInCode");
            }
            _model.inputStatus = 1;
            rtn = m_dalProductIn.UpdateProductIn(_model);

            if (rtn > 0)
            {
                //更新销售订单状态
                List<ModelSaleOrder> listSaleOrder = new List<ModelSaleOrder>();

                DataTable dt = m_bllProduce.GetProduceApplyByProduceCode(_model.produceCode);
                if (dt != null && dt.Rows.Count > 0)
                {
                    foreach (DataRow dr in dt.Rows)
                    {
                        string saleOrderCode = ConvertUtils.ConvertToString(dr["saleOrderCode"]);

                        if (StringUtils.IsNotBlank(saleOrderCode))
                        {
                            bool isNeedUpdate = true;
                            DataTable dt2 = m_bllProduce.GetProduceApplyBySaleOrderCode(saleOrderCode);

                            if (dt2 != null && dt2.Rows.Count > 0)
                            {
                                foreach (DataRow dr2 in dt2.Rows)
                                {
                                    int status = ConvertUtils.ConvertToInt(dr2["status"]);
                                    if (status == 0)
                                    {
                                        isNeedUpdate = false;
                                        break;
                                    }

                                    string produceCode = ConvertUtils.ConvertToString(dr2["produceCode"]);
                                    if (StringUtils.IsBlank(produceCode))
                                    {
                                        isNeedUpdate = false;
                                        break;
                                    }

                                    ModelProduce modelProduce = m_bllProduce.GetProduceyByProduceCode(produceCode);
                                    if (modelProduce.status != (int)Enum.EnumProduceOrderStatus.Complete)
                                    {
                                        isNeedUpdate = false;
                                        break;
                                    }
                                }
                            }

                            if (isNeedUpdate)
                            {
                                ModelSaleOrder modelSaleOrder = new ModelSaleOrder();
                                modelSaleOrder.orderCode = saleOrderCode;
                                modelSaleOrder.orderStatus = (int)Enum.EnumSaleOrderStatus.Transporting;
                                modelSaleOrder.modifyBy = _model.createBy;
                                modelSaleOrder.modifyTime = _model.createTime;
                                listSaleOrder.Add(modelSaleOrder);
                            }
                        }
                    }
                }

                if (listSaleOrder.Count > 0)
                {
                    return m_bllSaleOrder.UpdateSaleOrderStatus(listSaleOrder);
                }
            }

            return rtn == 0 ? false : true;
        }

        public Boolean DeleteProductIn(ModelProductIn _model)
        {
            int rtn = 0;
            rtn = m_dalProductIn.DeleteProductIn(_model);

            return rtn == 0 ? false : true;
        }

        public Boolean CheckUpdateDelete(string _inputCode)
        {
            DataTable dt = m_dalStore.GetProductOutputLogByInputCode(_inputCode);

            if (dt != null && dt.Rows.Count > 0)
            {
                return false;
            }

            return true;
        }

        public DataTable GetProductInQC(string _inputCode)
        {
            DataTable dt = m_dalProductIn.GetProductInQC(_inputCode);

            return dt;
        }

        public DataTable GetProductInQCDetail(string _inputCode)
        {
            DataTable dt = m_dalProductIn.GetProductInQCDetail(_inputCode);

            return dt;
        }

        public Boolean AddUpdateProductInQC(ModelProductInQC _model)
        {
            int rtn = 0;
            rtn = m_dalProductIn.AddUpdateProductInQC(_model);

            return rtn == 0 ? false : true;
        }
    }
}
