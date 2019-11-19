using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.DomainObjects;
using Core.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TestController : ControllerBase
    {
        private readonly ILogger<TestController> _logger;
        private readonly INotifierClient _notifierClient;

        public TestController(ILogger<TestController> logger, INotifierClient notifierClient)
        {
            _logger = logger;
            _notifierClient = notifierClient;
        }

        public IActionResult Get()
        {
            _logger.LogInformation("Received test request!");
            _notifierClient.SendNotification(new Notification
            {
                UserName = "Monte",
                UserPhone = "1231441",
                UserMail = "adadad"
            });
            return Ok(":)");
        }
    }
}
