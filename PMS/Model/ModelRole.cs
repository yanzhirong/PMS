using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class ModelRole : ModelBase
    {
        public int roleId { set; get; }
        public string roleName { set; get; }
        public int isFinance { set; get; }

    }
}
