using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_10_part_1
{

    class Customer
    {
        private string email;

        public string mail
        {
            get { return email; }
            set
            {
                if (EmailValidation(value))
                {
                    this.email = value;
                }
                else
                {
                    throw new Exception("Invalid email address");
                }

            }
        }

        private string password;

        public string Password
        {
            get { return password; }
            set
            {
                if (PasswordValidation(value))
                {
                    this.password = value;
                }
                else
                {
                    throw new Exception("Invalid password");
                }
            }
        }

        public Customer(string email, string password)
        {
            this.mail = email;
            this.Password = password;
        }

        private bool PasswordValidation(string password)
        {
            if (password.Length >= 6)
            {
                foreach (char item in password)
                {
                    if (char.IsDigit(item))
                    {
                        return true;
                    }
                }

                return false;
            }
            else
            {
                return false;
            }
        }

        private bool EmailValidation(string email)
        {
            if (email.Length > 5)
            {
                if (email.Contains('@') && email.Contains('.'))
                {
                    return true;
                }
                return false;
            }
            else
            {
                return false;
            }
        }
    }
}
