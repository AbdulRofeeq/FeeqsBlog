using System;
using System.Collections.Generic;
using System.Text;

namespace FeeqsBlog.Domain.Articles
{
    public class Article
    {
        public int Id { get; set; }
        public required string Title { get; set; }
        public string? Content { get; set; }
        public DateTime DatePublished { get; set; }
        public bool IsPublished { get; set; }

    }
}
