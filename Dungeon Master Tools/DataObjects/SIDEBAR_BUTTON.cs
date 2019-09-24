using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dungeon_Master_Tools
{
    public class SIDEBAR_BUTTON
    {
        public int SIDEBAR_BUTTON_ID { get; set; }
        public string BUTTON_TEXT { get; set; }
        public int PARENT_BUTTON { get; set; }
        public bool displayed { get; set; }

        public SIDEBAR_BUTTON()
        {
            SIDEBAR_BUTTON_ID = 0;
            BUTTON_TEXT = "";
            PARENT_BUTTON = 0;
        }

        public override string ToString()
        {
            return BUTTON_TEXT;
        }
    }
}
