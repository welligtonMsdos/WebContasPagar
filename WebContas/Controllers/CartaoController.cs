using Microsoft.AspNetCore.Mvc;

namespace WebContas.Controllers
{
    public class CartaoController : Controller
    {
        public CartaoController()
        {
            
        }

        public IActionResult GetCartoes()
        {
            return View();
        }
    }
}
