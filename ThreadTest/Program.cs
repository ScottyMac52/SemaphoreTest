using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadTest
{
    class Program
    {
        static void Main(string[] args)
        {
            List<ThreadObject> threadObjects = new List<ThreadObject>();

            for(int x=1; x<=10; x++)
            {
                threadObjects.Add(new ThreadObject(x, x*2));
            }

            while(threadObjects.Any(to => to.IsRunning))
            {
                Console.WriteLine("Main thread sleeping for 1 second");
                Thread.Sleep(TimeSpan.FromSeconds(1));
            }
        }
    }
}
