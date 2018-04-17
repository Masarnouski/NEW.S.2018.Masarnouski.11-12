using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace NEW.S._2018.Masarnouski._11_12.Timer
{
    delegate void TimerEventHandler(object sender, TimerEventArgs e);
    class Clock
    {
        public event TimerEventHandler Ring;

        protected virtual void OnRing(object sender, TimerEventArgs e)
        {
            Ring?.Invoke(sender,e);
        }
        /// <summary>
        /// Rings the clock after a <param name="time">
        /// </summary>
        /// <param name="time"> After that time the event will be raised, time will be assigned to all subscribers </param>
        /// <param name="message"> The message thats will assigned to all subscribers</param>
        public void Set(TimeSpan time, string message)
        {
            Start(time);
            OnRing(this, new TimerEventArgs(time, message));
        }

        
        private void Start(TimeSpan time)
        {
            int milisecond = time.Milliseconds;
            Thread.Sleep(milisecond);
        }
    }
}
