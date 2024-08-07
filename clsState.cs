using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace final1
{
    internal class clsState
    {
        public int StateID { get; set; }
        int CountryID { get; set; }
        string StateName { get; set; }
        public clsState(int StateID, int countryID, string stateName)
        {
            this.StateID = StateID;
            this.CountryID = countryID;
            this.StateName = stateName;
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

            dt = Executeprc("delete");
            return dt;
        }
        public DataTable Update()
        {
            DataTable dt = new DataTable();
            dt = Executeprc("update");
            return dt;
        }
        public DataTable Select()
        {
            DataTable dt = new DataTable();
            dt = Executeprc("SELECT");
            return dt;
        }
        public DataTable SelectID()
        {
            DataTable dt = new DataTable();
                dt = Executeprc("SELECTID");
            return dt;
        }
        public DataTable Executeprc(string Operation)
        {
            DataTable dt = new DataTable();
            using (SqlConnection connection = new SqlConnection("Server=localhost;Database=final;Trusted_Connection=True;"))
            {
                using (SqlCommand command = new SqlCommand("prcState", connection))
                {

                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@Operations", Operation);
                    command.Parameters.AddWithValue("@StateID ", StateID);
                    command.Parameters.AddWithValue("@StateName", StateName);
                    command.Parameters.AddWithValue("@CountryID", CountryID);
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