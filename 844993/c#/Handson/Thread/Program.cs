using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Threa
{
    class Program
    {
        static void Main(string[] args)
        {
            ThreadClass th = new ThreadClass();
            Thread t = new Thread(th.countEven);
            Thread t1 = new Thread(th.countOdd);
            //t.Priority = ThreadPriority.Lowest;
            //t1.Priority = ThreadPriority.Highest;
            t.Start();
            t1.Start();
            //t.Suspend();
            //Console.WriteLine("thread got suspended");
            //t.Resume();
            if (!t1.IsAlive)
                t.Interrupt();
            Console.ReadLine();
        }
    }
}
