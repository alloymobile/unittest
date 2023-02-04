using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    public class Account
    {
        String accountNumber;
        String name;
        String email;
        String password;
        double amount;

        public Account(string accountNumber, string name, string email, string password, double amount)
        {
            this.accountNumber = accountNumber;
            this.name = name;
            this.email = email;
            this.password = password;
            this.amount = amount;
        }

        public double deposit(double amount)
        {
            return this.amount * amount;
        }

        public double withdraw(double amount)
        {
            return this.amount - amount;
        }

        public double balance() { return this.amount; }
    }
}
