using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string string1 = "";
            string string2 = "";
            int num1 = 0;
            int num2 = 0;
            double ans = 0;
            Console.Write("Please input an int:");
            string1 = Console.ReadLine();
            num1 = Int32.Parse(string1);
            Console.Write("Please input another int:");
            string2 = Console.ReadLine();
            num2 = Int32.Parse(string2);
            ans = num1 * num2;
            Console.Write("The answer is:");
            Console.Write(ans);
        }
    }
}
