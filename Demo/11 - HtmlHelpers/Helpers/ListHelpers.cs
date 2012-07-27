using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcBestPractices.Helpers
{
    public static class ListHelpers
    {
        public static string AlternateRowColor(this HtmlHelper helper,
    int row, string color)
        {
            if (row % 2 == 0)
                return "background-color:" + color;
            else
                return "";
        }
    }
}
