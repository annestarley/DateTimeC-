    using Microsoft.AspNetCore.Mvc;

    namespace DateTime.Controllers
    {
        public class IndexController : Controller
        {
            [HttpGet]
            [Route("")]
            public IActionResult Index()
            {
                return View();
            }
        }
    }