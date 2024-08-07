using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace final1
{
    internal class Audit
    {
        int UserID { get; set; }
        DateTime TimeLogin { get; set; }
        DateTime TimeLogout { get; set; }
        DateTime Date {  get; set; }
        public Audit(int UserID , DateTime TimeLogin ,DateTime Timelogout , DateTime Date) {
            this.Date = Date;
            this.UserID = UserID;   
            this.TimeLogin = TimeLogin;
            this.TimeLogout = Timelogout;
        }
    }
}
