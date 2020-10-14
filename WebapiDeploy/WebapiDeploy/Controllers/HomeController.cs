using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using WebapiDeploy.Model;
using WebapiDeploy.Repository;

namespace WebapiDeploy.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HomeController : ControllerBase
    {
        private readonly ICustomerRepository _repo;

        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger, ICustomerRepository repo)
        {
            _logger = logger; _repo = repo;
        }

        [HttpGet]
        public IEnumerable<Customer> Get()
        {
            return _repo.GetCustomers();
        }
        [HttpPost("Add")]
        public IActionResult Add([FromBody] Customer customer)
        {
            return Ok(_repo.Add(customer));
        }
    }
}
