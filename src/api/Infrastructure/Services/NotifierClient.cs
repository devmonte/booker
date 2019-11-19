using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.DomainObjects;
using Core.Services;
using Grpc.Net.Client;
using Microsoft.Extensions.Logging;
using Notifier;

namespace Infrastructure.Services
{
    public class NotifierClient : INotifierClient
    {
        private readonly ILogger<NotifierClient> _logger;

        public NotifierClient(ILogger<NotifierClient> logger)
        {
            _logger = logger;
        }

        public void SendNotification(Notification notification)
        {
            try
            {
                var grpcChannel = GrpcChannel.ForAddress("https://localhost:5002");
                var client = new Notifier.Notifier.NotifierClient(grpcChannel);
                var status = client.Notify(new NotifyRequest
                {
                    Mail = notification.UserMail,
                    Name = notification.UserName,
                    Phone = notification.UserPhone
                });
            }
            catch (Exception exception)
            {

                _logger.LogError("Ups!");
            }
        }
    }
}
