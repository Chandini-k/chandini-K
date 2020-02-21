using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bankk
{ interface loan
    {
        void getinterest();
        
    }
    interface Igloan
    {
        void goldinterest();
    }
    interface Idmat
    {
        void displaydmat();
    }
   public abstract class Bank
    {
        protected string bName;
        protected string location;
        public Bank(string bname,string location)
        {
            this.bName = bname;
            this.location = location;
        }
    }
    public class SBI:Bank,Igloan
    {
        string bManager;
        public SBI(string bname,string location,string bmgr):base(bname,location)
        {
            this.bManager = bmgr;
        }
        public void getinterest()
        {
            Console.WriteLine("SBI Loan interest rate is 12%");

        }
        public void goldinterest()
        {
            Console.WriteLine("SBI gold Loan interest rate is 12%");
        }
        public void displayDetails()
        {
            Console.WriteLine(this.bName + " " + this.location + " " + this.bManager);
        }
    }
    public class ICICI : Bank,loan,Idmat
    {
        string bHead;
        public ICICI(string bname, string location, string bHead) : base(bname, location)
        {
            this.bHead = bHead;
        }
        public void getinterest()
        {
            Console.WriteLine("ICICI Loan interest rate is 22%");
        }
        public void displayDetails()
        {
            Console.WriteLine(this.bName + " " + this.location + " " + this.bHead);
        }
        public void displaydmat()
        {
            Console.WriteLine("Dmat account");
        }
    }
}
