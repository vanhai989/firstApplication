using FirstApplication.ConfigDB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FirstApplication
{
    public partial class Register : Form
    {
        ConnectDB connectDB = new ConnectDB();
        public Register()
        {
            InitializeComponent();
        }
    private void Submit_Click(object sender, EventArgs e)
        {
            var ListUseName = new Form1();
            if (ReUsename.Text.Length == 0)
            {
                MessageBox.Show("field is not null!");
            }
            if (ReEmail.Text.Length == 0)
            {
                MessageBox.Show("field is not null!");
            }
            if (RePassword.Text.Length == 0)
            {
                MessageBox.Show("field is not null!");
            }
            if (ReConfirmPassword.Text.Length == 0)
            {
                MessageBox.Show("field is not null!");
            }
            if (RePhone.Text.Length == 0)
            {
                MessageBox.Show("field is not null!");
            }
            else
            {

                string inputName = ReUsename.Text.ToString();
                string intputPasswordd = RePassword.Text.ToString();
                string inputEmail = ReEmail.Text.ToString();
                string inputPhone = RePhone.Text.ToString();

                UsenameAccount usenameAccount = new UsenameAccount() { Usename = inputName };
                PasswordAccount passwordAccount = new PasswordAccount() {Password = intputPasswordd };
                connectDB.listUsename.Add(usenameAccount);
                connectDB.listPassword.Add(passwordAccount);
                connectDB.listEmail.Add(new EmailAccount() { Email = inputEmail });
                connectDB.ListPhone.Add(new PhoneAccount() { Phone = inputPhone });
                ListUseName.IPassUsname(usenameAccount);
                ListUseName.IPassPassword(passwordAccount);

                this.Close();
            }
        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
