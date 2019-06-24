using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CodeFirstProject.Models
{
    public class ViewModelHome
    {
        public List<AboutInfo> AboutInfo { get; set; }
        public List<ConnectNumber> ConnectNumbers   { get; set; }
        public List<Education> Educations { get; set; }
        public List<Experience> Experiences { get; set; }
        public List<Language> Languages { get; set; }
        public List<MyBlog> MyBlogs { get; set; }
        public List<PersonalDetails> PersonalDetails { get; set; }
        public List<Portfolio> Portfolios { get; set; }
        public List<PortfolioNav> PortfolioNavs { get; set; }
        public List<Recommendation> Recommendations { get; set; }
        public List<Skills> Skills { get; set; }
    }
}