using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace final1
{
    internal class Result
    {
        public int ResultID { get; set; }
        int TestID { get; set; }
        string Results { get; set; }
        int InvoicesID { get; set; }
        public Result(int resultID, int testID, string Results, int invoicesID)
        {
            this.ResultID = resultID;
            this.TestID = testID;
            this.Results = Results;
            this.InvoicesID = invoicesID;
        }
    }

}