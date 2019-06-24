using CodeFirstProject.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CodeFirstProject.DAL
{
    public class AdamContext :DbContext
    {
        public AdamContext() :base("AdamConnection")
        {
        }

        public DbSet<AboutInfo> AboutInfos { get; set; }
        public DbSet<ConnectNumber> ConnectNumbers { get; set; }
        public DbSet<Education> Educations { get; set; }
        public DbSet<Experience> Experiences { get; set; }

        public DbSet<Language> Languages { get; set; }
        public DbSet<MyBlog> MyBlogs { get; set; }
        public DbSet<PersonalDetails> PersonalDetails { get; set; }
        public DbSet<Portfolio> Portfolios { get; set; }
        public DbSet<PortfolioNav> PortfolioNavs { get; set; }
        public DbSet<Recommendation> Recommendations { get; set; }
        public DbSet<Skills> Skills { get; set; }
        public DbSet<AdminUser> AdminUsers { get; set; }
    }
}