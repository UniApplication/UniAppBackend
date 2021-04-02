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
    public class UnivercityManager : IUnivercityService
    {
        IUnivercityDal _univercityDal;
        public UnivercityManager(IUnivercityDal univercityDal)
        {
            _univercityDal = univercityDal;
        }
        public IResult Add(Univercity entity)
        {
            _univercityDal.Add(entity);
            return new SuccessResult(Messages.Univercityadded);
        }

        public IResult Delete(Univercity entity)
        {
            _univercityDal.Delete(entity);
            return new SuccessResult(Messages.UnivercityDeleted);
        }

        public IDataResult<List<Univercity>> GetAll()
        {
            return new SuccessDataResult<List<Univercity>>(_univercityDal.GetAll(), Messages.UnivercitysListed);
        }

        public IDataResult<Univercity> GetById(int Id)
        {
            return new SuccessDataResult<Univercity>(_univercityDal.Get(u=>u.Id==Id), Messages.UnivercityGetted);
        }

        public IResult Update(Univercity entity)
        {
            _univercityDal.Update(entity);
            return new SuccessResult(Messages.UnivercityUpdated);
        }
    }
}
