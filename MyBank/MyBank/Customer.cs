using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBank
{
    public class Customer
    {
        public int accountNumber;
        public string name;
        public string email;
        public string password;

        public Customer() 
        {
            this.accountNumber = 0;
            this.name = "";
            this.email = "";
            this.password = "";

        }

        public Customer(int accountNumber, string name, string email, string password)
        {
            this.accountNumber = accountNumber;
            this.name = name;
            this.email = email;
            this.password = password;
        }

        public Customer login(string email, string password)
        {
            if(this.email.Equals(email) && this.password.Equals(password))
            {
                return this;
            }
            else
            {
                return new Customer();
            }
        }
    }
}
