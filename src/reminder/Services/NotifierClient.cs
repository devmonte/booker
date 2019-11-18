using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Booker.Reminder.Services
{
    public class NotifierClient : INotifierClient
    {
        public Task Notify()
        {
            return Task.CompletedTask;
        }
    }
}
