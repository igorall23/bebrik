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
    public partial class Formauto : Form
    {
        public Formauto()
        {
            InitializeComponent();
        }

        private void checkBox_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox.Checked == true)
            {
                textBoxpassword.UseSystemPasswordChar = false;
            }
            else
            {
                textBoxpassword.UseSystemPasswordChar = true;
            }
        }

        private void buttonreg_Click(object sender, EventArgs e)
        {
            Formreg formreg = new Formreg();
            formreg.ShowDialog();
        }

        private void buttonstart_Click(object sender, EventArgs e)
        {
            string login = textBoxlogin.Text.Trim();
            string password = textBoxpassword.Text.Trim();
            User user = new User(login, password);
            if (user.uUserAutorisation())
            {
                this.Hide();
                Formprogram formprogram = new Formprogram();
                formprogram.Closed += (s, args) => this.Close();
                formprogram.Show();
            }
        }
    }
}
