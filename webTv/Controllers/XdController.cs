using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace webTv.Controllers
{
    public class XdController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
