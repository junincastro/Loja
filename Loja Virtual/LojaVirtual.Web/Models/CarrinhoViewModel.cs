using LojaVirtual.Dominio.Entidades;

namespace LojaVirtual.Web.Models
{
    public class CarrinhoViewModel
    {
        public Carrinho Carrinho { get; set; }

        public string ReturnUrl { get; set; }
    }
}