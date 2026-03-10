using Microsoft.AspNetCore.Mvc;

namespace NetCoreSeguridadPersonalizada.Controllers
{
    public class UsuariosController : Controller
    {
        public IActionResult Perfil()
        {
            return View();
        }
    }
}
