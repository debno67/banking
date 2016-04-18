using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week6ClassProject
{
    class Client
    {
        //client class
        //client name
        //client acct number
        //random method to generate account number
        //fields
        private string name = "Debbie Nolan";
        private int accountNumber = int.Parse("123445678 ");
       
        //properties
        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }
        public int AccountNumber
        {
            get { return this.accountNumber; }
            set { this.accountNumber = value; }
   
        }
        //methods

        public void Userinfo()
        {

            Console.WriteLine(this.name + " Account Number: " + this.accountNumber);
        }
        public Client()
        {

        }
        public Client(string name, int accountNumber)
        {
            this.AccountNumber = accountNumber;
            this.Name = name;
           
        }
    }
}

