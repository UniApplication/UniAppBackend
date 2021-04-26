using CORE.DataAccess.EntityFramework;
using CORE.Entities.Concrete;
using DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Microsoft.EntityFrameworkCore;

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

        public List<OperationClaim> GetAllClaims()
        {
                using (var context = new UniAppContext())
                {
                return context.Set<OperationClaim>().ToList();
                        
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

    }
}
