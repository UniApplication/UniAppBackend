using Business.Abstract;
using Business.BusinessAspects.Autofac;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using CORE.Aspects.Autofac.Validation;
using CORE.Entities.Concrete;
using CORE.Utilities;
using CORE.Utilities.BusinessRules;
using DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business.Concrete
{
    public class UserManager : IUserService
    {
        IUserDal userDal;
        public UserManager(IUserDal _userDal)
        {
            userDal = _userDal;
        }

        public IResult Add(User entity)
        {

            userDal.Add(entity);
            return new SuccessResult(Messages.UserAdded);

        }

        public IResult Delete(User entity)
        {
            userDal.Delete(entity);
            return new SuccessResult(Messages.UserDeleted);
        }

        [SecuredOperation("admin")]
        public IDataResult<List<User>> GetAll()
        {
            return new SuccessDataResult<List<User>>(userDal.GetAll(), Messages.UsersGetted);
        }

        public IDataResult<List<OperationClaim>> GetAllClaims()
        {
            return new SuccessDataResult<List<OperationClaim>>(userDal.GetAllClaims(),"Tüm Yetkiler Getirildi");
        }

        public User GetByEmail(string email)
        {
            return userDal.Get(u => u.Email == email);
        }

        public IDataResult<User> GetById(int Id)
        {
            return new SuccessDataResult<User>(userDal.Get(u => u.Id == Id), Messages.UserGot);
        }

        public IDataResult<List<OperationClaim>> GetClaim(int userId)
        {
            return new SuccessDataResult<List<OperationClaim>>(userDal.GetClaims(userId));
        }
        [SecuredOperation("admin")]
        public IResult PostClaim(UserOperationClaim user)
        {
            IResult result = BusinessRules.Run(IfUserAlreadyHaveClaim(user.Id));
            if (result != null)
            {
                return result;
            }
            userDal.AddClaim(user);
            return new SuccessResult(Messages.UserClaimUpdated);
        }

        public IResult Update(User entity)
        {
            userDal.Update(entity);
            return new SuccessResult(Messages.UserUpdated);
        }
        private IResult IfUserAlreadyHaveClaim(int userId)
        {
            var result = GetClaim(userId).Data.Count;
            if (result>3)
            {
                return new ErrorResult("Yetkiler üçten fazla olamaz");
            }
            else
            {
                return new SuccessResult();
            }
            
        }
       
    }
}
