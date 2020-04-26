using System.Web.Mvc;
using AuthenticationInMVC.Models;

namespace AuthenticationInMVC.Controllers
{
    public class HomeController : Controller
    {
        [CustomAuthenticationFilter]
        public ActionResult Index()
        {
            return View();
        }

        [CustomAuthenticationFilter]
        public ActionResult Contact()
        {
            return View();
        }

        public ActionResult About()
        {
            return View();
        }
    }
}