using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogProjectRedeux.Data.Models
{
    public class BlogPost
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public DateTime PostTime { get; set; }
        public List<BlogComment> Comments { get; set; }
        public BlogPost(string title, string content)
        {
            Title = title;
            Content = content;
            PostTime = DateTime.Now;
            Comments = new List<BlogComment>();
        }
        public BlogPost() { }
    }
}
