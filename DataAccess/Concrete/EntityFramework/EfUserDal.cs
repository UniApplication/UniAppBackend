using CORE.DataAccess.EntityFramework;
using CORE.Entities.Concrete;
using DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using Entity.DTOs;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfUserDal: EfEntityRepositoryBase<User, UniAppContext>, IUserDal
    {
        public void AddClaim(UserOperationClaim user)
        {
            using (var context = new UniAppContext())
            {
                var addClaim = context.Entry(user);
                addClaim.State = EntityState.Added;
                context.SaveChanges();
            }
        }

        public void DeleteClaim(UserOperationClaim user)
        {
            var userClaim = GetClaimById(u=>u.Id==user.Id);
          
            using (var context = new UniAppContext())
            {
                var deleteClaim = context.Entry(user);
                deleteClaim.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public List<OperationClaim> GetAllClaims()
        {
                using (var context = new UniAppContext())
                {
                return context.Set<OperationClaim>().ToList();
                        
                }
           
        }
        public UserOperationClaim GetClaimById(Expression<Func<UserOperationClaim, bool>> Id)
        {
            
                using (var context = new UniAppContext())
                {
                    return context.Set<UserOperationClaim>().SingleOrDefault(Id);
                }
            
        }
        public List<OperationClaim> GetClaims(int userId)
        {
            using (var context = new UniAppContext())
            {
                var result = from operationClaim in context.OperationClaims
                             join userOperationClaim in context.UserOperationClaims
                             on operationClaim.Id equals userOperationClaim.OperationClaimId
                             where userOperationClaim.UserId == userId
                             select new OperationClaim() { Id = operationClaim.Id, Name = operationClaim.Name };
                return result.ToList();
            }
        }

        public List<UserOperationClaimsDto> GetClaimsByUserId(int userId)
        {
            using (var context = new UniAppContext())
            {
                var result = from userOperationClaim in context.UserOperationClaims
                             join operationClaim in context.OperationClaims
                             on userOperationClaim.OperationClaimId equals operationClaim.Id
                             where userOperationClaim.UserId == userId
                             select new UserOperationClaimsDto() { Id=userOperationClaim.Id,claimName=operationClaim.Name,userId=userOperationClaim.UserId };
                return result.ToList();
            }
        }
    }
}
