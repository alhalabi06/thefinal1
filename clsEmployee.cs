using System;
using System.Data;
using System.Data.SqlClient;
using final1.Classes;

namespace final1
{
    public class Employee
    {
        public int EmployeeID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public Genders Gender { get; set; }
        public City CityID { get; set; }
        public EmergencyContact RelativesID { get; set; }
        public BloodType BloodID { get; set; }
        public DateTime DateOfBirth { get; set; }

        public Employee(int EmployeeID, string FirstName, string LastName, string PhoneNumber, Genders Gender, DateTime DateOfBirth, City CityID, EmergencyContact RelativesID, BloodType BloodID)
        {
            this.EmployeeID = EmployeeID;
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.PhoneNumber = PhoneNumber;
            this.Gender = Gender;
            this.DateOfBirth = DateOfBirth;
            this.CityID = CityID;
            this.RelativesID = RelativesID;
            this.BloodID = BloodID;
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
            string query = @"SELECT e.EmployeeID, e.FirstName, e.LastName, e.PhoneNumber, g.Gender, e.DateOfBirth,
                          v.CityName, v.StateName, v.CountryName, bt.BloodType
                          FROM tblEmployee e
                          JOIN tblGender g ON e.GenderID = g.GenderID
                          JOIN vCity v ON e.CityID = v.CityID
                          JOIN tblBloodType bt ON e.BloodID = bt.BloodID";

            using (SqlConnection connection = new SqlConnection("Server=localhost;Database=final;Trusted_Connection=True;"))
            {
                using (SqlDataAdapter sda = new SqlDataAdapter(query, connection))
                {
                    sda.Fill(dt);
                }
            }
            return dt;
        }

        private DataTable Executeprc(string Operation)
        {
            DataTable dt = new DataTable();
            using (SqlConnection connection = new SqlConnection("Server=localhost;Database=final;Trusted_Connection=True;"))
            {
                using (SqlCommand command = new SqlCommand("prcEmployee", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@Operations", Operation);
                    command.Parameters.AddWithValue("@EmployeeID", EmployeeID);
                    command.Parameters.AddWithValue("@FirstName", FirstName);
                    command.Parameters.AddWithValue("@LastName", LastName);
                    command.Parameters.AddWithValue("@PhoneNumber", PhoneNumber);
                    command.Parameters.AddWithValue("@GenderID", Gender.GenderID);
                    command.Parameters.AddWithValue("@DateOfBirth", DateOfBirth);
                    command.Parameters.AddWithValue("@CityID", CityID.CityID);
                    command.Parameters.AddWithValue("@ReletivesID", RelativesID.RelativesID);
                    command.Parameters.AddWithValue("@BloodID", BloodID.BloodID);
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