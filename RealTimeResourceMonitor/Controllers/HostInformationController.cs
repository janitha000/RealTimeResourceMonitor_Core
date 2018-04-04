using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RealTimeResourceMonitor.Controllers
{
    [Route("api/[controller]")]
    public class HostInformationController : Controller
    {

        [HttpGet]
        public IActionResult Get()
        {
            return Ok();
        }
    }
}
