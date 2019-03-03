using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "";
            int i;
            int n;
            Console.Write("Please input an int:");
            s = Console.ReadLine();
            n = Int32.Parse(s);

            while(n % 2 == 0)
            {
                n = n / 2;
                Console.WriteLine(2+" ");
            }

            for(i = 3;i <= Math.Sqrt(n);i+=2)
            {
                while(n % i == 0)
                {
                    n = n / i;
                    Console.WriteLine(i+" ");
                }
            }
            if(n > 2)
            {
                Console.WriteLine(n);
            }
        }
    }
}
