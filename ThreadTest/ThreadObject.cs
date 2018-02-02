using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadTest
{
    public class ThreadObject
    {
        public bool IsRunning { get; protected set; }
        protected Thread ProcessThread { get; set; }
        public int Number { get; private set; }
        public int SleepSeconds { get; private set; }

        public ThreadObject(int num, int sleepTime)
        {
            Number = num;
            SleepSeconds = sleepTime;
            ProcessThread = new Thread(new ThreadStart(Processing));
            IsRunning = true;
            ProcessThread.Start();
        }

        private void Processing()
        {
            Console.WriteLine($"Thread {Number} Started. Will sleep for {SleepSeconds} and then exit.");
            Thread.Sleep(TimeSpan.FromSeconds(SleepSeconds));
            Console.WriteLine($"Thread {Number} finished and exiting.");
            IsRunning = false;
        }
    }
}
