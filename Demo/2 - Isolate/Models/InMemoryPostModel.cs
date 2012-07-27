using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcBestPractices.Models
{
    public class InMemoryPostModel : IPostModel

    {
        private static IList<Post> posts = new List<Post>();

        static InMemoryPostModel()
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

        public  IList<Post> GetPosts(int i)
        {
            return posts.Take(i).ToList();
        }

        public Post GetPost(int id)
        {
            Post post = new Post
                            {
                                Title = string.Format("Post Number {0}", id),
                                Content = string.Format("This is the content of post {0}", id),
                                Id = id
                            };

            return post;
        }
    }
}