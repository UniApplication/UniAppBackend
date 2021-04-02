using Business.Abstract;
using Business.Constants;
using CORE.Utilities;
using DataAccess.Abstract;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class UserFollowManager : IUserFollowService
    {
        IUserFollowDal _userfollowDal;
        public UserFollowManager(IUserFollowDal userFollowDal)
        {
            _userfollowDal = userFollowDal;
        }
        public IResult Add(UserFollow entity)
        {
            _userfollowDal.Add(entity);
            return new SuccessResult(Messages.Userfollowadded);
        }

        public IResult Delete(UserFollow entity)
        {
            _userfollowDal.Delete(entity);
            return new SuccessResult(Messages.UserfollowDeleted);
        }

        public IDataResult<List<UserFollow>> GetAll()
        {
            return new SuccessDataResult<List<UserFollow>>(_userfollowDal.GetAll(), Messages.UserFollowsListed);
        }

        public IDataResult<UserFollow> GetById(int Id)
        {
            return new SuccessDataResult<UserFollow>(_userfollowDal.Get(u=>u.Id==Id), Messages.UserFollowGetted);
        }

        public IResult Update(UserFollow entity)
        {
            _userfollowDal.Update(entity);
            return new SuccessResult(Messages.UserFollowUpdated);
        }
    }
}
