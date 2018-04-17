using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NEW.S._2018.Masarnouski._11_12.Timer
{
    class TimerEventArgs: EventArgs
    {
        public readonly TimeSpan time;
        public readonly string message;

        public TimerEventArgs(TimeSpan time, string message)
        {
            this.message = message;
            this.time = time;
        }
    }
}
