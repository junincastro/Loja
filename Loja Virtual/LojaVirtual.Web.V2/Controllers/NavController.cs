﻿using System.Web.Mvc;
using LojaVirtual.Dominio.Repositorio;
using LojaVirtual.Web.V2.Models;

namespace LojaVirtual.Web.V2.Controllers
{
    public class NavController : Controller
    {

        private ProdutoModeloRepositorio _repositorio;
        private ProdutosViewModel _model;

        public ActionResult Index()
        {
            _repositorio = new ProdutoModeloRepositorio();
            var produtos = _repositorio.ObterProdutosVitrine();
            _model = new ProdutosViewModel { Produtos = produtos };
            return View(_model);
        }

        [Route("nav/{id}/{marca}")]
        public ActionResult ObterProdutosPorMarcas(string id, string marca)
        {
            _repositorio = new ProdutoModeloRepositorio();
            var produtos = _repositorio.ObterProdutosVitrine(marca: id);
            _model = new ProdutosViewModel { Produtos = produtos, Titulo = marca };
            return View("Navegacao", _model);
        }


        [Route("nav/times/{id}/{clube}")]
        public ActionResult ObterProdutosPorClubes(string id, string clube)
        {
            _repositorio = new ProdutoModeloRepositorio();
            var produtos = _repositorio.ObterProdutosVitrine(linha: id);
            _model = new ProdutosViewModel { Produtos = produtos, Titulo = clube };
            return View("Navegacao", _model);
        }



        [Route("nav/genero/{id}/{genero}")]
        public ActionResult ObterProdutosPorGenero(string id, string genero)
        {
            _repositorio = new ProdutoModeloRepositorio();
            var produtos = _repositorio.ObterProdutosVitrine(genero: id);
            _model = new ProdutosViewModel { Produtos = produtos, Titulo = genero };
            return View("Navegacao", _model);
        }
    }
}