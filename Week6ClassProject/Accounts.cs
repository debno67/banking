using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week6ClassProject
{
    class Account
    {
        //accounts class
        //each transaction with date and time (Date & Time Class)
        //+ for deposit 
        //- for withdraw
        //show transaction amount
        //show new balance
        //Streamwriter and account summary
        //public void AccountInfo()

        //fields

        double balance;
        string firstName;
        string lastName;

        //properties

        public double Balance
        {
            get { return this.balance; }
            set { this.balance = value; }
        }
        public string FirstName
        {
            get { return this.firstName; }
            set { this.firstName = value; }
        }
        public string LastName
        {
            get { return this.lastName; }
            set { this.lastName = value; }
        }
        //withdraw method
        public void Withdraw()
        {
            Console.WriteLine("Withdrew amount ${0}");
            double amount = double.Parse(Console.ReadLine());
            this.balance -= amount;
        }
        //deposit method
        public void Deposit()
        {
            Console.WriteLine("Deposit amount ${0}");
            double amount = double.Parse(Console.ReadLine());
            this.balance += amount;

        }
        //balance method
        public void GetBalance()
        {
            Console.WriteLine("Balance, {0}", this.balance);
        }

        //constructor
        public Account()
        {
        }
        public Account(double balance, string firstName, string lastName)
        {

            this.Balance = balance;
            this.FirstName = firstName;
            this.LastName = lastName;
        }
    }
}