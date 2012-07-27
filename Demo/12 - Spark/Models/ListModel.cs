using System.Collections.Generic;

namespace MvcBestPractices.Models
{
    public class ListModel
    {
        public string Title { get; set; }
        public IList<Post> Posts { get; set; }
    }
}