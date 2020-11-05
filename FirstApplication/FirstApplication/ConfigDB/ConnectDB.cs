using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace FirstApplication.ConfigDB
{
    class ConnectDB
    {
        public List<UsenameAccount> listUsename = new List<UsenameAccount>();
        public List<PasswordAccount> listPassword = new List<PasswordAccount>();
        public List<EmailAccount> listEmail = new List<EmailAccount>();
        public List<PhoneAccount> ListPhone = new List<PhoneAccount>();

        public ConnectDB()
        {
            CreateAccount();
        }
        void CreateAccount()
        {
            listUsename.Add(new UsenameAccount() { Usename = "addmin"});

            listPassword.Add(new PasswordAccount() { Password = "123" });

            listEmail.Add(new EmailAccount() { Email = "haidev989@gmail.com" });

            ListPhone.Add(new PhoneAccount() { Phone = "0949301778" });
        }
    }
   
    class UsenameAccount
    {
        private string usename;
        public string Usename { get => usename; set => usename = value; }
    }
    class PasswordAccount
    {
        private string password;
        public string Password { get => password; set => password = value; }
    }
    class EmailAccount
    {
        private string email;

        public string Email { get => email; set => email = value; }
    }
    class PhoneAccount
    {
        private string phone;
        public string Phone { get => phone; set => phone = value; }
    }
}
