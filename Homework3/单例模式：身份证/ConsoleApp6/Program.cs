using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            IdentityCardNo no1, no2;
            no1 = IdentityCardNo.getInstance();
            no2 = IdentityCardNo.getInstance();
            Console.Write("身份证号码是否一致：" + (no1 == no2));

            String str1, str2;
            str1 = no1.getIdentityCardNo();
            str2 = no1.getIdentityCardNo();
            Console.Write("第一次号码：" + str1);
            Console.Write("第二次号码：" + str2);
            Console.Write("内容是否相等：" + str1.CompareTo(str2));
            Console.Write("是否是相同对象：" + (str1 == str2));
        }
    }

    public class IdentityCardNo
    {
        private static IdentityCardNo instance = null;
        private String no;

        private IdentityCardNo()
        {
        }

        public static IdentityCardNo getInstance()
        {
            if (instance == null)
            {
               Console.Write("第一次办理身份证，分配新号码！");
                instance = new IdentityCardNo();
                instance.setIdentityCardNo("No400011112222");
            }
            else
            {
                Console.Write("重复办理身份证，获取旧号码！");
            }
            return instance;
        }

        private void setIdentityCardNo(String no)
        {
            this.no = no;
        }

        public String getIdentityCardNo()
        {
            return this.no;
        }

    }

}
