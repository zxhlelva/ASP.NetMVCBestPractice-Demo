using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcBestPractices.Models;

namespace MvcBestPractices.Controllers
{
    public class PostListActionFilterAttribute : ActionFilterAttribute
    {
        private readonly IPostModel _model;

        public PostListActionFilterAttribute()
            : this(new InMemoryPostModel())
        {
        }

        public PostListActionFilterAttribute(IPostModel model)
        {
            _model = model;
        }

        public override void OnActionExecuted(ActionExecutedContext filterContext)
        {
            var actionResult = filterContext.Result as ViewResult;
            actionResult.ViewData["PostList"] = _model.GetPosts(10);
        }
    }
}
