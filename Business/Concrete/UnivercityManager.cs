using Business.Abstract;
using Business.BusinessAspects.Autofac;
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
    public class UnivercityManager : IUnivercityService
    {
        IUnivercityDal _univercityDal;
        public UnivercityManager(IUnivercityDal univercityDal)
        {
            _univercityDal = univercityDal;
        }
        [SecuredOperation("admin")]
        public IResult Add(Univercity entity)
        {
            _univercityDal.Add(entity);
            return new SuccessResult(Messages.Univercityadded);
        }
        [SecuredOperation("admin")]
        public IResult Delete(Univercity entity)
        {
            _univercityDal.Delete(entity);
            return new SuccessResult(Messages.UnivercityDeleted);
        }

        public IDataResult<List<Univercity>> GetAll()
        {
            return new SuccessDataResult<List<Univercity>>(_univercityDal.GetAll(), Messages.UnivercitysListed);
        }

        public IDataResult<List<UnivercityDetailDto>> GetAllDetail()
        {
            return new SuccessDataResult<List<UnivercityDetailDto>>(_univercityDal.GetAllDetails(), Messages.UnivercityGetted);
        }

        public IDataResult<Univercity> GetById(int Id)
        {
            return new SuccessDataResult<Univercity>(_univercityDal.Get(u=>u.Id==Id), Messages.UnivercityGetted);
        }

        public IDataResult<List<UnivercityDetailDto>> GetDetailByCity(int cityId)
        {
            return new SuccessDataResult<List<UnivercityDetailDto>>(_univercityDal.GetDetailByCityId(cityId),Messages.UnivercitysListed);
        }

        public IDataResult<UnivercityDetailDto> GetUnivercityDetailById(int uniId)
        {
            return new SuccessDataResult<UnivercityDetailDto>(_univercityDal.GetDetailById(uniId), Messages.UnivercityGetted);
        }
        [SecuredOperation("admin")]
        public IResult Update(Univercity entity)
        {
            _univercityDal.Update(entity);
            return new SuccessResult(Messages.UnivercityUpdated);
        }
    }
}
