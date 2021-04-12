using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            // poe是 timeinfo的新物件 
            TimeInfo poe = new TimeInfo();
            // 呼叫 timeinfo裡面的方法showtime,poe套入參數18顯示晚上六點
            poe.ShowTime(18);
            Console.ReadKey();
        }

    }
}
