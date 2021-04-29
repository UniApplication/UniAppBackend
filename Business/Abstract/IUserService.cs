using CORE.Entities.Concrete;
using CORE.Utilities;
using Entity.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IUserService : IBaseBusinessService<User>
    {
        IDataResult<List<OperationClaim>> GetClaim(int userId);
        IDataResult<List<UserOperationClaimsDto>> GetClaimsByUserId(int userId);
        User GetByEmail(string email);
        IDataResult<List<OperationClaim>> GetAllClaims();
        IResult PostClaim(UserOperationClaim user);
        IResult DeleteClaim(UserOperationClaim user);
    }
}
