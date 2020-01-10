using System.Collections.Generic;

namespace UserPosts.Domain
{
    public class UserWithComments:BaseEntity
    {
        public User User { get; set; }
        public List<Comments> Comments { get; set; }
    }
}