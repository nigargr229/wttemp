namespace CodeFirstProject.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<CodeFirstProject.DAL.AdamContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(CodeFirstProject.DAL.AdamContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.

            context.AboutInfos.AddOrUpdate(a => a.Id,
              new Models.AboutInfo { Id = 1, Title = "ABOUT ME", Content = "Donec id elit non mi porta gravida at eget metus. Fusce dapibus, tellus ac cursus commodo, tortor mauris condimentum nibh, ut fermentum massa justo sit amet risus. Etiam porta sem malesuada magna mollis euismod. Donec sed odio dui.", ButtonInfo = "View More", Name = "Adam Doe ", Image = "me.jpg", Position = "Chief Product Officer at Okler Themes", CountryInfo = "GREATER NEW YORK AREA", Faculty = "INFORMATION TECHNOLOGY & SERVICES", EducationTitle = "EDUCATION: ", EducationInfo = "PORTO SCHOOL", PreviosTitle = "PREVIOUS:", Previosİnfo = "FRONT-END DEVELOPER AT PORTO " }
              );

            context.ConnectNumbers.AddOrUpdate(c => c.Id,
               new Models.ConnectNumber { Id = 1, Icon = "icon-envelope", Title = "Emailll", Content = "you@domain.com" },
               new Models.ConnectNumber { Id = 2, Icon = "icon-phone", Title = "Phone", Content = "123-456-7890" },
               new Models.ConnectNumber { Id = 3, Icon = "icon-social-skype", Title = "Skype", Content = "yourskype" },
               new Models.ConnectNumber { Id = 4, Icon = "icon-share", Title = "Follow me", Content = "Facebook" }
               );

            context.Educations.AddOrUpdate(e => e.Id,
             new Models.Education { Id = 1, Icon = "icon-graduation", Title = "Porto University", Content = "Master of Information Technology", Year = "2001-2017" },
             new Models.Education { Id = 2, Icon = "icon-graduation", Title = "Porto University", Content = "Master of Information Technology", Year = "2001-2017" },
             new Models.Education { Id = 3, Icon = "icon-graduation", Title = "Porto University", Content = "Master of Information Technology", Year = "2001-2017" },
             new Models.Education { Id = 4, Icon = "icon-graduation", Title = "Porto University ", Content = "Master of Information Technology", Year = "2001-2017" }
             );

            context.Experiences.AddOrUpdate(ex => ex.Id,
             new Models.Experience { Id = 1, From = "FROM", To = "To", FromInfo = "Sep 2012", ToInfo = "Present", Themes = "Okler Themes", ThemesInfo = "GREATER NEW YORK", ContentTitle = "Chief Product Officer", Content = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Etiam tincidunt nulla tortor, a imperdiet enim tristique nec. Nulla lobortis leo eget metus dapibus sodales. Sed placerat vitae dui vitae vehicula. Quisque in tincidunt ligula, nec dignissim arcu." },
             new Models.Experience { Id = 2, From = "FROM", To = "To", FromInfo = "Sep 2012", ToInfo = "Present", Themes = "Okler Themes", ThemesInfo = "GREATER NEW YORK", ContentTitle = "Chief Product Officer", Content = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Etiam tincidunt nulla tortor, a imperdiet enim tristique nec. Nulla lobortis leo eget metus dapibus sodales. Sed placerat vitae dui vitae vehicula. Quisque in tincidunt ligula, nec dignissim arcu." },
             new Models.Experience { Id = 3, From = "FROM", To = "To", FromInfo = "Sep 2012", ToInfo = "Present", Themes = "Okler Themes", ThemesInfo = "GREATER NEW YORK", ContentTitle = "Chief Product Officer", Content = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Etiam tincidunt nulla tortor, a imperdiet enim tristique nec. Nulla lobortis leo eget metus dapibus sodales. Sed placerat vitae dui vitae vehicula. Quisque in tincidunt ligula, nec dignissim arcu." }
             );

            context.Languages.AddOrUpdate(lang => lang.Id,
            new Models.Language { Id = 1, Icon = "blank.gif", Name = "English:", Level = "Advanced" },
            new Models.Language { Id = 2, Icon = "blank.gif", Name = "Spanish:", Level = "Advanced" },
            new Models.Language { Id = 3, Icon = "blank.gif", Name = "French:", Level = "Basic" }
            );
            context.MyBlogs.AddOrUpdate(mb => mb.Id,
            new Models.MyBlog { Id = 1, Title = "Design Driven", Image = "blog-1.jpg", Content = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Etiam tincidunt nulla tortor, a imperdiet enim tristique nec. Nulla lobortis leo eget metus dapib...", History = "JULY 12-2017", Share = "SHARE:", Network = "FACEBOOK  TWITTER  GOOGLE PLUS" },
            new Models.MyBlog { Id = 2, Title = "UI, UX Concepts", Image = "blog-2.jpg", Content = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Etiam tincidunt nulla tortor, a imperdiet enim tristique...", History = "JULY 12-2017", Share = "SHARE:", Network = "FACEBOOK  TWITTER  GOOGLE PLUS" }
            );

            context.PersonalDetails.AddOrUpdate(pd => pd.Id,
           new Models.PersonalDetails { Id = 1, Title = "BIRTHDAY:", Info = " 1990 OCTOBER 2" },
           new Models.PersonalDetails { Id = 2, Title = "MARITAL:", Info = " SINGLE" },
           new Models.PersonalDetails { Id = 3, Title = "NATIONALITY:", Info = " AMERICAN" }
           );

            context.Portfolios.AddOrUpdate(p => p.Id,
           new Models.Portfolio { Id = 1, Image = "portfolio-1.jpg" },
           new Models.Portfolio { Id = 2, Image = "portfolio-2.jpg" },
           new Models.Portfolio { Id = 3, Image = "portfolio-3.jpg" },
           new Models.Portfolio { Id = 4, Image = "portfolio-4.jpg" },
           new Models.Portfolio { Id = 5, Image = "portfolio-5.jpg" },
           new Models.Portfolio { Id = 6, Image = "portfolio-6.jpg" },
           new Models.Portfolio { Id = 7, Image = "portfolio-7.jpg" },
           new Models.Portfolio { Id = 8, Image = "portfolio-8.jpg" }
         );

            context.PortfolioNavs.AddOrUpdate(pn => pn.Id,
             new Models.PortfolioNav { Id = 1, Menu = "SHOW ALL" },
             new Models.PortfolioNav { Id = 2, Menu = "WEBSITES" },
             new Models.PortfolioNav { Id = 3, Menu = "LOGOS" },
             new Models.PortfolioNav { Id = 4, Menu = "BRANDSSSS" }
         );

            context.Recommendations.AddOrUpdate(r => r.Id,
             new Models.Recommendation { Id = 1, Content = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Etiam tincidunt nulla tortor, a imperdiet enim tristique nec. Nulla lobortis leo eget metus dapibus sodales. Sed placerat vitae dui vitae vehicula. Quisque in tincidunt ligula, nec dignissim arcu. Praesent aliquam velit vel libero dictum, non sollicitudin lectus mollis. Morbi sollicitudin auctor gravida.", Author= "Bob Doe", Profession= "Director of Engineering" },
             new Models.Recommendation { Id = 2, Content = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Etiam tincidunt nulla tortor, a imperdiet enim tristique nec. Nulla lobortis leo eget metus dapibus sodales. Sed placerat vitae dui vitae vehicula. Quisque in tincidunt ligula, nec dignissim arcu. Praesent aliquam velit vel libero dictum, non sollicitudin lectus mollis. Morbi sollicitudin auctor gravida.", Author = "Bob Doe", Profession = "Director of Engineering" }
         );
            
            context.Skills.AddOrUpdate(sk => sk.Id,
             new Models.Skills { Id = 1,Name= "START UP", Animation= "0",AnimationCount=Convert.ToInt32("60") },
             new Models.Skills { Id = 2, Name = "INNOVATION", Animation = "300", AnimationCount = Convert.ToInt32("80") },
             new Models.Skills { Id = 1, Name = "PRODUCTS", Animation = "600", AnimationCount = Convert.ToInt32("70") },
             new Models.Skills { Id = 1, Name = "CSS", Animation = "900", AnimationCount = Convert.ToInt32("70") },
             new Models.Skills { Id = 1, Name = "JAVASCRIPT", Animation = "0", AnimationCount = Convert.ToInt32("90") },
             new Models.Skills { Id = 2, Name = "BUSINESS", Animation = "300", AnimationCount = Convert.ToInt32("60") },
             new Models.Skills { Id = 2, Name = "E-COMMERCE", Animation = "600", AnimationCount = Convert.ToInt32("80") },
             new Models.Skills { Id = 2, Name = "CREATIVE", Animation = "900", AnimationCount = Convert.ToInt32("90") }
         );

            context.AdminUsers.AddOrUpdate(pn => pn.Id,
           new Models.AdminUser { Id = 1, Name = "Togrul",Surname="Rzayev",Username="admin",Password= "AK62rX9TPIwJ2sJLyRPKmfUuLBj/lauQxAHdbtxGpIg4/FjcfMcjXqRSxnMuUmzxtw==" }
         
       );

        }
    }
}
