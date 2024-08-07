using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace final1.Classes

{
    public class clsUsers
    {
        public int UserID { get; set; }
        Patient PatientID { get; set; }
        public string UserName { get; set; }
        Group GroupID { get; set; }
        Employee EmployeeID { get; set; }
        string Password { get; set; }

        //static string myconnstrng = ConfigurationManager.ConnectStrings["myconnstrng"].ConnectionString;
        public clsUsers(int UserID, string UserName, string Password, Patient PatientID, Group GroupID, Employee EmployeeID)
        {
            this.UserID = UserID;
            this.UserName = UserName;
            this.GroupID = GroupID;
            this.PatientID = PatientID;
            this.EmployeeID = EmployeeID;
            this.Password = Password;
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
        public bool Ad()
        {
            bool isSuccess = false;
            string connectionString = "Server=localhost;Database=final;Trusted_Connection=True;";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "INSERT INTO tblUsers (UserName, Password, CreateDate) VALUES (@UserName, @Password, @CreateDate)";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@UserName", UserName);
                        cmd.Parameters.AddWithValue("@Password", Password); 
                        cmd.Parameters.AddWithValue("@PatientID", PatientID.PatientID); 
                        cmd.Parameters.AddWithValue("@Password", Password); 
                        cmd.Parameters.AddWithValue("@CreateDate", DateTime.Now);

                        int result = cmd.ExecuteNonQuery();
                        isSuccess = result > 0;
                    }
                }
                catch (Exception ex)
                {
                    // Handle exception (e.g., log error)
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }

            return isSuccess;
        }
    
public DataTable Executeprc(string Operation)
        {
            DataTable dt = new DataTable();
            using (SqlConnection connection = new SqlConnection("Server=localhost;Database=final;Trusted_Connection=True;"))
            {
                using (SqlCommand command = new SqlCommand("prcUsers", connection))
                {
                    
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@Operations", Operation);
                    command.Parameters.AddWithValue("@UserID ", UserID);
                    command.Parameters.AddWithValue("@UserName", UserName);
                    command.Parameters.AddWithValue("@GroupID", GroupID);
                    command.Parameters.AddWithValue("@PatientID", PatientID);
                    command.Parameters.AddWithValue("@EmployeeID", EmployeeID);
                    command.Parameters.AddWithValue("@Password", Password);
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
