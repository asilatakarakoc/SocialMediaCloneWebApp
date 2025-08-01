using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.CompilerServices;
using SMoSApp_Win.Models;

namespace SMoSApp_Win.Data
{
    // Add profile data for application users by adding properties to the ApplicationUser class
    public class ApplicationUser : IdentityUser
    {
        [StringLength(100)]
        public string? DisplayName { get; set; }

        [StringLength(300)]
        public string? Bio {  get; set; }

        [StringLength (2048)]
        public string? ProfilePictureUrl { get; set; }

        public virtual ICollection<Post> Posts { get; set; } = new List<Post>();

        public virtual ICollection<Like> Likes { get; set; } = new List<Like>();

        [InverseProperty("UserFollower")]
        public virtual ICollection<Follower> Following { get; set; } = new List<Follower>();

        // A user can be followed by many other users.
        [InverseProperty("UserFollowing")]
        public virtual ICollection<Follower> Followers { get; set; } = new List<Follower>();

    }

}
