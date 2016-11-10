using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    class ModelUser : ModelBase
    {
        public int userId { set; get; }

        public string userName { set; get; }

        public string pwd { set; get; }

        public int roelId { set; get; }

    }
}
