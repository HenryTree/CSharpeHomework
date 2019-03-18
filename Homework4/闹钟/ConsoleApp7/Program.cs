using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    public class AlarmEventArgs : EventArgs
    {
        public double gap;
    }

    public delegate void AlarmEventHandler(object sender, AlarmEventArgs e);

    public class Alarmclock
    {
        public event AlarmEventHandler Alarming;

        System.DateTime currentTime = new System.DateTime();

        public void DoAlarm(int h,int m,int s)
        {
            int hour;
            int minute;
            int second;
            double distant=1;
            while (distant > 0)
            {
                System.Threading.Thread.Sleep(500);
                hour = (int) DateTime.Now.Hour;
                minute = (int) DateTime.Now.Minute;
                second = (int)DateTime.Now.Second;
                distant = (h - hour) * 3600 + (m - minute)*60 + s - second;
                if (h == hour && m == minute) distant = 0;

                if (Alarming != null)
                {
                    AlarmEventArgs args = new AlarmEventArgs();
                    args.gap = distant;
                    Alarming(this, args);
                }
            }

        }
    }


    class UseAlarmclock
    {
        static void Main(string[] args)
        {
            int h;
            int m;
            int s;
            string input;
            Console.WriteLine("请输入你的目标时间 (小时):");
            input = Console.ReadLine();
            h = Int32.Parse(input);
            Console.WriteLine("请输入你的目标时间 (分钟):");
            input = Console.ReadLine();
            m = Int32.Parse(input);
            Console.WriteLine("请输入你的目标时间 (秒):");
            input = Console.ReadLine();
            s = Int32.Parse(input);

            var alarmclock = new Alarmclock();
            alarmclock.Alarming += ShowProgress;
            alarmclock.DoAlarm(h, m, s);

        }

        static void ShowProgress(object sender,AlarmEventArgs e)
        {
            Console.WriteLine($"Counting..." + e.gap +"second left.");
        }
    }


}
