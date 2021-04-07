﻿using Business.Abstract;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using CORE.Aspects.Autofac.Validation;
using CORE.Utilities;
using DataAccess.Abstract;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CommentManager : ICommentService
    {
        ICommentDal _commentDal;
        public CommentManager(ICommentDal commentDal)
        {
            _commentDal = commentDal;
        }
        [ValidationAspect(typeof(CommentValidator))]
        public IResult Add(Comment entity)
        {
            _commentDal.Add(entity);
            return new SuccessResult(Messages.CommentAdded);
        }

        public IResult Delete(Comment entity)
        {
            _commentDal.Delete(entity);
            return new SuccessResult(Messages.CommentDeleted);
        }

        public IDataResult<List<Comment>> GetAll()
        {

            return new SuccessDataResult<List<Comment>>(_commentDal.GetAll(),Messages.CommentsListed);
        }

        public IDataResult<Comment> GetById(int Id)
        {
            return new SuccessDataResult<Comment>(_commentDal.Get(c=>c.Id==Id),Messages.CommentGetted);
        }

        public IDataResult<List<Comment>> GetCommentByUnivercityId(int univercityId)
        {
            return new SuccessDataResult<List<Comment>>(_commentDal.GetAll(c => c.UnivercityId == univercityId), Messages.CommentGetted);        }

        public IResult Update(Comment entity)
        {
            _commentDal.Update(entity);
            return new SuccessResult(Messages.CommentUpdated);
        }
    }
}
