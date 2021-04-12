using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class TimeInfo
    {
        public TimeInfo() { Console.WriteLine("呼叫時間"); }
        ~TimeInfo() { Console.WriteLine("釋放資源"); }
        public int Hrs { get; set; }
        public void ShowTime(int tm)
        {
            Hrs = tm;
            if (Hrs > 12)
            {
                Hrs %= 12;
                Console.WriteLine($"時間是下午: {Hrs} 點");
            }
            else Console.WriteLine($"時間是上午: {Hrs} 點");
        }

    }
}
