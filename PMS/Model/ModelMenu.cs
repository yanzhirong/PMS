using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class ModelMenu : ModelBase
    {
        public int menuId { set; get; }
        public int parentId { set; get; }
        public string menuName { set; get; }
        public string formName { set; get; }

    }
}
