using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotificationEngines
{
    class Program
    {
        private static Stopwatch sw;

        public static long GetTime()
        {
            return sw.ElapsedMilliseconds;
        }

        static void Main(string[] args)
        {
            sw = new Stopwatch();
            sw.Start();

            NotificationManager manager = new NotificationManager();
            manager.Register(new TestTNE());

            manager.Run();
        }
    }
}
