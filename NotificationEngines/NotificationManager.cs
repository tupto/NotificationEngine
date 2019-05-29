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
        List<NotificationEngine> engines;
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

        public void Register(NotificationEngine engine)
        {
            if (engines == null)
                engines = new List<NotificationEngine>();
            
            engines.Add(engine);
        }
    }
}
