using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NotificationEngines
{
    abstract class NotificationEngine
    {
        NotificationType _notificationType;
        public NotificationType NotificationType
        {
            get { return this._notificationType; }
        }

        string _message;
        public string Message
        {
            get { return _message; }
            protected set { _message = value; }
        }

        public NotificationEngine() { }

        public void TryBroadcast()
        {
            if (!ShouldIRun())
            {
                throw new Exception("I should not be run");
            }

            User[] users = GetUsers();

            for (int i = 0; i < users.Length; i++)
            {
                bool sent = false;
                string message = String.Format(_message, GetData(users[i]));

                if (_notificationType == NotificationType.MessageBox ||
                    _notificationType == NotificationType.Both ||
                    _notificationType == NotificationType.Either)
                {
                    if (users[i].AllowMsgBox)
                    {
                        MessageBox.Show(message);
                        sent = true;
                    }
                }

                if (_notificationType == NotificationType.Console ||
                    _notificationType == NotificationType.Both ||
                    (_notificationType == NotificationType.Either && !sent))
                {
                    Console.WriteLine(message);
                    sent = true;
                }

                if (!sent)
                    throw new Exception("Tried to send but failed");
            }
        }

        //Get the variables and bits needed to place into text. Return null if no values need to be entered.
        abstract protected string[] GetData(User user);

        //Get the users we want to send the notification to.
        abstract protected User[] GetUsers();

        //Determine if the notification should be shown for the user
        abstract protected bool ShouldIRun();
    }
    
    enum NotificationType
    {
        Console,
        MessageBox,
        Either,
        Both
    }
}
