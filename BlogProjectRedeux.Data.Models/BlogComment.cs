using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogProjectRedeux.Data.Models
{
    public class BlogComment
    {
        public int Id { get; set; }
        public string Author { get; set; }
        public string Content { get; set; }
        public DateTime PostTime { get; set; }
        public BlogComment(string author, string content)
        {
            Author = author;
            Content = content;
            PostTime = DateTime.Now;
        }
        public BlogComment() { }
    }
}
