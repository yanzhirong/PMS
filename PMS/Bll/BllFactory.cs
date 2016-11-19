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
    public class BllFactory : Bll.BllBase
    {
        private DalFactory m_dalFactory = new DalFactory();

        public DataTable GetFactory(string _name)
        {
            DataTable factory = m_dalFactory.GetFactory(_name);

            return factory;
        }

        public ModelFactory GetFactoryById(int _factoryId)
        {
            DataTable factory = m_dalFactory.GetFactoryById(_factoryId);

            if (factory != null && factory.Rows.Count > 0)
            {
                return ModelUtils<ModelFactory>.FillModel(factory.Rows[0]);
            }
            return new ModelFactory();
        }

        public ModelFactory GetFactoryByName(string _factoryName)
        {
            DataTable factory = m_dalFactory.GetFactoryByName(_factoryName);

            if (factory != null && factory.Rows.Count > 0)
            {
                return ModelUtils<ModelFactory>.FillModel(factory.Rows[0]);
            }
            return new ModelFactory();
        }
        public Boolean AddFactory(ModelFactory _modelFactory)
        {
            int rtn = 0;
            rtn = m_dalFactory.AddFactory(_modelFactory);

            return rtn == 0 ? false : true;
        }

        public Boolean UpdateFactory(ModelFactory _modelFactory)
        {
            int rtn = 0;
            rtn = m_dalFactory.UpdateFactory(_modelFactory);

            return rtn == 0 ? false : true;
        }

        public Boolean DeleteFactory(ModelFactory _modelFactory)
        {
            int rtn = 0;
            rtn = m_dalFactory.DeleteFactory(_modelFactory);

            return rtn == 0 ? false : true;
        }
    }
}
