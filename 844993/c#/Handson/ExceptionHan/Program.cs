using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHan
{
    class EmpExcepton
    {
        public EmpExcepton(string name,string Id,int salary)

    }
    public class SalaryException:Exception
    {
        public SalaryException(string s):base(s)
        { }
    }
    public class Program
    {
        static void Main(string[] args)
        {
            EmpExcepton emp = new EmpExcepton("chandu", "100", 0);

        }
    }
    
}
