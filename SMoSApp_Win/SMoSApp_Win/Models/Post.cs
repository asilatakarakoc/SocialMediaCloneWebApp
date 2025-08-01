using SMoSApp_Win.Data;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.Eventing.Reader;

namespace SMoSApp_Win.Models
{
    public class Post
    {
        [Key]
        public long PostId { get; set; }

        [Required]
        [StringLength(500)]
        public string PostContent { get; set; } 

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        [Required]
        public string UserID { get; set; }

       
        public virtual ApplicationUser User { get; set; }

        public long? ParentPostId { get; set; }

        [ForeignKey("ParentPostId")]
        public virtual Post ParentPost { get; set; }
        public virtual ICollection<Like> Likes { get; set; } = new List<Like>();

        public virtual ICollection<Post> Replies { get; set; } = new List<Post>();

    }


}
