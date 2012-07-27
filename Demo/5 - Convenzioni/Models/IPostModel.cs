using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcBestPractices.Models
{
    public interface IPostModel
    {
        IList<Post> GetPosts(int i);
        Post GetPost(int id);
    }
}