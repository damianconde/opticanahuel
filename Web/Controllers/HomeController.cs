using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace BillingApi.Controllers
{
    public class HomeController : Controller
    {
        [Route("")]
        public IActionResult Home()
        {
            return View(new Models.Home.Index { 
                Title = "Optica Nahual 2"
            });
        }
    }
}