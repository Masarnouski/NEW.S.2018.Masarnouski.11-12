using NEW.S._2018.Masarnouski._11_12.Timer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NEW.S._2018.Masarnouski._11_12
{
    class Program
    {
        static void Main(string[] args)
        {
            Clock clock = new Clock();
            Worker worker = new Worker("Eugene", "Masarnouski", "Ingeneer");
            //subscribe to event

            clock.Ring += ClockRun;
            clock.Ring += worker.Break;
            clock.Set(new TimeSpan(0, 0, 30), "Hello");



            void ClockRun(object sender, TimerEventArgs e)
            {
                Console.WriteLine($"Event of type {sender} with time {e.time.ToString()} and message {e.message}");
                Console.ReadLine();
            }
        }
    }
}
