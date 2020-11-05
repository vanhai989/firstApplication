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
using MySql.Data.MySqlClient;
using System.Runtime.InteropServices;

namespace FirstApplication
{
    internal partial class Form1 : Form, ListUsname
    {
        Register register = new Register();
        ConnectDB connectDB = new ConnectDB();
        public Form1()
        {
            InitializeComponent();
        }

        void ListUsname.IPassUsname(UsenameAccount usenameItem)
        {
            MessageBox.Show(usenameItem.ToString());
        }

        private void Register_Click(object sender, EventArgs e)
        {
            register.Show();
        }

        private void Submit_Click(object sender, EventArgs e)
        {
            string inputName = TxtName.Text.ToString();
            string inputPassword = TxtPassword.Text.ToString();
            
            if (inputName.Length == 0)
            {
                TxtName.Focus();
                MessageBox.Show("field is not null!");
            }
            else if(inputPassword.Length == 0)
            {
                TxtPassword.Focus();
                MessageBox.Show("field is not null!");
            }
            else
            {
                bool isName = false;
                bool isPassword = false;
                
                UsenameAccount usenameAccount = new UsenameAccount() { Usename = inputName };
                PasswordAccount passworddAccount = new PasswordAccount() { Password = inputPassword };
                isName = connectDB.listUsename.Exists(x => x.Usename == inputName);
                isPassword = connectDB.listPassword.Exists(x => x.Password == inputPassword);

                if (isName && isPassword)
                {
                    MessageBox.Show("login succsess!");
                }
                else
                {
                    MessageBox.Show("login fail!");
                }
            }
        }

        internal void IPassUsname(UsenameAccount usenameAccount)
        {
            connectDB.listUsename.Add(usenameAccount);
        }

        public void IPassPassword(PasswordAccount passwordItem)
        {
            connectDB.listPassword.Add(passwordItem);
        }
    }
}
