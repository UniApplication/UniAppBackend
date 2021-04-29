using CORE.DataAccess;
using CORE.Entities.Concrete;
using Entity.DTOs;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Abstract
{
   public interface IUserDal: IEntityRepository<User>
    {
        List<OperationClaim> GetClaims(int userId);
        List<UserOperationClaimsDto> GetClaimsByUserId(int userId);
        List<OperationClaim> GetAllClaims();
        UserOperationClaim GetClaimById(Expression<Func<UserOperationClaim, bool>> Id);
        void AddClaim(UserOperationClaim user);
        void DeleteClaim(UserOperationClaim user);
    }
}
