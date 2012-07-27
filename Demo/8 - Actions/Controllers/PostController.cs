using System;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Ajax;
using AutoMapper;
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

        public ActionResult Edit(int PostID)
        {
            Post post =_model.GetPost(PostID);
            return View(Mapper.Map<Post, EditPostModel>(post));
        }

        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult Edit(EditPostModel post)
        {
            if (String.IsNullOrEmpty(post.Title))
                ModelState.AddModelError("Title", "Title is required");

            if (ModelState.IsValid)
            {
                _model.UpdatePost(Mapper.Map<EditPostModel, Post>(post));
                return RedirectToAction("Edit", new { PostID = post.Id });
            }
            return View(post);
        }

        [PostListActionFilter]
        public ActionResult Page(int PostID)
        {
            if (PostID > 10)
            {
                TempData["ID"] = PostID;
                return RedirectToAction("Error");
            }

            Post post = _model.GetPost(PostID);
            if (post == null)
            {
                TempData["ID"] = PostID;
                return RedirectToAction("Error");
            }

            return View(Mapper.Map<Post, ShowPostModel>(post));
        }

    }
}