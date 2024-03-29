﻿using Business.Abstract;
using Business.BusinessAspects.Autofac;
using Business.Constants;
using CORE.Aspects.Autofac.Caching;
using CORE.Utilities;
using DataAccess.Abstract;
using Entity.Concrete;
using Entity.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class PostManager : IPostService
    {
        IPostDal _postDal;
        public PostManager(IPostDal postDal)
        {
            _postDal = postDal;
        }
        [SecuredOperation("univercity")]
        [CacheRemoveAspect("IPostService.Get")]
        public IResult Add(Post entity)
        {
            _postDal.Add(entity);
            return new SuccessResult(Messages.Postadded);
        }

        [SecuredOperation("admin,univercity")]
        [CacheRemoveAspect("IPostService.Get")]
        public IResult Delete(Post entity)
        {
            _postDal.Delete(entity);
            return new SuccessResult(Messages.PostDeleted);
        }



        public IDataResult<List<Post>> GetAll()
        {
            return new SuccessDataResult<List<Post>>(_postDal.GetAll(), Messages.PostsListed);
        }

        [CacheAspect]
        public IDataResult<List<PostDetail>> GetAllDetail()
        {
            return new SuccessDataResult<List<PostDetail>>(_postDal.GetAllDetail(), Messages.PostsListed);
        }

        public IDataResult<Post> GetById(int Id)
        {
            return new SuccessDataResult<Post>(_postDal.Get(p=>p.Id==Id), Messages.PostGot);
        }

        public IResult Update(Post entity)
        {
            _postDal.Update(entity);
            return new SuccessResult(Messages.PostUpdated);
        }
    }
}
