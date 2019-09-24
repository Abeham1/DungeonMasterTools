using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dungeon_Master_Tools
{
    class MenuStripRenderer : ToolStripProfessionalRenderer
    {
        public MenuStripRenderer() : base(new MyColors()) { }
    }

    class MyColors : ProfessionalColorTable
    {
        public override Color MenuItemSelected
        {
            get { return Color.Red; }
        }
        public override Color MenuItemSelectedGradientBegin
        {
            get { return Color.Red; }
        }
        public override Color MenuItemSelectedGradientEnd
        {
            get { return Color.Black; }
        }
        public override Color MenuItemBorder
        {
            get { return Color.Transparent; }
        }
        public override Color MenuItemPressedGradientBegin
        {
            get { return Color.Black; }
        }
        public override Color MenuItemPressedGradientEnd
        {
            get { return Color.Red; }
        }
    }
}
