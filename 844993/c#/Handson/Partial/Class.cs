using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Partial
{
    partial class ClassA
    {
        partial void setData()
        {
            Console.WriteLine("data is assigned using partial ");
        }
    }
}
