using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SensiveBlog.EntityLayer.Concrete
{
    public class Comment
    {
        public int CommentId { get; set; }
        public string Detail { get; set; }
        public DateTime CreatedDate { get; set; }
        public bool Status { get; set; } // Indicates if the comment is active or not

        public int AppUserId { get; set; } // Foreign key to the AppUser entity  
        public AppUser AppUser { get; set; } // Navigation property to the AppUser entity   

        public int ArticleId { get; set; } // Foreign key to the Article entity
        public Article Article { get; set; } // Navigation property to the Article entity


    }
}
