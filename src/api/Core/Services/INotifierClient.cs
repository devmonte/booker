using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.DomainObjects;

namespace Core.Services
{
    public interface INotifierClient
    {
        void SendNotification(Notification notification);
    }
}
