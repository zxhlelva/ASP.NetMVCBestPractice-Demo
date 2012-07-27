using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcBestPractices.Models
{
    public class InMemoryPostModel : IPostModel
    {
        private IList<Post> posts = new List<Post>();

        public InMemoryPostModel()
        {
            for (int i = 0; i < 50; i++)
            {
                posts.Add(new Post
                              {
                                  Title = string.Format("Post Number {0}", i),
                                  Content = string.Format("This is the content of post {0}", i),
                                  Id = i
                              });
            }
        }

        public IList<Post> GetPosts(int i)
        {
            return posts.Take(i).ToList();
        }

        public Post GetPost(int id)
        {
            Post post = posts.First(p => p.Id == id);
            return post;
        }

        public void UpdatePost(Post oldPost)
        {
            Post post = GetPost(oldPost.Id);
            if(post!=null)
            {
                post.Title = oldPost.Title;
                post.Content = oldPost.Content;
            }
            else
            {
                posts.Add(new Post()
                              {
                                  Id = oldPost.Id,
                                  Title = oldPost.Title,
                                  Content = oldPost.Content
                              });
            }
        }
    }
}