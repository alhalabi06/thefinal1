using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace final1
{
    internal class Tests
    {
        public int TestID { get; set; }
        string TestName { get; set; }
        int UnitID { get; set; }
        int UserID { get; set; }
        int TestTypeID { get; set; }
        public Tests(int testID, string testName, int unitID, int userID, int TestTypeID)
        {
            this.TestID = testID;
            this.TestName = testName;
            this.UnitID = unitID;
            this.UserID = userID;
            this.TestTypeID = TestTypeID;
        }
    }

}