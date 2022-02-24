using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Exercicio1.Helpers
{
    public static class HelperFrase
    {
        public static MvcHtmlString ExibeFrase(this HtmlHelper hp)
        {
            string str = "<div style='width: 100%; text-align:center; padding:10px'>" +
                         "<h2>Os melhores serviços no melhor lugar!</h2>" +
                         "</div>";

            return new MvcHtmlString(str);
        }
    }
}