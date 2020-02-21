using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extension
{
    static class StringHelper//by using extension method we can extend the function
    {//helper class must be Static
        public static string FirstCaseChange(this string name)
        {
            char[] input = name.ToCharArray();
            input[0] = char.IsUpper(input[0]) ? char.ToLower(input[0]) : char.ToUpper(input[0]);
            return new string(input);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            string name = "welcome";
            Console.WriteLine(name.FirstCaseChange());
            var anonymousType = new { property1 = "Ajay", property2 = 12, property3 = true };
            Console.WriteLine(anonymousType.GetType());
            Console.ReadLine();
        }
    }
}
