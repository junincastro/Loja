﻿namespace LojaVirtual.Dominio.Entidades
{

    //As mesmas propriedades da tabela SubGrupo do banco SQL
    public sealed class SubGrupo
    {
        public int SubGrupoId { get; set; }
        public string GrupoCodigo { get; set; }

        public string SubGrupoCodigo { get; set; }
        public string SubGrupoDescricao { get; set; }

    }
}