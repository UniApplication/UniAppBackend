using CORE.DataAccess;
using Entity.Concrete;
using Entity.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    public interface IUserFollowDal: IEntityRepository<UserFollow>
    {
        bool checkIfUserFollowing(UserFollow userFollows);
        UserFollowModelDto getFollow(UserFollow userFollow);
        List<UsersFollowingUnivercities> getFollowingUnivercities(int userId);
    }
}
