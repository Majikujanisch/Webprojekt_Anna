using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Webprojekt_Anna.Controllers
{
    public class Pokemon : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
