using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.IO;
using Newtonsoft.Json;

namespace ComputerPartsStore.Controllers
{
    public class TestController : Controller
    {

        //View
        //public IActionResult Test()
        //{
        //    return View("Test");
        //}


        //Json
        //public IActionResult Test()
        //{
        //    var data = System.IO.File.ReadAllText("C:\\Users\\Kenny\\Documents\\RTC\\CSI 350 Software Application Development II\\Week - 6\\ComputerPartsStore\\ComputerPartsStore\\wwwroot\\lib\\People.json");
        //    var x = JsonConvert.DeserializeObject(data);
        //    return Json(x);
        //}


        //Content
        //public IActionResult Test()
        //{
        //    string currentDateTime = string.Format("Current DateTime: {0}", DateTime.Now.ToString());
        //    return Content(currentDateTime);
        //}


        public IActionResult Test()
        {
            var data = System.IO.File.ReadAllText("C:\\Users\\Kenny\\Documents\\RTC\\CSI 350 Software Application Development II\\Week - 6\\ComputerPartsStore\\ComputerPartsStore\\wwwroot\\lib\\People.json");
            var x = JsonConvert.DeserializeObject(data);
            string y = x.ToString();

            if (y.Contains("Kenny"))
            {
                //OkObjectResult
                return Ok(x);
            }
            else
            {
                //NotFoundObjectResult
                //return NotFound();
                return BadRequest();
            }
        }

        //ObjectResult
        //public IActionResult Test()
        //{
        //    var data = System.IO.File.ReadAllText("C:\\Users\\Kenny\\Documents\\RTC\\CSI 350 Software Application Development II\\Week - 6\\ComputerPartsStore\\ComputerPartsStore\\wwwroot\\lib\\People.json");
        //    var x = JsonConvert.DeserializeObject(data);
        //    return new ObjectResult(x);
        //}


    }
}
