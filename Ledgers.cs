using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace final1
{
    internal class Ledgers
    {
        public int LedgersID {  get; set; }
        int Parent {  get; set; }
        string Ledger {  get; set; }
        public Ledgers (int ledgersID , int Parent , string Ledger)
        {
            this.LedgersID = ledgersID;
            this.Parent = Parent;
            this.Ledger = Ledger;
        }
    }
}
