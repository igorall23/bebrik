using System.Data.SQLite;
using System.IO;
using System.Data;
using System.Data.Common;

namespace bebrik
{
    class Database
    {
        private static string DatabaseFile = @"bebra.db";
        SQLiteConnection SQLConn = new SQLiteConnection(string.Format("DataSource ={0};", DatabaseFile));
        public Database()
        {
            if (File.Exists(DatabaseFile) == false)
            {
                DatabaseCreate();
            }
        }
        private void DatabaseCreate()
        {
            File.Create(DatabaseFile).Close();
            SQLConn.Open();
            SQLiteCommand DatabaseCommand = new SQLiteCommand("DROP TABLE IF EXISTS bebriki;"
                                                      + "CREATE TABLE bebriki("
                                                      + "ID INTEGER PRIMARY KEY AUTOINCREMENT,"
                                                      + "user TEXT,"
                                                      + "password TEXT);",
                                                      SQLConn);
            DatabaseCommand.ExecuteNonQuery();
            SQLConn.Close();
        }
        public bool UserAuto(string login, string password)
        {
            SQLConn.Open();
            SQLiteCommand SQLiteCMD = new SQLiteCommand("SELECT * FROM bebriki;", SQLConn);
            SQLiteDataReader Users = SQLiteCMD.ExecuteReader();

            foreach (DbDataRecord User in Users)
            {
                string UTrue = User["user"].ToString();
                string PTrue = User["password"].ToString();
                if (login == UTrue && password == PTrue)
                {
                    SQLConn.Close();
                    return true;
                }
            }
            SQLConn.Close();
            return false;
        }
        public bool UserSearch(string username)
        {
            SQLConn.Open();
            SQLiteCommand DatabaseCMD = new SQLiteCommand("SELECT * FROM bebriki;", SQLConn);
            SQLiteDataReader UsersList = DatabaseCMD.ExecuteReader();

            foreach (DbDataRecord UserLine in UsersList)
            {
                string UsernameTrue = UserLine["user"].ToString();
                if (username == UsernameTrue)
                {
                    SQLConn.Close();
                    return false;
                }
            }
            SQLConn.Close();
            return true;
        }
        public void UserCreate(string username, string password)
        {
            SQLConn.Open();
            SQLiteCommand DatabaseCommand = new SQLiteCommand("INSERT INTO 'bebriki' ('user', 'password') VALUES(@user, @password); ", SQLConn);
            DatabaseCommand.Parameters.Add("@user", DbType.String).Value = username;
            DatabaseCommand.Parameters.Add("@password", DbType.String).Value = password;
            DatabaseCommand.ExecuteNonQuery();
            SQLConn.Close();
        }
    }
}
