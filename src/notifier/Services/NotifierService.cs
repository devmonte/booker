using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Grpc.Core;
using Microsoft.Extensions.Logging;

namespace Notifier.Services
{
    public class NotifierService : Notifier.NotifierBase
    {
        private readonly ILogger<NotifierService> _logger;

        public NotifierService(ILogger<NotifierService> logger)
        {
            _logger = logger;
        }

        public override Task<NotifyReply> Notify(NotifyRequest request, ServerCallContext context)
        {
            _logger.LogInformation($"Sending notification to user: ");
            return Task.FromResult(new NotifyReply
            {
                Status = "Ok"
            });
        }
    }
}
