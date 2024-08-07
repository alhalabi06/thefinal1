using System;
using final1.Classes;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;

namespace final1
{
    public class clsReceipt
    {
        public int ReceiptID { get; set; }
        Patient PatientID { get; set; }
        string Receipt {  get; set; }
        Currency CurrencyID { get; set; }
        DateTime date { get; set; }
        int Amount { get; set; }
        int DocumentID { get; set; }
        DataTable tTransaction { get; set; }
        public clsReceipt(int receiptID ,Patient PatientID , string Receipt  , Currency CurrencyID , DateTime date , int Amount, DataTable tTransaction,int DocumentID)
        {
            this.ReceiptID = receiptID;
            this.PatientID = PatientID;
            this.Receipt = Receipt;
            this.CurrencyID = CurrencyID;
            this.date = date;
            this.Amount = Amount;
            this.tTransaction = tTransaction;
            this.DocumentID = DocumentID;
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
                using (SqlCommand command = new SqlCommand("prcReceipt", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@Operations", Operation);
                    command.Parameters.AddWithValue("@ReceiptID ", ReceiptID);
                    command.Parameters.AddWithValue("@PatientID ", PatientID.PatientID);
                    command.Parameters.AddWithValue("@Receipt", Receipt );
                    command.Parameters.AddWithValue("@date", date);
                    command.Parameters.AddWithValue("@Amount", Amount);
                    command.Parameters.AddWithValue("@DocumentID", DocumentID);
                    command.Parameters.AddWithValue("@CurrencyID", CurrencyID.CurrencyID);
                    //command.Parameters.AddWithValue("@tTransaction", tTransaction);
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