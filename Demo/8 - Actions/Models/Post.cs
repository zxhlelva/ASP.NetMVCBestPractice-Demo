using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcBestPractices.Models
{
    public class Post
    {
        public override string ToString()
        {
            return string.Concat(title, " ", content);
        }

        public int Id { get; set; }

        private string title;
        private string content;

        public string Content
        {
            get { return content; }
            set { content = value; }
        }

        public string Title
        {
            get { return title; }
            set { title = value; }
        }
    }
}