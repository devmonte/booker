using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SalonsController : ControllerBase
    {
        private readonly ILogger<SalonsController> _logger;
        private readonly ISalonsRepository _repository;

        public SalonsController(ILogger<SalonsController> logger, ISalonsRepository repository)
        {
            _logger = logger;
            _repository = repository;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var salons = _repository.GetAll();
            return Ok(salons);
        }
    }
}
