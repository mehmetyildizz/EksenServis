using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EksenServis.Controllers
{
    public class Kategori : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
