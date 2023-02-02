using System;
using System.Text;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace bebrik
{
    class User
    {
        private string user;
        private string password;
        private string passworddouble;
        Database DB = new Database();
        public User(string user, string password, string passworddouble = null)
        {
            this.user = user;
            this.password = password;
            this.passworddouble = passworddouble;
        }
        public bool CorrectEntered()
        {
            if (user == "" || user == null)
            {
                MessageBox.Show("Придумайте логин");
                return false;
            }
            if (user.Length < 3)
            {
                MessageBox.Show("Логин должен содержать не менее 3 символов");
                return false;
            }

            if (password == "" || password == null)
            {
                MessageBox.Show("Придумайте пароль");
                return false;
            }
            if (password.Length < 6)
            {
                MessageBox.Show("Пароль должен содержать не менее 6 символов");
                return false;
            }
            if (password.Length > 9)
            {
                MessageBox.Show("Пароль должен содержать менее 10 символов");
                return false;
            }
            if (password != passworddouble)
            {
                MessageBox.Show("Пароли не совпадают");
                return false;
            }

            return true;
        }
        public void uUserCreate()
        {
            DB.UserCreate(user, password);
        }

        public bool uUserSearch()
        {
            bool сheck = DB.UserSearch(user);
            if (!сheck)
            {
                MessageBox.Show("Данный логин уже используется");
            }
            return сheck;
        }
        public bool uUserAutorisation()
        {
            bool сheck = DB.UserAuto(user, password);
            if (!сheck)
            {
                MessageBox.Show("Вводите логин и пароль правильно.");
            }
            return сheck;
        }
    }
}
