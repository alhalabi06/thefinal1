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
    internal class clsPrice
    {
        int PriceID { get; set; }
        int Price { get; set; }
        int CurrencyID { get; set; }
        int InsurenceID { get; set; }
        int TestID { get; set; }
        public clsPrice(int PriceID, int CurrencyID, int InsurenceID , int TestID, int Price)
        {
            this.PriceID = PriceID;
            this.Price = Price;
            this.CurrencyID = CurrencyID;
            this.InsurenceID = InsurenceID;
            this.TestID = TestID;
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
                using (SqlCommand command = new SqlCommand("prcPrices", connection))
                {
                    
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@Operations", Operation);
                    command.Parameters.AddWithValue("@PriceID ", PriceID);
                    command.Parameters.AddWithValue("@CurrencyID", CurrencyID);
                    command.Parameters.AddWithValue("@InsurenceID", InsurenceID);
                    command.Parameters.AddWithValue("@TestID", TestID);
                    command.Parameters.AddWithValue("@Price", Price);
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
