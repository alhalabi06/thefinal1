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
    public class EmergencyContact
    {
        public int RelativesID { get; set; }
        string ReletivesName { get; set; }
        int PatientID { get; set; }
        string Adresse {  get; set; }
        public EmergencyContact(int RelativesID, string ReletivesName , int PatientID , string Adresse)
        {
            this.RelativesID = RelativesID ;
            this.ReletivesName = ReletivesName;
            this.PatientID = PatientID ;
            this.Adresse = Adresse ;
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
                using (SqlCommand command = new SqlCommand("prcEmergencyContact", connection))
                {
                    
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@Operations", Operation);
                    command.Parameters.AddWithValue("@ReletivesID   ",RelativesID  );
                    command.Parameters.AddWithValue("@ReletivesName", ReletivesName);
                    command.Parameters.AddWithValue("@PatientID ", PatientID);
                    command.Parameters.AddWithValue("@Adresse ", Adresse);
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
