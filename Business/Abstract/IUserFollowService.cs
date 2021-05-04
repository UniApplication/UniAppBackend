using CORE.Utilities;
using Entity.Concrete;
using Entity.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IUserFollowService : IBaseBusinessService<UserFollow>
    {
        IDataResult<UserFollowModelDto> getUserFollowing(UserFollow userFollow);
        IDataResult<List<UsersFollowingUnivercities>> getUsersFollowingUnivercities(int userId);
    }
}
