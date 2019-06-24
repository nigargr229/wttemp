using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CodeFirstProject.Models
{
    public class MyBlog
    {
        public int Id { get; set; }
        public string Image { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public string History { get; set; }
        public string Share { get; set; }
        public string Network { get; set; }
    }
}