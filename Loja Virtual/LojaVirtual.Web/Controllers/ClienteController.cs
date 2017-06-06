using System.Web.Mvc;

namespace LojaVirtual.Web.Controllers
{
    public class ClienteController : Controller
    {

        public ActionResult Index()
        {
            ViewBag.Controller = "Cliente";
            ViewBag.Action = "Index";
            return View();
        }

        [Route("Usuario/Adicionar/{usuario}/{id}")]
        public string Adicionar(string usuario, int id)
        {
            return string.Format("Usuário: {0}, ID {1}", usuario, id);
        }
    }
}