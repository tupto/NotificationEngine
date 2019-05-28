using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotificationEngines
{
    abstract class TimedEngine : NotificationEngine
    {
        public int msBetweenRuns;
        public long lastRunAt;

        protected override bool ShouldIRun()
        {
            if (Program.GetTime() - lastRunAt > msBetweenRuns)
            {
                lastRunAt = Program.GetTime();
                return true;
            }

            return false;
        }
    }
}
