using UserPosts.Data;
using UserPosts.Domain;
using UserPosts.Services;

namespace UserPosts.App
{
    public class Program
    {
        static void Main(string[] args)
        {
            IPostRepository postRepository = new PostDataAccess();
            IUserRepository userRepository = new UserDataAccess();
            ICommentsRepository commentsRepository = new CommentsDataAccess();

            var service = new UserService(userRepository, postRepository);

            var response = service.GetUserActiveRespose(2);
        }
    }
}