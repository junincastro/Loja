using LojaVirtual.Dominio.Repositorio;
using System.Linq;
using System.Web.Mvc;

namespace LojaVirtual.Web.Controllers
{
    public class ProdutosController : Controller
    {
        private ProdutosRepositorio _repositorio;

        //[Route("produtos/obter")]
        public ActionResult Index()
        {
            _repositorio = new ProdutosRepositorio();
            var produtos = _repositorio.Produtos.Take(3);

            return View(produtos);
        }
    }
}