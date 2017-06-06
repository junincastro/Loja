﻿using System.Linq;
using System.Web.Mvc;
using LojaVirtual.Dominio.Repositorio;
using LojaVirtual.Web.Models;
using LojaVirtual.Dominio.Entidades;
using System;

namespace LojaVirtual.Web.Controllers
{
    public class VitrineController : Controller
    {
        private ProdutosRepositorio _repositorio;
        public int ProdutosPorPagina = 12;

        //public ViewResult ListaProdutos(string categoria, int pagina = 1)
        //{
        //    _repositorio = new ProdutosRepositorio();

        //    ProdutosViewModel model = new ProdutosViewModel
        //    {

        //        Produtos = _repositorio.Produtos
        //            .Where(p => categoria == null || p.Categoria == categoria)
        //            .OrderBy(p => p.Descricao)
        //            .Skip((pagina - 1) * ProdutosPorPagina)
        //            .Take(ProdutosPorPagina),

        //        Paginacao = new Paginacao
        //        {
        //            PaginaAtual = pagina,
        //            ItensPorPagina = ProdutosPorPagina,
        //            ItensTotal = categoria == null ? _repositorio.Produtos.Count() : _repositorio.Produtos.Count(e => e.Categoria == categoria)
        //        },

        //        CategoriaAtual = categoria
        //    };

        //    return View(model);
        //}

        [Route("DetalhesProduto/{id}/{produto}")]
        public ViewResult Detalhes(int id)
        {
            _repositorio = new ProdutosRepositorio();
            Produto produto = _repositorio.ObterProduto(id);
            return View(produto);
        }

        public ViewResult ListaProdutos(string categoria)
        {
            _repositorio = new ProdutosRepositorio();

            var model = new ProdutosViewModel();

            var rnd = new Random();

            if (categoria != null)
            {
                model.Produtos = _repositorio.Produtos
                    .Where(p => p.Categoria == categoria)
                    .OrderBy(x => rnd.Next()).ToList();
            }
            else
            {
                model.Produtos = _repositorio.Produtos
                    .OrderBy(x => rnd.Next())
                    .Take(ProdutosPorPagina).ToList();
            }

            return View(model);
        }

        [Route("Vitrine/ObterImagem/{produtoid}")]
        public FileContentResult ObterImagem(int produtoId)
        {
            _repositorio = new ProdutosRepositorio();
            Produto prod = _repositorio.Produtos
                .FirstOrDefault(p => p.ProdutoId == produtoId);

            if (prod != null)
            {
                return File(prod.Imagem, prod.ImagemMimeType);
            }


            return null;
        }
    }
}