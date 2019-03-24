using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Program
    {
        
        static void Main(string[] args)
        {

        }

        public int Max(string a, string b)
        {
            if (a == "" || b == "")
                throw new NullReferenceException("Field cant be empty");

            int c = Convert.ToInt32(a);
            int d = Convert.ToInt32(b);

            if (c > d)
                return c;
            //System.Console.WriteLine(c);
            else
                return d;
            //System.Console.WriteLine(d);


        }

        //Account

        private int balance = 0;

        public int OpenAccount(string value)
        {
            if (value == "")
                throw new NullReferenceException("Field Cannot Be Empty");
            int v1 = Convert.ToInt32(value);

             balance = v1;
             return balance;
        }

        public int Deposit(string amount)
        {
            if (amount == "")
                throw new NullReferenceException("Field Cannot Be Empty");

            int a1 = Convert.ToInt32(amount);
            balance = balance + a1;
            return balance;
        }

        public int Withdraw(string amount)
        {
            if (amount == "")
                throw new NullReferenceException("Field Cannot Be Empty");

            int a1 = Convert.ToInt32(amount);

            balance = balance - a1;
            return balance;
        }
        public int LoopCode(string x)
        {
            if (x == "")
                throw new NullReferenceException("Field Cannot Be Empty");

            int a1 = Convert.ToInt32(x);
            int b = 1;
            for (int i = 0; i <= a1; i++)
            {
                b += i;
            }
            return b;

           // Console.ReadLine();
        }

        public string findStatus(string val)
        {
            switch (val)
            {
                case "A+":
                    return ("Excellent !!");
                    
                case "A":
                    return ("Very Good  !!");
                    
                case "B":
                    return ("Good  !!");
                    
                case "C":
                    return ("Passed !!");
                    
                case "D":
                    return ("Failed !!");
                    
                default:
                    return ("Out of range !!");
                    
            }
        }
    }
}

