using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ComputerPartsStore.Controllers
{
    [Route("[action]")]
    //[Route("/AboutUs")]
    public class AboutUsController : Controller
    {

        public IActionResult About()
        {
            return View();
        }
    }
}
