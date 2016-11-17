using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class ModelItem
    {
        public object itemKey { set; get; }
        public string itemValue { set; get; }

        public ModelItem()
        {
        }

        public ModelItem(object _itemKey, string _itemValue)
        {
            itemKey = _itemKey;
            itemValue = _itemValue;
        }
    }
}
