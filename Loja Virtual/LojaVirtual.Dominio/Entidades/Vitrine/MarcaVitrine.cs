using System.ComponentModel.DataAnnotations;

namespace LojaVirtual.Dominio.Entidades.Vitrine
{
    public class MarcaVitrine
    {
        [Key]
        public string MarcaCodigo { get; set; }
        public string MarcaDescricao { get; set; }
    }
}