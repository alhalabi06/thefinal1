using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace final1
{
    internal class AccessRight
    {
        public int UserID { get; set; }
        public int ScreenID { get; set; }
        bool add {  get; set; }
        bool Modify { get; set; }
        bool Delete { get; set; }
        bool Search { get; set; }
        bool View { get; set; }
        bool Print { get; set; }

        public AccessRight(int UserID , int ScreenID , bool add ,bool Modify , bool Delete , bool Search ,bool View , bool Print ) { 
            this.UserID = UserID;
            this.ScreenID = ScreenID;
            this.add = add;
            this.Modify = Modify;
            this.View = View;
            this.Print = Print; 
            this.Delete = Delete;
            this.Search = Search;
           
        }
    }
}
