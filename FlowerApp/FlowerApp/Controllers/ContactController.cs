using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FlowerApp.Controllers
{
    public class ContactController : Controller
    {
        [ResponseCache(Duration = 30, Location = ResponseCacheLocation.Client)]

        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }
    }
}
