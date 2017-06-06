using LojaVirtual.Dominio.Entidades;
using System.Web.Mvc;

namespace LojaVirtual.Web.Controllers
{
    public class ModelBindingController : Controller
    {
        //
        // GET: /ModelBinding/
        public ActionResult Index()
        {
            return View(new Produto());
        }



        [HttpPost]
        public ActionResult Editar([Bind(Include = "Nome")] Produto produt)
        {

            //var produto = new Produto();

            //ValidateModel(produto);



            //produto.Nome = prod.Nome;
            //produto.Preco = prod.Preco;

            //..Outros...


            return RedirectToAction("Index");

        }
    }
}