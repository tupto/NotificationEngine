using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotificationEngines
{
    class TestTNE : TimedEngine
    {
        public TestTNE()
        {
            this.lastRunAt = 0;
            this.msBetweenRuns = 10000;
            this.Message = "My name is {0}";
        }

        protected override string[] GetData(User user)
        {
            return new string[] { user.Name };
        }

        protected override User[] GetUsers()
        {
            return new User[]
            {
                new User {
                    Name = "Skrillex",
                    DOB = new DateTime(1996, 09, 18),
                    ID = 0,
                    AllowMsgBox = false
                },
                new User {
                    Name = "Jeff",
                    DOB = new DateTime(1986, 10, 18),
                    ID = 1,
                    AllowMsgBox = false
                }
            };
        }
    }
}
