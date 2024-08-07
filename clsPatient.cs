using System;
using System.Data;
using System.Data.SqlClient;
using final1.Classes;

namespace final1
{
    public class Patient
    {
        public int PatientID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public Genders Gender { get; set; }
        public City City { get; set; }
        public EmergencyContact Relatives { get; set; }
        public BloodType Blood { get; set; }
        public DateTime DateOfBirth { get; set; }

        public Patient(int patientID, string firstName, string lastName, string phoneNumber, Genders gender, DateTime dateOfBirth, City city, EmergencyContact relatives, BloodType blood)
        {
            PatientID = patientID;
            FirstName = firstName;
            LastName = lastName;
            PhoneNumber = phoneNumber;
            Gender = gender;
            DateOfBirth = dateOfBirth;
            City = city;
            Relatives = relatives;
            Blood = blood;
        }

        public DataTable Add()
        {
            return Executeprc("INSERT");
        }

        public DataTable Delete()
        {
            return Executeprc("DELETE");
        }

        public DataTable Update()
        {
            return Executeprc("UPDATE");
        }

        public DataTable Select()
        {
            DataTable dt = new DataTable();
                string query = @"SELECT p.PatientID, p.FirstName, p.LastName, p.PhoneNumber, g.Gender, p.DateOfBirth,
                                c.CityName, c.StateName, c.CountryName, bt.BloodType
                                FROM tblPatient p
                                JOIN tblGender g ON p.GenderID = g.GenderID
                                JOIN vCity c ON p.CityID = c.CityID
                                JOIN tblBloodType bt ON p.BloodID = bt.BloodID";

                using (SqlConnection connection = new SqlConnection("Server=localhost;Database=final;Trusted_Connection=True;"))
                {
                    using (SqlDataAdapter sda = new SqlDataAdapter(query, connection))
                    {
                        sda.Fill(dt);
                    }
                }
                return dt;
            /*return Executeprc("Select");*/
        }

        private DataTable Executeprc(string operation)
        {
            DataTable dt = new DataTable();
            using (SqlConnection connection = new SqlConnection("Server=localhost;Database=final;Trusted_Connection=True;"))
            {
                using (SqlCommand command = new SqlCommand("prcPatient", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@Operations", operation);
                    command.Parameters.AddWithValue("@PatientID", PatientID);
                    command.Parameters.AddWithValue("@FirstName", FirstName);
                    command.Parameters.AddWithValue("@LastName", LastName);
                    command.Parameters.AddWithValue("@PhoneNumber", PhoneNumber);
                    command.Parameters.AddWithValue("@GenderID", Gender.GenderID);
                    command.Parameters.AddWithValue("@DateOfBirth", DateOfBirth);
                    command.Parameters.AddWithValue("@CityID", City.CityID);
                    command.Parameters.AddWithValue("@ReletivesID", Relatives.RelativesID);
                    command.Parameters.AddWithValue("@BloodID", Blood.BloodID);
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