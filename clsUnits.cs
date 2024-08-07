using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace final1.Classes
{
    internal class clsUnits
    {
        int UnitID { get; set; }
        string Unit { get; set; }
        public clsUnits(int UnitID, string Unit)
        {
            this.UnitID = UnitID;
            this.Unit = Unit;
        }
        public DataTable Add()
        {
            DataTable dt = new DataTable();
            dt = Executeprc("INSERT");
            return dt;
        }
        public DataTable Delete()
        {
            DataTable dt = new DataTable();
            dt = Executeprc("DELETE");
            return dt;
        }
        public DataTable Update()
        {
            DataTable dt = new DataTable();
            dt = Executeprc("UPDATE");
            return dt;
        }
        public DataTable Select()
        {
            DataTable dt = new DataTable();
            dt = Executeprc("SELECT");
            return dt;
        }
        public DataTable Executeprc(string Operation)
        {
            DataTable dt = new DataTable();
            using (SqlConnection connection = new SqlConnection("Server=localhost;Database=final;Trusted_Connection=True;"))
            {
                using (SqlCommand command = new SqlCommand("prcUnits", connection))
                {
                    
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@Operations", Operation);
                    command.Parameters.AddWithValue("@UnitID ", UnitID);
                    command.Parameters.AddWithValue("@Unit", Unit);
                    command.Parameters.AddWithValue("@User", "");
                    using (SqlDataAdapter sda = new SqlDataAdapter(command))
                    {
                        sda.Fill(dt);
                    }
                }

            }
            return dt;
        }

    }
}
