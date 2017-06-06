using LojaVirtual.Web.Models;
using System;
using System.Text;
using System.Web.Mvc;

namespace LojaVirtual.Web.HtmlHelpers
{
    public static class PaginacaoHelpers
    {
        public static MvcHtmlString PageLinks(this HtmlHelper html, Paginacao paginacaoInfo, Func<int, string> paginaUrl)
        {
            StringBuilder resultado = new StringBuilder();

            for (int i = 1; i <= paginacaoInfo.TotalPaginas; i++)
            {
                TagBuilder tag = new TagBuilder("a");
                tag.MergeAttribute("href", paginaUrl(i));
                tag.InnerHtml = i.ToString(); // numero da página
                if (i == paginacaoInfo.PaginaAtual) // deixar 
                {
                    tag.AddCssClass("selected");
                    tag.AddCssClass("btn-primary");
                }
                tag.AddCssClass("btn btn-default");
                resultado.Append(tag);
            }
            return MvcHtmlString.Create(resultado.ToString());
        }
    }
}