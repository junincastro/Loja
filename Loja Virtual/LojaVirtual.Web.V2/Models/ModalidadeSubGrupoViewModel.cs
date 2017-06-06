using System.Collections.Generic;
using LojaVirtual.Dominio.Dto;
using LojaVirtual.Dominio.Entidades;

namespace LojaVirtual.Web.Models
{
    public class ModalidadeSubGrupoViewModel
    {
        public Modalidade Modalidade { get; set; }
        public IEnumerable<SubGrupoDto> SubGrupos { get; set; }

    }
}