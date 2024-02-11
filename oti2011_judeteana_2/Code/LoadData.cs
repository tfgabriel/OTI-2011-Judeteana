using System.Data;
using System.Data.SqlClient;
using System.Security.Cryptography.X509Certificates;

namespace oti2011_judeteana_2
{
    public class Load
    {
        public const string conString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"D:\\Proiecte C#\\OTI\\oti2011_judeteana\\oti2011_judeteana_2\\Database1.mdf\";Integrated Security=True";
        public string GetPass(string name)
        {
            using(SqlConnection con = new SqlConnection(conString))
            {
                con.Open();
                string cmdText = "Select Name, Password from Users where Name = @name";
                using(SqlCommand cmd = new SqlCommand(cmdText, con))
                {
                    cmd.Parameters.AddWithValue("Name", name);
                    
                    using(SqlDataReader rdr = cmd.ExecuteReader())
                    {
                        if (rdr.Read())
                        {
                            string pass = (string)rdr["Password"];
                            return pass;
                            
                        }
                        else
                        {
                            
                            return string.Empty;
                        }
                    }
                }
            }  
        }

        public void InsertDate(string name, DateTime date)
        {
            using(SqlConnection con =new SqlConnection(conString))
            {
                con.Open();
                string cmdText = "Update Users set LastLogin = @lastlogin where Name = @name";
                using(SqlCommand cmd = new SqlCommand(cmdText, con))
                {
                    cmd.Parameters.AddWithValue ("Name", name);
                    cmd.Parameters.AddWithValue("LastLogin", date);
                }   
            }
        }

        private List<UserModel> GetUsers()
        {
            List<UserModel> users = new List<UserModel>();
            using(SqlConnection con = new SqlConnection(conString))
            {
                con.Open();
                string cmdText = "Select (Name, LastLogin) from Users";
                using(SqlCommand cmd = new SqlCommand(cmdText, con))
                {
                    
                    using(SqlDataReader rdr = cmd.ExecuteReader())
                    {
                        if (rdr.Read())
                        {
                            users.Add(new UserModel
                            {
                                Name = (string)rdr["Name"],
                                LastLogin = (DateTime)rdr["LastLogin"]
                            });
                        }
                    }
                }
            }

            
            return users;
        }

        public DataTable UserTable()
        {
            DataTable dt = new DataTable();

            using(SqlConnection con = new SqlConnection(conString))
            {
                con.Open();
                string cmdText = "Select Name, LastLogin from Users";
                using(SqlCommand cmd =new SqlCommand(cmdText, con))
                {
                    dt.Load(cmd.ExecuteReader());
                }
            }

            return dt;
        }
    }
}