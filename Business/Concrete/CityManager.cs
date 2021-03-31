using Business.Abstract;
using CORE.Utilities;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CityManager : ICityService
    {
        public IResult Add(City entity)
        {
            throw new NotImplementedException();
        }

        public IResult Delete(City entity)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<City>> GetAll()
        {
            throw new NotImplementedException();
        }

        public IDataResult<City> GetById(int Id)
        {
            throw new NotImplementedException();
        }

        public IResult Update(City entity)
        {
            throw new NotImplementedException();
        }
    }
}
