using System.Web.Mvc;
using AuthenticationInMVC.Models;
using System.Web.Security;

namespace AuthenticationInMVC.Controllers
{
    public class AccountController : Controller
    {
        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(LoginModel model)
        {
            if (ModelState.IsValid)
            {
                //Here we are checking the values with hardcoded admin and admin
                //You can check these values from a database
                if (model.UserName.ToLower() == "admin" && model.Password == "admin")
                {
                    //Store the Username in session
                    Session["UserName"] = model.UserName;

                    //Then redirect to the Index Action method of Home Controller
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    ModelState.AddModelError("", "Invalid User Name or Password");
                    return View(model);
                }
            }
            else
            {
                return View(model);
            }
        }
        
        
        public ActionResult Logoff()
        {
            Session["UserName"] = null;
            return RedirectToAction("Index", "Home");
        }
    }
}