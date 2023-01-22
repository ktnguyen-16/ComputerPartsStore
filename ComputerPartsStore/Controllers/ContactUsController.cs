using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ComputerPartsStore.Controllers
{
    [Route("[action]")]
    //[Route("/ContactUs")]
    public class ContactUsController : Controller
    {
        public IActionResult Contact()
        {
            return View("ContactUs");
        }
    }
}
