using CORE.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Entity.DTOs;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfUserFollowDal : EfEntityRepositoryBase<UserFollow, UniAppContext>, IUserFollowDal
    {
        public bool checkIfUserFollowing(UserFollow userFollows)
        {
            using (var context = new UniAppContext())
            {
                var result = from userFollow in context.UserFollows
                             where userFollow.UniId==userFollows.UniId && userFollow.UserId==userFollows.UserId
                             select userFollow;

                return result.Any();
            }
        }
        public UserFollowModelDto getFollow(UserFollow userFollows)
        {
            using (var context = new UniAppContext())
            {
                var result = from userFollow in context.UserFollows
                             where userFollow.UniId == userFollows.UniId && userFollow.UserId == userFollows.UserId
                             select new UserFollowModelDto
                             {
                                 userModel = userFollow,
                                 isFollowing = checkIfUserFollowing(userFollows)
                             };

                return result.FirstOrDefault();
            }
        }

        public List<UsersFollowingUnivercities> getFollowingUnivercities(int userId)
        {
            using (UniAppContext univercityContext = new UniAppContext())
            {
                var result = from user in univercityContext.UserFollows
                             join uni in univercityContext.Univercities
                             on user.UniId equals uni.Id
                             join image in univercityContext.univercityImages
                             on uni.Id equals image.UnivercityId
                             where user.UserId==userId
                             select new UsersFollowingUnivercities
                             {
                                 Id = user.Id,
                                 UnivercityName = uni.UnivercityName,
                                 Image = image.ImagePath,
                                 UnivercityId=uni.Id,
                                 StarCount = uni.StarCount
                             };
                             
                             


                return result.ToList();
            }
        }
    }
}
