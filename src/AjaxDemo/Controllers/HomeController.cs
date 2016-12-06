using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;



namespace AjaxDemo.Controllers
{
    public class HomeController : Controller
    {

        // When Home/Ajax is requested the text bleow is returned. this is the result used in the success function in our javascript.
        public IActionResult HelloAjax()
        {
            return Content("Hello from the controller!", "text/plain");
        }
    }
}
