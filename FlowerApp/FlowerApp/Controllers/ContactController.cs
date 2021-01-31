using Microsoft.AspNetCore.Mvc;

namespace FlowerApp.Controllers
{
    //controller for contact
    //base class is controller
    public class ContactController : Controller
    {
        [ResponseCache(Duration = 30, Location = ResponseCacheLocation.Client)]

        // GET: /<controller>/
        //result of an action
        public IActionResult Index()
        {
            return View();
        }
    }
}
