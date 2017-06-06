﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LojaVirtual.Dominio.Entidades;
using LojaVirtual.Dominio.Entidades.Vitrine;

namespace LojaVirtual.Dominio.Repositorio
{
    public class MenuRepositorio
    {
        private readonly EfDbContext _context = new EfDbContext();

        public IEnumerable<Categoria> ObterCategorias()
        {
            return _context.Categorias.OrderBy(c => c.CategoriaDescricao);
        }

        /// <summary>
        /// Obter algumas marcas
        /// </summary>
        /// <returns></returns>

        public IEnumerable<MarcaVitrine> ObterMarcas()
        {
            return _context.MarcaVitrine.OrderBy(m => m.MarcaDescricao);
        }

        public IEnumerable<ClubesNacionais> ObterClubesNacionais()
        {
            return _context.ClubesNacionais.OrderBy(c => c.LinhaDescricao);
        }

        public IEnumerable<ClubesInternacionais> ObterClubesInternacionais()
        {
            return _context.ClubesInternacionais.OrderBy(c => c.LinhaDescricao);
        }

        //Obtenho as categorias pré definidas através da query na tabela categoria
        public IEnumerable<Categoria> ObterTenisCategoria()
        {
            var categorias = new[] { "0005", "0082", "0112", "0010", "0006", "0063" };
            return _context.Categorias.Where(c => categorias.Contains(c.CategoriaCodigo)).OrderBy(c => c.CategoriaDescricao);
        }

        //Subgrupo tenis
        public SubGrupo SubGrupoTenis()
        {
            return _context.SubGrupos.FirstOrDefault(s => s.SubGrupoCodigo == "0084");
        }
    }
}