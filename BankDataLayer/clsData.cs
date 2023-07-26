using System;
using System.Data;
using System.Data.SqlClient;
using System.Xml.Linq;


namespace BankDataLayer
{
    static class clsDataAccessSettings
    {
        public static string connectionString = "Server=.;Database=BankDB;User ID=sa;Password=oali123e;";
    }



    public class clsUserData
    {
        public static bool Find(ref int id, ref string UserName, ref string FirstName, ref string LastName, ref string Phone,
            ref string Email, ref string Password, ref int Permissions)
        {
            bool isFound = false;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = "select * from Users where UserName = @UserName";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("UserName", UserName);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if(reader.Read())
                {
                    id = (int)reader["ID"];
                    UserName = (string)reader["UserName"];
                    FirstName = (string)reader["FirstName"];
                    LastName = (string)reader["LastName"];
                    Phone = (string)reader["Phone"];

                    if (reader["Email"] != DBNull.Value)
                        Email = (string)reader["Email"];               

                    Password = (string)reader["Password"];
                    Permissions = (int)reader["Permissions"];

                    isFound = true;
                }
                reader.Close();
            }
            catch (Exception e)
            {
            }
            finally
            {
                connection.Close();
            }
            return isFound;
        }
        public static bool FindByUserNameAndPassword(ref int id, ref string UserName, ref string FirstName, ref string LastName,
            ref string Phone, ref string Email, ref string Password, ref int Permissions)
        {
            bool isFound = false;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = "select * from Users where UserName = @UserName and Password = @Password";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("UserName", UserName);
            command.Parameters.AddWithValue("Password", Password);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if(reader.Read())
                {
                    id = (int)reader["ID"];
                    UserName = (string)reader["UserName"];
                    FirstName = (string)reader["FirstName"];
                    LastName = (string)reader["LastName"];
                    Phone = (string)reader["Phone"];

                    if (reader["Email"] != DBNull.Value)
                        Email = (string)reader["Email"];               

                    Password = (string)reader["Password"];
                    Permissions = (int)reader["Permissions"];

                    isFound = true;
                }
                reader.Close();
            }
            catch (Exception e)
            {
            }
            finally
            {
                connection.Close();
            }
            return isFound;
        }


        public static int AddNewUser(string UserName, string FirstName, string LastName, string Phone, string Email, string Password, int Permissions)
        {
            int ID = -1;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = @"Insert into Users(UserName, FirstName, LastName, Phone, Email, Password, Permissions)
                             values (@UserName, @FirstName, @LastName, @Phone, @Email, @Password, @Permissions);
                             select scope_identity();";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("UserName", UserName);
            command.Parameters.AddWithValue("FirstName", FirstName);
            command.Parameters.AddWithValue("LastName", LastName);
            command.Parameters.AddWithValue("Phone", Phone);
            if (Email != "")
                command.Parameters.AddWithValue("Email", Email);
            else
                command.Parameters.AddWithValue("Email", DBNull.Value);

            command.Parameters.AddWithValue("Password", Password);
            command.Parameters.AddWithValue("Permissions", Permissions);


            try
            {
                connection.Open();

                object obj = command.ExecuteScalar();

                if (obj != null)
                {
                    ID = Convert.ToInt32(obj);
                }
            }
            catch (Exception e)
            {
            }
            finally
            {
                connection.Close();
            }

            return ID;
        }


        public static bool UpdateUser(int id, string UserName, string FirstName, string LastName, string Phone, string Email, string Password, int Permissions)
        {
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);
            string query = @"Update Users set UserName = @UserName, FirstName = @FirstName, LastName = @LastName, Phone = @Phone, 
                             Email = @Email, Password = @Password, Permissions = @Permissions
                             Where ID = @id";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("id", id);
            command.Parameters.AddWithValue("UserName", UserName);
            command.Parameters.AddWithValue("FirstName", FirstName);
            command.Parameters.AddWithValue("LastName", LastName);
            command.Parameters.AddWithValue("Phone", Phone);
            if (Email != "")
                command.Parameters.AddWithValue("Email", Email);
            else
                command.Parameters.AddWithValue("Email", DBNull.Value);

            command.Parameters.AddWithValue("Password", Password);
            command.Parameters.AddWithValue("Permissions", Permissions);

            int result = 0;
            try
            {
                connection.Open();

                result = command.ExecuteNonQuery();
            }
            catch (Exception e)
            {
            }
            finally
            {
                connection.Close();
            }

            return result > 0;
        }

        public static bool DeleteUser(string UserName)
        {
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);
            string query = "delete from Users where UserName = @UserName";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("UserName", UserName);

            int result = 0;
            try
            {
                connection.Open();

                result = command.ExecuteNonQuery();
            }
            catch (Exception e)
            {
            }
            finally
            {
                connection.Close();
            }

            return result > 0;
        }

        public static DataTable GetAllUsers()
        {
            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = "select * from Users";
            SqlCommand command = new SqlCommand(query, connection);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    dt.Load(reader);
                }
                reader.Close();
            }
            catch (Exception e)
            {
            }
            finally
            {
                connection.Close();
            }
            return dt;
        }




    }



    public class clsClientData
    {
        public static bool FindByID(int id, ref string AccountNumber, ref string FirstName, ref string LastName, ref string Phone,
            ref string Email, ref string PinCode, ref decimal Balance)
        {
            bool isFound = false;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = @"select * from Clients where id = @id";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("id", id);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    AccountNumber = (string)reader["AccountNumber"];
                    FirstName = (string)reader["FirstName"];
                    LastName = (string)reader["LastName"];
                    Phone = (string)reader["Phone"];

                    if (reader["Email"] != DBNull.Value)
                        Email = (string)reader["Email"];

                    PinCode = (string)reader["PinCode"];
                    Balance = (decimal)reader["Balance"];

                    isFound = true;
                }
                reader.Close();
            }
            catch (Exception e)
            {
            }
            finally
            {
                connection.Close();
            }
            return isFound;
        }
        public static bool FindByAccountNumber(ref int id, ref string AccountNumber, ref string FirstName, ref string LastName, ref string Phone,
            ref string Email, ref string PinCode, ref decimal Balance)
        {
            bool isFound = false;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = "select * from Clients where AccountNumber = @AccountNumber";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("AccountNumber", AccountNumber);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    id = (int)reader["ID"];
                    AccountNumber = (string)reader["AccountNumber"];
                    FirstName = (string)reader["FirstName"];
                    LastName = (string)reader["LastName"];
                    Phone = (string)reader["Phone"];

                    if (reader["Email"] != DBNull.Value)
                        Email = (string)reader["Email"];

                    PinCode = (string)reader["PinCode"];
                    Balance = (decimal)reader["Balance"];

                    isFound = true;
                }
                reader.Close();
            }
            catch (Exception e)
            {
            }
            finally
            {
                connection.Close();
            }
            return isFound;
        }


        public static int AddNewClient(string AccountNumber, string FirstName, string LastName, string Phone, string Email, string PinCode, decimal Balance)
        {
            int ID = -1;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = @"Insert into Clients(AccountNumber, FirstName, LastName, Phone, Email, PinCode, Balance)
                             values (@AccountNumber, @FirstName, @LastName, @Phone, @Email, @PinCode, @Balance);
                             select scope_identity();";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("AccountNumber", AccountNumber);
            command.Parameters.AddWithValue("FirstName", FirstName);
            command.Parameters.AddWithValue("LastName", LastName);
            command.Parameters.AddWithValue("Phone", Phone);
            if (Email != "")
                command.Parameters.AddWithValue("Email", Email);
            else
                command.Parameters.AddWithValue("Email", DBNull.Value);

            command.Parameters.AddWithValue("PinCode", PinCode);
            command.Parameters.AddWithValue("Balance", Balance);


            try
            {
                connection.Open();

                object obj = command.ExecuteScalar();

                if (obj != null)
                {
                    ID = Convert.ToInt32(obj);
                }
            }
            catch (Exception e)
            {
            }
            finally
            {
                connection.Close();
            }

            return ID;
        }


        public static bool UpdateClient(int id, string UserName, string FirstName, string LastName, string Phone, string Email, string Password, decimal Balance)
        {
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);
            string query = @"Update Clients set AccountNumber = @AccountNumber, FirstName = @FirstName, LastName = @LastName, Phone = @Phone, 
                             Email = @Email, PinCode = @PinCode, Balance = @Balance
                             Where ID = @id";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("id", id);
            command.Parameters.AddWithValue("AccountNumber", UserName);
            command.Parameters.AddWithValue("FirstName", FirstName);
            command.Parameters.AddWithValue("LastName", LastName);
            command.Parameters.AddWithValue("Phone", Phone);
            if (Email != "")
                command.Parameters.AddWithValue("Email", Email);
            else
                command.Parameters.AddWithValue("Email", DBNull.Value);

            command.Parameters.AddWithValue("PinCode", Password);
            command.Parameters.AddWithValue("Balance", Balance);

            int result = 0;
            try
            {
                connection.Open();

                result = command.ExecuteNonQuery();
            }
            catch (Exception e)
            {
            }
            finally
            {
                connection.Close();
            }

            return result > 0;
        }

        public static bool DeleteClient(int id)
        {
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);
            string query = "delete from Clients where ID = @id";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("id", id);

            int result = 0;
            try
            {
                connection.Open();

                result = command.ExecuteNonQuery();
            }
            catch (Exception e)
            {
            }
            finally
            {
                connection.Close();
            }

            return result > 0;
        }

        public static bool DeleteClient(string AccountNumber)
        {
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);
            string query = "delete from Clients where AccountNumber = @AccountNumber";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("AccountNumber", AccountNumber);

            int result = 0;
            try
            {
                connection.Open();

                result = command.ExecuteNonQuery();
            }
            catch (Exception e)
            {
            }
            finally
            {
                connection.Close();
            }

            return result > 0;
        }

        public static DataTable GetAllClients()
        {
            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = @"select * from Clients";
            SqlCommand command = new SqlCommand(query, connection);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    dt.Load(reader);
                }
                reader.Close();
            }
            catch (Exception e)
            {
            }
            finally
            {
                connection.Close();
            }
            return dt;
        }

        public static bool IsClientExist(string AccountNumber)
        {
            bool isFound = false;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = "select found = 1 from Clients where AccountNumber = @AccountNumber";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("AccountNumber", AccountNumber);

            try
            {
                connection.Open();
                object obj = command.ExecuteScalar();

                if (obj != null)
                {

                    isFound = true;
                }
            }
            catch (Exception e)
            {
            }
            finally
            {
                connection.Close();
            }
            return isFound;
        }

    }



    public class clsCurrencyData
    {

        public static DataTable GetAllCurrencies()
        {
            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = "select * from Currencies";
            SqlCommand command = new SqlCommand(query, connection);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    dt.Load(reader);
                }
                reader.Close();
            }
            catch (Exception e)
            {
            }
            finally
            {
                connection.Close();
            }
            return dt;
        }

        public static bool FindByCode(ref int id, ref string Country, ref string Code, ref string Name, ref decimal Rate)
        {
            bool isFound = false;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = "select * from Currencies where Code = @Code";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("Code", Code);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    id = (int)reader["ID"];
                    Country = (string)reader["Country"];
                    Code = (string)reader["Code"];
                    Name = (string)reader["Name"];
                    Rate = (decimal)reader["Rate"];

                    isFound = true;
                }
                reader.Close();
            }
            catch (Exception e)
            {
            }
            finally
            {
                connection.Close();
            }
            return isFound;
        }
        
        public static bool FindByCountry(ref int id, ref string Country, ref string Code, ref string Name, ref decimal Rate)
        {
            bool isFound = false;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = "select * from Currencies where Country = @Country";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("Country", Country);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    id = (int)reader["ID"];
                    Country = (string)reader["Country"];
                    Code = (string)reader["Code"];
                    Name = (string)reader["Name"];
                    Rate = (decimal)reader["Rate"];

                    isFound = true;
                }
                reader.Close();
            }
            catch (Exception e)
            {
            }
            finally
            {
                connection.Close();
            }
            return isFound;
        }


        public static bool UpdateRate(int id, decimal Rate)
        {
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.connectionString);

            string query = "Update Currencies set Rate = @Rate where id = @id";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("Rate", Rate);
            command.Parameters.AddWithValue("id", id);
            bool IsDone = false;
            try
            {
                connection.Open();
                int result = command.ExecuteNonQuery();

                if (result >0)
                {
                    IsDone = true;
                }
            }
            finally
            {
                connection.Close();
            }

            return IsDone;
        }

    }


}
