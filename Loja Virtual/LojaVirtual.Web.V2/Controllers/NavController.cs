﻿using LojaVirtual.Dominio.Repositorio;
using LojaVirtual.Web.V2.Models;
using System.Web.Mvc;

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

        public JsonResult TesteMetedoVitrine()
        {
            ProdutoModeloRepositorio repositorio = new ProdutoModeloRepositorio();



            var produtos = repositorio.ObterProdutosVitrine(modalidade: "0051");

            return Json(produtos, JsonRequestBehavior.AllowGet);
        }


        [Route("nav/{id}/{marca}")]
        public ActionResult ObterProdutosPorMarcas(string id)
        {


            //repositorio.ObterProdutosVitrine(linha: id, subcategoria: id);

            // var model = new ProdutosViewModel {Produtos = null};

            return View();
        }
    }
}