﻿using Business.Abstract;
using Business.BusinessAspects.Autofac;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using CORE.Aspects.Autofac.Validation;
using CORE.Entities.Concrete;
using CORE.Utilities;
using DataAccess.Abstract;
using System;
using System.Collections.Generic;
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
            return new SuccessResult();

        }

        public IResult Delete(User entity)
        {
            userDal.Delete(entity);
            return new SuccessResult();
        }

        [SecuredOperation("admin")]
        public IDataResult<List<User>> GetAll()
        {
            return new SuccessDataResult<List<User>>(userDal.GetAll(), Messages.UsersGetted);
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

        public IResult Update(User entity)
        {
            userDal.Update(entity);
            return new SuccessResult();
        }
    }
}
