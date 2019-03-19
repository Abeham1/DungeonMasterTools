using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dungeon_Master_Tools
{
    class TYPE_V
    {
        public int TYPE_ID { get; set; }
        public string CATEGORY { get; set; }
        public string DESCR { get; set; }

        public TYPE_V()
        {
            TYPE_ID = 0;
            CATEGORY = "";
            DESCR = "";
        }
    }
}
