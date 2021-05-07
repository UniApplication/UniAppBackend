using Business.Abstract;
using Business.BusinessAspects.Autofac;
using Business.Constants;
using CORE.Aspects.Autofac.Caching;
using CORE.Utilities;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entity.Concrete;
using Entity.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class UnivercityManager : IUnivercityService
    {
        IUnivercityDal _univercityDal;
        public UnivercityManager(IUnivercityDal univercityDal)
        {
            _univercityDal = univercityDal;
        }
        [SecuredOperation("admin")]
        [CacheRemoveAspect("IUnivercityService.Get")]
        public IResult Add(Univercity entity)
        {
            _univercityDal.Add(entity);
            IUnivercityImageDal univercityImageDal = new EfUnivercityImageDal();
            var result = univercityImageDal.checkIfImageExist(entity.Id);
            if (!result)
            {
                UnivercityImage newUniImage = new UnivercityImage
                {
                    UnivercityId = entity.Id,
                    ImagePath = "default.jpg"
                };
                univercityImageDal.Add(newUniImage);
            }
            return new SuccessResult(Messages.Univercityadded);
        }
        [SecuredOperation("admin")]
        [CacheRemoveAspect("IUnivercityService.Get")]
        public IResult Delete(Univercity entity)
        {
            IUnivercityImageDal univercityImageDal = new EfUnivercityImageDal();
            var result = univercityImageDal.checkIfImageExist(entity.Id);
            if (result)
            {
                var image = univercityImageDal.Get(u=>u.UnivercityId==entity.Id);
                univercityImageDal.Delete(image);
            }
            _univercityDal.Delete(entity);
            return new SuccessResult(Messages.UnivercityDeleted);
        }
        [CacheAspect]
        public IDataResult<List<Univercity>> GetAll()
        {
            //List<Univercity> univercities = _univercityDal.GetAll();
            //foreach (var uni in univercities)
            //{
            //    IUnivercityImageDal univercityImageDal = new EfUnivercityImageDal();
            //    var result = univercityImageDal.checkIfImageExist(uni.Id);
            //    if (!result)
            //    {
            //        UnivercityImage newUniImage = new UnivercityImage
            //        {
            //            UnivercityId = uni.Id,
            //            ImagePath = "default.jpg"
            //        };
            //        univercityImageDal.Add(newUniImage);
            //    }
            //}
            return new SuccessDataResult<List<Univercity>>(_univercityDal.GetAll(), Messages.UnivercitysListed);
        }

        [CacheAspect]
        public IDataResult<List<UnivercityDetailDto>> GetAllDetail()
        {
            return new SuccessDataResult<List<UnivercityDetailDto>>(_univercityDal.GetAllDetails(), Messages.UnivercityGetted);
        }
        [CacheAspect]
        public IDataResult<Univercity> GetById(int Id)
        {
            return new SuccessDataResult<Univercity>(_univercityDal.Get(u=>u.Id==Id), Messages.UnivercityGetted);
        }

        [CacheAspect]
        public IDataResult<List<UnivercityDetailDto>> GetDetailByCity(int cityId)
        {
            return new SuccessDataResult<List<UnivercityDetailDto>>(_univercityDal.GetDetailByCityId(cityId),Messages.UnivercitysListed);
        }

        public IDataResult<UnivercityDetailDto> GetUnivercityDetailById(int uniId)
        {
            return new SuccessDataResult<UnivercityDetailDto>(_univercityDal.GetDetailById(uniId), Messages.UnivercityGetted);
        }
        [SecuredOperation("admin")]
        [CacheRemoveAspect("IUnivercityService.Get")]
        public IResult Update(Univercity entity)
        {
            _univercityDal.Update(entity);
            return new SuccessResult(Messages.UnivercityUpdated);
        }
    }
}
