using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class ModelUser : ModelBase
    {
        public int userId { set; get; }
        public string userName { set; get; }
        public string pwd { set; get; }
        public int roleId { set; get; }
        public string roleName { set; get; }
        public string sex { set; get; }
        public string position { set; get; }
        public string mobile { set; get; }
        public string email { set; get; }
        public DateTime birthday { set; get; }

    }
}
