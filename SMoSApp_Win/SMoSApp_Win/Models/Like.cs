using SMoSApp_Win.Data;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SMoSApp_Win.Models
{
    public class Like
    {
        [Required]
        public string UserId { get; set; }

        [ForeignKey("UserId")]
        public virtual ApplicationUser User { get; set; }

        [Required]
        public long PostId { get; set; }

        [ForeignKey("PostId")]
        public virtual Post Post { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

    }
}
