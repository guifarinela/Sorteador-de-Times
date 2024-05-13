using Microsoft.AspNetCore.Mvc;

namespace SorteadorDeTime.Controllers
{
    public class WelcomeController: Controller
    {
        public ActionResult Index()
        {
            return View();
        }
    }

}