using FeeqsBlog.Domain.Articles;
using System;
using System.Collections.Generic;
using System.Text;

namespace FeeqsBlog.Application.Articles
{
    internal class ArticleService : IArticleService
    {
        public List<Article> GetAllArticles()
        {
            return new List<Article>
           {
               new()
           {
               Id = 1,
               Title = "My first Article",
               Content = "This is my first Article"
           },
               new()
           {
               Id = 2,
               Title = "My Second Article",
               Content = "This is my Second Article"
               } };
        }
    }
}
