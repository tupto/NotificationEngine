using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotificationEngines
{
    class NotificationManager
    {
        List<object> engines;
        long fullTime;
        
        public void Run()
        {
            while (true)
            {
                fullTime = Program.GetTime();

                foreach (NotificationEngine engine in engines)
                {
                    try
                    {
                        engine.TryBroadcast();
                    }
                    catch (Exception ex) { }
                }
            }
        }

        public void Register(object engine)
        {
            if (engines == null)
                engines = new List<object>();
            
            engines.Add(engine);
        }
    }
}
