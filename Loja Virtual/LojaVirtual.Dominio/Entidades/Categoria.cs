using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LojaVirtual.Dominio.Entidades
{
    public class Categoria
    {
        public int CategoriaId { get; set; }
        public string CategoriaCodigo { get; set; }
        public string CategoriaDescricao { get; set; }
    }
}
