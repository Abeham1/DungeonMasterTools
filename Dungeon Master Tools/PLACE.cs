using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dungeon_Master_Tools
{
    class PLACE
    {
        public int PLACE_ID { get; set; }
        public string NAME { get; set; }
        public int PARENT_LOCATION { get; set; }
        public string DESCR { get; set; }
        public string PARENT_LOCATION_NAME { get; set; }

        public PLACE()
        {
            PLACE_ID = 0;
            NAME = "";
            PARENT_LOCATION = 0;
            DESCR = "";
            PARENT_LOCATION_NAME = "";
        }

        public override string ToString()
        {
            return NAME;
        }
    }
}
