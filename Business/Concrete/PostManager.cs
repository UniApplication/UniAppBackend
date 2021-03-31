using Business.Abstract;
using CORE.Utilities;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class PostManager : IPostService
    {
        public IResult Add(Post entity)
        {
            throw new NotImplementedException();
        }

        public IResult Delete(Post entity)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<Post>> GetAll()
        {
            throw new NotImplementedException();
        }

        public IDataResult<Post> GetById(int Id)
        {
            throw new NotImplementedException();
        }

        public IResult Update(Post entity)
        {
            throw new NotImplementedException();
        }
    }
}
