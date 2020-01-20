using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    class Accounts
    {
        static string bankname;
        int accno, amount;
        float balance;
        string cus_name, acc_type, trans_type;
           public int Accno
        {
            get
            {
                return accno;
            }
            set { accno = value; }
        }
        public int Amount
        {
            get
            {
                return amount;
            }
            set
            {
                amount = value;
            }
        }
        public string Cusname
        {
            get
            {
                return cus_name;
            }
            set
            {
                cus_name = value;
            }
        }
        public string Acctype
        {
            get
            {
                return acc_type;
            }
            set
            {
                acc_type = value;
            }
        }
        public string Transtype
        {
            get
            {
                return trans_type;
            }
            set
            {
                trans_type = value;
            }
        }
        public float Balance
        {
            get
            {
                return balance;
            }
            set
            {
                balance = value;
            }
        }
        static Accounts()
        {
            bankname = "SBI";
        }//static constructor used initialise static member
        public Accounts(int ano, string name, string actype,int amount)
        { 
            this.accno = ano;
            this.cus_name = name;
            this.acc_type = actype;
            this.amount = amount;
        }
        public int credit(int amnt)
        {
            int res=amount + amnt;
            return res;
        }
        public int debit(int amt)
        {
            return (amount - amt);
        }
        public void display()
        {
            Console.WriteLine("the customer details\n");
            Console.WriteLine("\nbankname:"+bankname+"\nName:" + this.cus_name + "\nAcctype: " + this.acc_type + "\nAccno: " + this.accno);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("enter acc no");
            int accno = int.Parse(Console.ReadLine());
            Console.WriteLine("enter name");
            string cusname= Console.ReadLine();
            Console.WriteLine("enter acc type");
            string acctype= Console.ReadLine();
            Console.WriteLine("enter amount initial");
            int amont = int.Parse(Console.ReadLine());
            Accounts ac = new Accounts(accno,cusname,acctype,amont);
            ac.display();
            Console.WriteLine("enter transaction type(d or w)");
            string trans_type = Console.ReadLine();
            if (trans_type == "d")
            {
                Console.WriteLine("enter amount to credit");
                int c = int.Parse(Console.ReadLine());
                Console.WriteLine("balance after credit " + ac.credit(c));
            }
            else
            {
                Console.WriteLine("enter amount to debit");
                int d = int.Parse(Console.ReadLine());
                Console.WriteLine("balance after debit " + ac.debit(d));
            }
            Console.ReadLine();

        }
    }
}
