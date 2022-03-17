using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Diagnostics;
using Newtonsoft.Json;

namespace DemoApp.WebHost.KestrelWebHost
{
    [ApiController]
    [Route("[controller]")]
    public class ReyController : ControllerBase
    {
        [HttpPost]
        public object Post([FromBody] Dictionary<string, string> data)
        {
            var sw = new Stopwatch();
            sw.Start();

            var reqNo = Guid.NewGuid().ToString("N").Substring(0, 8);

            return new { data = System.IO.Directory.GetCurrentDirectory(), reqNo };
        }
    }
}
