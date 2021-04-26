using CORE.Utilities;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IUserFollowService : IBaseBusinessService<UserFollow>
    {
        IDataResult<bool> checkIfUserFollowing(UserFollow userFollow);
    }
}
