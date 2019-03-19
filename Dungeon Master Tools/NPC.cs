using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dungeon_Master_Tools
{
    class NPC
    {
        public int NPC_ID { get; set; }
        public string NAME { get; set; }
        public int HOME_CITY_ID { get; set; }
        public int OCCUPATION_ID { get; set; }
        public string DESCR { get; set; }
        public string OCCUPATION { get; set; }
        public string HOME_CITY { get; set; }

        public NPC()
        {
            NPC_ID = 0;
            NAME = "";
            HOME_CITY_ID = 0;
            OCCUPATION_ID = 0;
            DESCR = "";
            OCCUPATION = "";
            HOME_CITY = "";
        }

        public override string ToString()
        {
            return NAME;
        }
    }
}
