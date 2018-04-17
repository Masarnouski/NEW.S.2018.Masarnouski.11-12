using NEW.S._2018.Masarnouski._11_12.Timer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NEW.S._2018.Masarnouski._11_12
{
    class Worker
    {
        string firstName;
        string lastName;
        string position;

        public Worker(string firstName, string lastName, string position)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.position = position;
        }
        public void Break(object sender, TimerEventArgs e)
        {
            Console.WriteLine($"The {position}: {firstName} {lastName} need to have a 5 minutes break " +
                $"Some event information {sender}    {e.message}   {e.time}");
            Console.ReadLine();
        } 
    }
}
