using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRG262_Project
{
    internal class Datahandler
    {
        

        static string connect = "Data Source=LAPTOP-FFO9LCVE\\SQLEXPRESS;Initial Catalog=\"School Data\";Integrated Security=True";
        SqlDataAdapter dataAdapt;
        SqlCommand command;
        SqlConnection connecter;

        public DataTable Read()
        {
            DataTable dt = new DataTable();
            string query = @"Select * FROM Students";
            SqlDataAdapter da = new SqlDataAdapter(query, connect);
            da.Fill(dt);
            return dt;

        }

        public void Add(int stID, string stName, string stSurname, DateTime DOB, string gender, string phoneNumber, string address,int coursecode)
        {
            string query = $"INSERT INTO StudentInfo VALUES ('{stID}','{stName}','{stSurname}','{DOB}','{gender}','{phoneNumber}','{address}','{coursecode}')";
            
            connecter = new SqlConnection(connect);
            connecter.Open();
            command = new SqlCommand(query, connecter);
            try
            {
                command.ExecuteNonQuery();
                MessageBox.Show("Student registered");

            }
            catch (Exception ex)
            {

                MessageBox.Show("Student is not Registered" + ex.Message);
            }
            finally
            {
                connecter.Close();
            }
        }
        public void Update(int stID, string stName, string stSurname, DateTime DOB, string gender, string phoneNumber, string address, int coursecode)
        {
            string query = $"UPDATE Students SET StudentName ='{stName}',StudentSurname = '{stSurname}'," +
                $"DOB = '{DOB}',Gender = '{gender}',PhoneNumber = '{phoneNumber}', Address = '{address}'," +
                $"CourseCode = '{coursecode}' WHERE StudentNumber = '{stID}'";
            connecter=new SqlConnection(connect);
            connecter.Open();
            command = new SqlCommand(query, connecter);
            try
            {
                command.ExecuteNonQuery();
                MessageBox.Show("Student details update ");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Student details not updated "+ ex.Message);
            }
            finally 
            { 
                connecter.Close();
            }
        }
        public void Delete(int stID)

        {
            string query = $"DELETE FROM Student WHERE StudentNumber ='{stID}'";
            connecter = new SqlConnection(connect);
            connecter.Open();
            command = new SqlCommand(query, connecter);
            try
            {
                command.ExecuteNonQuery();
                MessageBox.Show("Details Deleted ");
            }
            catch (Exception ex)
            {

                MessageBox.Show("Details not deleted" + ex.Message);
            }
            finally
            {
                connecter.Close();
            }
        }
        public DataTable Search(int stID) 
        {
            string query = $"SELECT * FROM StudentInfo WHERE StudentNumber = '{stID}' ";
            connecter = new SqlConnection(connect);
            dataAdapt = new SqlDataAdapter(query, connecter);
            
            DataTable dt = new DataTable();
            dataAdapt.Fill(dt);
            return dt;
        }
        public DataTable DisplayStudent()
        {
            string query = @"SELECT * FROM StudentInfo ";
            SqlDataAdapter da = new SqlDataAdapter(query, connecter);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public List<Login> ReadToList(List<string> infoHandler)
        {
            List<Login> user = new List<Login>();
            foreach (string item in infoHandler)
            {
                string[] Format = item.Split(',');
                user.Add(new Login(Format[0], Format[1]));
            }
            return user;
        }
        public List<string> WriteToFile(List<Login> users)
        {
            List<string> RawData = new List<string>();
            foreach (Login person in users)
            {
                string line = string.Format("{0},{1}", person.Username, person.Password);
                RawData.Add(line);


            }

            return RawData;
        }

    }
}

