using ContactsProject.Repository;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ContactsProject.Services
{
    internal class ContactsRepository : IContactRepository
    {
        private string ConnectionString = "Data Source =.;Initial Catalog=ContactProject_DB ; Integrated Security = true";

        public bool Delete(int ContactID)
        {
            SqlConnection cont = new SqlConnection(ConnectionString);
            try
            {
                string Query = "delete ContactTable where ContactID=@ContactID";
                SqlCommand cmd = new SqlCommand(Query, cont);
                cmd.Parameters.AddWithValue("@ContactID", ContactID);
                cont.Open();
                cmd.ExecuteNonQuery();
                return true;
            }
            catch
            {
                return false;
            }
            finally
            {
                cont.Close();
            }

        }

        public bool Insert(string Name, string Family, string Email, string Job, string Age)
        {
            SqlConnection connection = new SqlConnection(ConnectionString);
            try
            {
                string Query = "Insert Into ContactTable (Name , Family , Age , Job , Email) values (@Name,@Family,@Age , @Job , @Email)";
                SqlCommand cmd = new SqlCommand(Query, connection);
                cmd.Parameters.AddWithValue("@Name", Name);
                cmd.Parameters.AddWithValue("@Family", Family);
                cmd.Parameters.AddWithValue("@Age", Age);
                cmd.Parameters.AddWithValue("@Job", Job);
                cmd.Parameters.AddWithValue("@Email", Email);
                connection.Open();
                cmd.ExecuteNonQuery();


                return true;
            }
            catch
            {
                return false;
            }
            finally
            {
                connection.Close();
            }
        }

        public DataTable Search(string Oops)
        {
            string Query = "select * from ContactTable where Name like @Parameter or Family like @Parameter";
            SqlConnection connection = new SqlConnection(ConnectionString);
            SqlDataAdapter Adapter = new SqlDataAdapter(Query, connection);
            Adapter.SelectCommand.Parameters.AddWithValue("@Parameter","%" +  Oops + "%");
            DataTable dataTable = new DataTable();
            Adapter.Fill(dataTable);
            return dataTable;
        }

        public DataTable SelectAll()
        {
            string Query = "select * from ContactTable";
            SqlConnection connection = new SqlConnection(ConnectionString);
            SqlDataAdapter Adapter = new SqlDataAdapter(Query, connection);
            DataTable dataTable = new DataTable();
            Adapter.Fill(dataTable);
            return dataTable;
        }

        public DataTable SelectRow(int ContactID)
        {
            string Query = $"select * from ContactTable where ContactID ={ContactID}";

            SqlConnection connection = new SqlConnection(ConnectionString);

            SqlDataAdapter Adapter = new SqlDataAdapter(Query, connection);
            DataTable dataTable = new DataTable();
            Adapter.Fill(dataTable);
            return dataTable;
        }

        public bool Update(int ContactID, string Name, string Family, string Email, string Job, string age)
        {
            SqlConnection connection = new SqlConnection(ConnectionString);

            try
            {
                string Query = "Update ContactTable set Name=@Name , Family=@Family , Age = @Age , Email = @Email , Job = @Job where ContactID=@ContactID";

                SqlCommand cmd = new SqlCommand(Query, connection);
                cmd.Parameters.AddWithValue("@Name", Name);
                cmd.Parameters.AddWithValue("@Family", Family);
                cmd.Parameters.AddWithValue("@Age", age);
                cmd.Parameters.AddWithValue("@Email", Email);
                cmd.Parameters.AddWithValue("@Job", Job);
                cmd.Parameters.AddWithValue("@ContactID", ContactID);
                connection.Open();
                cmd.ExecuteNonQuery();
                return true;
            }
            catch
            {
                return false;
            }
            finally
            {
                connection.Close();
            }
        }
    }
}

