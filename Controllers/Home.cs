using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace cd_c_razorFun.Controllers
{
    public class IndexController : Controller
    {
        

        [Route("")]
        [HttpGet]
        public ViewResult Index(List<string> food)
        {
            ViewBag.food = food;
            return View();
        }
    }

}