using System.Collections.Generic;
using UserPosts.Domain;

namespace UserPosts.Services
{
    public interface IUserWithCommentsRepository:IBaseRepository<UserWithComments>
    {
        IList<UserWithComments> GetCommentsByUserId(int id);
    }
}