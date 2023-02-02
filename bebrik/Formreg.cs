using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bebrik
{
    public partial class Formreg : Form
    {
        public Formreg()
        {
            InitializeComponent();
        }

        private void buttoncancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void checkBox_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox.Checked == true)
            {
                textBoxpassword.UseSystemPasswordChar = false;
                textBoxpassword2.UseSystemPasswordChar = false;
            }
            else
            {
                textBoxpassword.UseSystemPasswordChar = true;
                textBoxpassword2.UseSystemPasswordChar = true;
            }
        }

        private void buttonregistr_Click(object sender, EventArgs e)
        {
            string login = textBoxlogin.Text.Trim();
            string password = textBoxpassword.Text.Trim();
            string passworddouble = textBoxpassword2.Text.Trim();

            User user = new User(login, password, passworddouble);
            bool cool1 = user.CorrectEntered();
            bool cool2 = user.uUserSearch();
            if (cool1 && cool2)
            {
                user.uUserCreate();
                MessageBox.Show("Вы успешно зарегистрировались");
                this.Close();
            }
        }
    }
}
