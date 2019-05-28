using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotificationEngines
{
    public static class Data
    {
        public static User[] Users = new User[]
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
            },
            new User {
                Name = "Alex",
                DOB = new DateTime(2000, 04, 03),
                ID = 2,
                AllowMsgBox = false
            },
            new User {
                Name = "Paul",
                DOB = new DateTime(2010, 04, 03),
                ID = 2,
                AllowMsgBox = false
            }
        };
    }
}
