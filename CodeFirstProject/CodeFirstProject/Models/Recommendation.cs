using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CodeFirstProject.Models
{
    public class Recommendation
    {
        public int Id { get; set; }
        public string Content { get; set; }
        public string Author { get; set; }
        public string Profession { get; set; }
    }
}