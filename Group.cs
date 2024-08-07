using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace final1
{
    public class Group
    {
        public int GroupID { get; set; }
        string GroupName { get; set; }
        public Group(int GroupID, string GroupName)
        {
            this.GroupID = GroupID;
            this.GroupName = GroupName;
        }
    }
}
