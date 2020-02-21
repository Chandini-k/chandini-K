using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns
{
    sealed class Singleton
    {
        static int count=0;
        static Singleton Instance=null;//memory not alloted so object doesnot exist
        public static Singleton GetInstance
        {
            get
            {
                if (Instance == null) return new Singleton();
                else return Instance;
            }
        }
        private Singleton()
        {
            count++;
            Console.WriteLine(count);
        }
        public void printDetails(string s)
        {
            Console.WriteLine("printing " + s);
        }
    }
}
