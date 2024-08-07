using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace final1
{
    internal class Screen
    {
        public int ScreenID { get; set; }
        string ScreenName { get; set; }
        int IndexScreen { get; set; }
        public Screen(int ScreenID, string ScreenName, int IndexScreen)
        {
            this.ScreenID = ScreenID;
            this.ScreenName = ScreenName;
            this.IndexScreen = IndexScreen;
        }

    }

}