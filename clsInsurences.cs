using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace final1.Classes
{
    internal class clsInsurences
    {
        int InsurenceID { get; set; }
        string InsurenceName { get; set; }
        public clsInsurences(int InsurenceID, string InsurenceName)
        {
            this.InsurenceID = InsurenceID;
            this.InsurenceName = InsurenceName;
        }
        public DataTable Add()
        {
            DataTable dt = new DataTable();
            dt = Executeprc("insert");
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
                using (SqlCommand command = new SqlCommand("prcInsurence", connection))
                {
                    
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@Operations", Operation);
                    command.Parameters.AddWithValue("@InsurenceID ", InsurenceID);
                    command.Parameters.AddWithValue("@InsurenceName", InsurenceName);
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
