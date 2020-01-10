using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using UserPosts.Domain;
using UserPosts.Services;

namespace UserPosts.Data
{
    public class CommentsDataAccess:BaseDataAccess<Comments>,ICommentsRepository
    {
        protected override string GetFile()
        {
            return @"..\..\..\UserPosts.Data\Files\comments.json";
        }
        private UserDataAccess user = new UserDataAccess();
        private PostDataAccess post = new PostDataAccess();

        public IList<Comments> GetCommentByPostId(int id)
        {
            var list = this.GetAll();
            return list.Where(x => x.PostId == id).ToList();
        }
        // public IList<UserWithComments> GetCommentsByUserId(int id)
        // {
        //
        //     var list = this.GetAll();
        //     var userList = user.GetAll();
        //     var postList = post.GetAll();
        //     var commentsByUser = (from comments in list 
        //             join posts in postList
        //                 on comments.PostId equals posts.Id
        //             join users in userList
        //                     on posts.UserId equals users.Id
        //                           where users.Id == id
        //
        //                     select new
        //                     {
        //                         id = comments.Id,
        //                         postId = comments.PostId,
        //                         text = comments.Text
        //                     }).ToList() ;
        //
        //     return commentsByUser as IList<UserWithComments>;
        // }
    }
}