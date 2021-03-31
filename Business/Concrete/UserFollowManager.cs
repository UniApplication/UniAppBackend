using Business.Abstract;
using CORE.Utilities;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class UserFollowManager : IUserFollowService
    {
        public IResult Add(UserFollow entity)
        {
            throw new NotImplementedException();
        }

        public IResult Delete(UserFollow entity)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<UserFollow>> GetAll()
        {
            throw new NotImplementedException();
        }

        public IDataResult<UserFollow> GetById(int Id)
        {
            throw new NotImplementedException();
        }

        public IResult Update(UserFollow entity)
        {
            throw new NotImplementedException();
        }
    }
}
