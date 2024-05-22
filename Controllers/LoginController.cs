using Microsoft.AspNetCore.Mvc;

namespace SorteadorDeTime.Controllers
{
    public class LoginController: Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Register()
        {
            return View();
        }
    }

}