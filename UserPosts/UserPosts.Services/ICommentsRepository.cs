using System.Collections.Generic;
using UserPosts.Domain;

namespace UserPosts.Services
{
    public interface ICommentsRepository : IBaseRepository<Comments>
    {
        IList<Comments> GetCommentByPostId(int id);
    }
}