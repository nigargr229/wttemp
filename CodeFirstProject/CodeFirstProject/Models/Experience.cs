using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CodeFirstProject.Models
{
    public class Experience
    {
        public int Id { get; set; }
        public string From { get; set; }
        public string To { get; set; }
        public string FromInfo { get; set; }
        public string ToInfo { get; set; }
        public string Themes { get; set; }
        public string ThemesInfo { get; set; }
        public string ContentTitle { get; set; }
        public string Content { get; set; }
    }
}