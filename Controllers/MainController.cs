using Microsoft.AspNetCore.Mvc;

namespace SorteadorDeTime.Controllers
{
    public class MainController: Controller
    {
        public IActionResult Main(){
            return View("Views/Main/Main.cshtml");
        }

        public IActionResult CadastroJogador(){
            return View("Views/Main/CadastroJogador.cshtml");
        }

        public IActionResult Historic(){
            return View("Views/Main/Historic.cshtml");
        }
    }

}