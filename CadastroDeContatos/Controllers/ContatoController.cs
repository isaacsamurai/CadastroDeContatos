using Microsoft.AspNetCore.Mvc;

namespace CadastroDeContatos.Controllers
{
    public class ContatoController : Controller
    {
        public IActionResult Index()
        {
            return View();

        }
    }
}
