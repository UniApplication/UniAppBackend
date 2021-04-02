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
    public class CityManager : ICityService

    {
        ICityDal _cityDal;

        public CityManager(ICityDal cityDal)
        {
            _cityDal = cityDal;
        }
        public IResult Add(City entity)
        {
            _cityDal.Add(entity);
            return new SuccessResult(Messages.CityAdd);
        }

        public IResult Delete(City entity)
        {
            _cityDal.Delete(entity);
            return new SuccessResult(Messages.CityDeleted);
        }

        public IDataResult<List<City>> GetAll()
        {
            return new SuccessDataResult<List<City>>(_cityDal.GetAll(),Messages.CitiesListed);
        }

        public IDataResult<City> GetById(int Id)
        {
            return new SuccessDataResult<City>(_cityDal.Get(c=>c.Id==Id),Messages.CityListed);
        }

        public IResult Update(City entity)
        {
            _cityDal.Update(entity);
            return new SuccessResult(Messages.CityUpdated);
        }
    }
}
