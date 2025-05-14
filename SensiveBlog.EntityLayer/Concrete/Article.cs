using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SensiveBlog.EntityLayer.Concrete
{
    public class Article
    {
        public int ArticleId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CoverImageUrl { get; set; }

        public int CategoryId { get; set; }
        public Category Category { get; set; } // Navigation property to the Category entity


    }
}
