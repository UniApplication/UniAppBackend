using CORE.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

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
    }
}
