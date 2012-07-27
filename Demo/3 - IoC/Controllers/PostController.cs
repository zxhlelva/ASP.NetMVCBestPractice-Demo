using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Ajax;
using MvcBestPractices.Models;

namespace MvcBestPractices.Controllers
{
    public class PostController : Controller
    {
        private readonly IPostModel _model;


        public PostController(IPostModel model)
        {
            _model = model;
        }

        public ActionResult Index()
        {
            return List();
        }

        public ActionResult List()
        {
            ViewData["Title"] = "Post List";
            ViewData["posts"] = _model.GetPosts(10);
            return View("List");
        }

        public ActionResult Page(int PostID)
        {
            Post post = _model.GetPost(PostID);
            if (post == null)
            {
                TempData["ID"] = PostID;
                return RedirectToAction("Error");
            }
            ViewData["post"] = post;
            return View();
        }

    }
}