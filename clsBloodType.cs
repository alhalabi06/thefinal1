using System;
using final1.Classes;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace final1.Classes { 
    public class BloodType
    {
        public int BloodID { get; set; }
        string BloodTypes {  get; set; }
        public BloodType(int BloodID , string BloodTypes) {
            this.BloodID = BloodID;
            this.BloodTypes = BloodTypes;
        }
        public DataTable Add () {
            DataTable dt = new DataTable();
            dt = Executeprc("insert");
            return dt;
        }
        public DataTable Delete() {
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
        public DataTable Select ()
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
                using (SqlCommand command = new SqlCommand("prcBloodType", connection))
                {
                    
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@Operations", Operation);
                    command.Parameters.AddWithValue("@BloodID ", BloodID);
                    command.Parameters.AddWithValue("@BloodType", BloodTypes);
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
