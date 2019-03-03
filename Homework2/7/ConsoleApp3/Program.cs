using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] num;
            int length;
            string s;
            int i;

            int max, min;
            double sum;
            double avg;

            Console.WriteLine("请输入数组的长度：");
            s = Console.ReadLine();
            length = Int32.Parse(s);
            num = new int[length];

            Console.WriteLine("请给数组的" + length + "个元素赋值：");
            for(i = 0;i <= length - 1; i++)
            {
                s = Console.ReadLine();
                num[i] = int.Parse(s);
            }

            max = num[0];
            min = num[0];
            for(i = 1;i <= length-1; i++)
            {
                if (max <= num[i])
                    max = num[i];
            }

            for (i = 1; i <= length - 1; i++)
            {
                if (min >= num[i])
                    min = num[i];
            }

            sum = 0;
            for (i = 0;i<= length - 1; i++)
            {
                sum += num[i];
            }

            avg = sum / length;

            Console.WriteLine("该数组的最大值为：" + max + "；最小值为：" + min + "；平均值为：" + avg + "；所有元素和为：" + sum);
        }
    }
}
