using Microsoft.AspNetCore.Mvc;

namespace Hamburgueria.Controllers {
    public class PedidoController : Controller {
        public IActionResult Index(){
            return View();
        }
    }
}