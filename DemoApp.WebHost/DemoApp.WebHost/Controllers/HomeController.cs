using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Diagnostics;
using Newtonsoft.Json;

namespace DemoApp.WebHost.KestrelWebHost
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var localPath = Directory.GetCurrentDirectory();

            return Json(new { content = Directory.GetDirectories(localPath) });
            //ViewData["Message"] = "haha";
            //return View();
        }
    }
}
