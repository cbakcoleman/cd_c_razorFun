using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace cd_c_razorFun.Controllers
{
    public class IndexController : Controller
    {
        [Route("")]
        [HttpGet]
        public ViewResult Index()
        {
            return View();
        }
    }

}