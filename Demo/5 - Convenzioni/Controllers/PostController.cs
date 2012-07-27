using System;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Ajax;
using MvcBestPractices.Models;
using MvcBestPractices.Personal;

namespace MvcBestPractices.Controllers
{
    public class PostController : BaseController
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
            var viewModel = new ListModel()
                                {
                                    Title = "Post List",
                                    Posts = _model.GetPosts(10)
                                };
            return View(viewModel);
        }

        public ActionResult Page(int PostID)
        {
            if (PostID > 10)
            {
                TempData["ID"] = PostID;
                return RedirectToAction("Error");
            }

            Post post = _model.GetPost((int)PostID);
            if (post == null)
            {
                TempData["ID"] = PostID;
                return RedirectToAction("Error");
            }
            
            var viewModel = new ShowPostModel();
            viewModel.Post = post;
            return View(viewModel);
        }

    }
}