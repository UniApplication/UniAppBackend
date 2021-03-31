using Business.Abstract;
using CORE.Utilities;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CommentManager : ICommentService
    {
        public IResult Add(Comment entity)
        {
            throw new NotImplementedException();
        }

        public IResult Delete(Comment entity)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<Comment>> GetAll()
        {
            throw new NotImplementedException();
        }

        public IDataResult<Comment> GetById(int Id)
        {
            throw new NotImplementedException();
        }

        public IResult Update(Comment entity)
        {
            throw new NotImplementedException();
        }
    }
}
