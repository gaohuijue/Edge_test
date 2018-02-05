using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace Edge_test
{
    public class Class1
    {
        public async Task<object> Concat(dynamic input)
        {
            string aString = (string)input.first;
            string anotherString = (string)input.second;
            return aString+anotherString;
        }

        public async Task<object> CallingCallback(dynamic input)
        {
            cb = (Func<object, Task<object>>)input.callback;
            StartTimer();
            return null;
        }

        private void StartTimer()
        {
            Timer tmr = new Timer();
            tmr.Elapsed += new ElapsedEventHandler(OnTimedEvent);
            tmr.Interval = 300;
            tmr.Enabled = true;
            tmr.Start();
        }

        private Func<object, Task<object>> cb;
        private void OnTimedEvent(object source, ElapsedEventArgs e)
        {
            cb(new { a = "张三", b = "123421341234" });
        }
    }
}
