using LojaVirtual.Dominio.Entidades.Vitrine;
using System.Collections.Generic;

namespace LojaVirtual.Web.V2.Models
{
    public class ProdutosViewModel
    {
        public List<ProdutoVitrine> Produtos { get; set; }

        public string Titulo { get; set; }
    }
}