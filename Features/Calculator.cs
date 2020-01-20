using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Features
{
    class Calculator
    {
        int val1;
        int val2;
        public int Val1 { get => val1; set => val1 = value; }
        public int Val2 { get => val2; set => val2 = value; }
        public Calculator()
        {

        }
        public Calculator(int val1, int val2)
        {
            this.val1 = val1;
            this.val2 = val2;
        }
        public int Add(int num1, int num2)
            {
            return (num1 + num2);
            //Console.WriteLine("add: "+(num1 + num2));
            }
        public void Subtract(int num1,int num2,out int res)
        {
            res = num1 - num2;
        }
        //public void swap(int num1,int num2)//call by value
        //{
        //    int temp = num1;
        //    num1 = num2;
        //    num2 = temp;
        //    Console.WriteLine("numbers swap");
        //    Console.WriteLine(num1);
        //    Console.WriteLine(num2);

        //}
        public void swap(ref int num1, ref int num2)//call by reference
        {
            int temp = num1;
            num1 = num2;
            num2 = temp;
            Console.WriteLine("numbers swap");
            Console.WriteLine(num1);
            Console.WriteLine(num2);

        }
    }

}
