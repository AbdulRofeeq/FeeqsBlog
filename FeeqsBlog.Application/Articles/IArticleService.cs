using FeeqsBlog.Domain.Articles;
using System;
using System.Collections.Generic;
using System.Text;

namespace FeeqsBlog.Application.Articles
{
    public interface IArticleService
    {
        List<Article> GetAllArticles();
    }
}
