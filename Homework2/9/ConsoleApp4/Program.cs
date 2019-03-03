using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            int j;
            int a;
            int len = 99; //数组的长度
            int[] num;
            num = new int[len];

            for (i = 0; i <= 98; i++)
            {
                num[i] = i + 2;
            }

            for (i = 2; i <= 50; i++)
            {

                for (j = 0; j < len; j++)
                {
                    if (num[j] % i == 0 && num[j] != i)
                    {
                        a = num[j];
                        num[j] = num[len - 1];
                        num[len - 1] = a;
                        len--;
                    }

                }
            }

            for (i = 0; i < len ; i++) {
                // 第二层为从$i+1的地方循环到数组最后
                for (j = i + 1; j < len; j++) {
                    // 比较数组中两个相邻值的大小
                    if (num[i] > num[j]) {
            a = num[i]; // 这里临时变量，存贮$i的值
            num[i] = num[j]; // 第一次更换位置
            num[j] = a; // 完成位置互换
                    }
                }
            }

            Console.WriteLine("2~100以内的素数：");
                    for (i = 0; i < len; i++)
                    {
                        Console.WriteLine(num[i] + ",");
                    }
            
            
        }
    }
}
