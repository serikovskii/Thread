using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ThredPoolLesson
{
    class Program
    {
        static void Main(string[] args)
        {
            //for (int i = 0; i < 20; i++)
            //{
            //    ThreadPool.QueueUserWorkItem(PrintNumbers);
            //}

            Timer timer = new Timer(PrintTime, null, TimeSpan.FromSeconds(0), TimeSpan.FromSeconds(1));
            Console.ReadLine();
            timer.Dispose();
        }

        private static void PrintNumbers(object data)
        {
            var currentThread = Thread.CurrentThread;
            Console.WriteLine($"{currentThread.ManagedThreadId} работает...");

            for (int i = 0; i < 10; i++)
            {
                Console.Write(i + " ");
                Thread.Sleep(200);
            }

            Console.WriteLine($"\nПоток {currentThread.ManagedThreadId} закончил работу...");

        }

        private static void PrintTime(object data)
        {
            var now = DateTime.Now;
            Console.WriteLine(now.ToString("hh:mm:ss"));
        }
    }
}
