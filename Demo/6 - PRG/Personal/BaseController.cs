using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcBestPractices.Personal
{
    public class BaseController: Controller
    {
        protected override ViewResult View(string viewName, string masterName, object model)
        {
            if (viewName == null && model != null)
                viewName = model.GetType().Name.ToLower().Replace("model", "view");
            return base.View(viewName, masterName, model);
        }
    }
}
