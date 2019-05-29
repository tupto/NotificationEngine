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
            this.Message = "My name is {0} and I was born in {1}";
            this.NotificationType = NotificationType.Either;
        }

        protected override string[] GetData(User user)
        {
            return new string[] { user.Name, user.DOB.Year.ToString() };
        }

        protected override User[] GetUsers()
        {
            return Data.Users.Where((user) => user.DOB.Year <= 2000).ToArray();
        }
    }
}
