using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NSubstitute;
using NUnit.Framework;
using UserPosts.Domain;


namespace UserPosts.Services.UnitTests
{
    [TestFixture]
    public class UserServiceTests
    {
        [Test]
        public void Should_Have_Inactive_sytatus_when_less_than_Five_Posts()
        {
            //Arrange
            var fakeUserRepo = Substitute.For<IUserRepository>();

            var fakeUser = new User()
            {
                Email = "aa@aa.cc",
                Id = 1,
                Name = "sdsds",
                Username = "sdsda"
            };

            var fakePostRepo = Substitute.For<IPostRepository>();

            var facePost = new List<Post>()
            {
                new Post()
                {
                    Id = 1,
                    Body = "dsafasd",
                    Title = "sdfsd",
                    UserId = 1
                },
                new Post()
                {
                    Id = 3,
                    Body = "dsafasd",
                    Title = "sdfsd",
                    UserId = 1
                },
                new Post()
                {
                    Id = 2,
                    Body = "dsafasd",
                    Title = "sdfsd",
                    UserId = 1
                }
            };

            fakeUserRepo.GetById(1).Returns(fakeUser);

            fakePostRepo.GetPostsByUserId(1).ReturnsForAnyArgs(facePost);

            UserService sut = new UserService(fakeUserRepo, fakePostRepo);

            //Act

            var response = sut.GetUserActiveRespose(1);

            //Assert
            Assert.AreEqual(UserPostsStatus.Inactive, response.Status);
        }
        [Test]
        public void Should_Have_Active_sytatus_when_More_than_Seven_Posts()
        {
            //Arrange
            var fakeUserRepo = Substitute.For<IUserRepository>();

            var fakeUser = new User()
            {
                Email = "aa@aa.cc",
                Id = 1,
                Name = "sdsds",
                Username = "sdsda"
            };

            var fakePostRepo = Substitute.For<IPostRepository>();

            var facePost = new List<Post>()
            {
                new Post()
                {
                    Id = 1,
                    Body = "dsafasd",
                    Title = "sdfsd",
                    UserId = 1
                },
                new Post()
                {
                    Id = 3,
                    Body = "dsafasd",
                    Title = "sdfsd",
                    UserId = 1
                },
                new Post()
                {
                    Id = 2,
                    Body = "dsafasd",
                    Title = "sdfsd",
                    UserId = 1
                },
                new Post()
                {
                    Id = 1,
                    Body = "dsafasd",
                    Title = "sdfsd",
                    UserId = 1
                },
                new Post()
                {
                    Id = 3,
                    Body = "dsafasd",
                    Title = "sdfsd",
                    UserId = 1
                },
                new Post()
                {
                    Id = 2,
                    Body = "dsafasd",
                    Title = "sdfsd",
                    UserId = 1
                },
                new Post()
                {
                    Id = 2,
                    Body = "dsafasd",
                    Title = "sdfsd",
                    UserId = 1
                }
            };

            fakeUserRepo.GetById(1).Returns(fakeUser);

            fakePostRepo.GetPostsByUserId(1).ReturnsForAnyArgs(facePost);

            UserService sut = new UserService(fakeUserRepo, fakePostRepo);

            //Act

            var response = sut.GetUserActiveRespose(1);

            //Assert
            Assert.AreEqual(UserPostsStatus.Active, response.Status);
        }
    }
}
