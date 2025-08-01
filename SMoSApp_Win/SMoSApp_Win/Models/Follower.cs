using SMoSApp_Win.Data;
using System.ComponentModel.DataAnnotations;

namespace SMoSApp_Win.Models
{
    public class Follower
    {
        [Required]
        public string FollowerId { get; set; }

        public virtual ApplicationUser UserFollower { get; set; }

        [Required]
        public string FollowingId { get; set; }

        public virtual ApplicationUser UserFollowing { get; set; }
    }
}
