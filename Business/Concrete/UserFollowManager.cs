using Business.Abstract;
using Business.Constants;
using CORE.Utilities;
using DataAccess.Abstract;
using Entity.Concrete;
using Entity.DTOs;
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

        public IDataResult<UserFollowModelDto> getUserFollowing(UserFollow userFollow)
        {
          
            return new SuccessDataResult<UserFollowModelDto>(_userfollowDal.getFollow(userFollow),"Kullanıcı Takip ediyor.");
            
           
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

        public IDataResult<List<UsersFollowingUnivercities>> getUsersFollowingUnivercities(int userId)
        {
            return new SuccessDataResult<List<UsersFollowingUnivercities>>(_userfollowDal.getFollowingUnivercities(userId),Messages.UsersFollowingUnivercitiesGetted);
           
        }
    }
}
