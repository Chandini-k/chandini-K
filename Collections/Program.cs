using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Threading.Tasks;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList al = new ArrayList();
                al.Add(5);
                al.Add("chandu");
                al.Add(3.22);
                al.Add('d');
            al.Remove(3.22);
            foreach (var val in al)
                Console.WriteLine(val);
            
            Queue qlist = new Queue();
            qlist.Enqueue(1);
            qlist.Enqueue("cd");
            qlist.Enqueue('c');
            qlist.Dequeue();
            Console.WriteLine(qlist.Dequeue());
            foreach (var valq in qlist)
                Console.WriteLine(valq);
            
            Stack slist = new Stack();
            slist.Push(23);
            slist.Push("hello");
            slist.Push(23.13);
            Console.WriteLine(slist.Pop());
            Console.WriteLine(slist.Peek());
            foreach (var s in slist)
                Console.WriteLine(s);

            Hashtable hash = new Hashtable();
            hash.Add(1,"CTS");
            hash.Add('a', 1000);
            hash.Add("t1", 30);
            foreach (var h in hash.Keys)
            {
                Console.WriteLine(h);
                Console.WriteLine(hash[h]);
            }
            //generic
            List<int> list = new List<int>();
            list.Add(10);
            list.Add('a');
            list.Add(34);
            foreach(int val in list)
            {
                Console.WriteLine(val);
            }

            Queue<string> gqlist = new Queue<string>();
            gqlist.Enqueue("1");
            gqlist.Enqueue("Arun");
            gqlist.Enqueue("c");
            Console.WriteLine(gqlist.Dequeue());
            foreach (var val in gqlist)
                Console.WriteLine(val);

            Stack<float> gslist = new Stack<float>();
            gslist.Push(23);
            gslist.Push(12.34f);
            gslist.Push(23.13f);
            Console.WriteLine(gslist.Pop());
            Console.WriteLine(gslist.Peek());
            foreach (var s in gslist)
                Console.WriteLine(s);

            HashSet<int> hs = new HashSet<int>();
            hs.Add(10);
            hs.Add(23);
            hs.Add(30);
            foreach (var h in hs)
            {
                Console.WriteLine(h);
                Console.WriteLine("########");
            }

            Dictionary<int, string> dt = new Dictionary<int, string>();
            dt.Add(1, "chandu");
            dt.Add(2, "yash");
            dt.Add(3, "sanj");
            foreach(KeyValuePair<int,string> kl in dt)
            {
                Console.WriteLine(kl.Key);
                Console.WriteLine(kl.Value);
            }
            Console.WriteLine("enter number of employees");
            int count = int.Parse(Console.ReadLine());
            Dictionary<string, float> EmployeeSalary = new Dictionary<string, float>();
            string name;
            float salary;
           for(int c=0;c<count;c++)
            {
                Console.WriteLine("enter name ");
                name = Console.ReadLine();
                Console.WriteLine("salary :");
                salary = float.Parse(Console.ReadLine());
                EmployeeSalary.Add(name, salary);
            }
            float hsalary = 0;
            string hname="";
           foreach(KeyValuePair<string,float> emp in EmployeeSalary)
            {
                if (emp.Value > hsalary);
                {
                    hsalary = emp.Value;
                    hname = emp.Key;
                }
            }
            Console.WriteLine("the highest paid employee is " +hname);
            Console.WriteLine("salary: " + hsalary);
            Console.ReadKey();
        }
    }
}
