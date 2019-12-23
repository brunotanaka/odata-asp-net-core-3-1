using System;

namespace BloggerApi.Models
{
    public class Blog
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public int Year { get; set; }
    }
}
