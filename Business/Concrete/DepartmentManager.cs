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
    public class DepartmentManager : IDepartmentService
    {
        IDepartmentDal _departmentDal;
        public DepartmentManager(IDepartmentDal departmentDal)
        {
            _departmentDal = departmentDal;
        }
        public IResult Add(Department entity)
        {
            _departmentDal.Add(entity);
            return new SuccessResult(Messages.DepartmentAdded);
        }

        public IResult Delete(Department entity)
        {
            _departmentDal.Delete(entity);
            return new SuccessResult(Messages.DepartmentDeleted);
        }

        public IDataResult<List<Department>> GetAll()
        {
            return new SuccessDataResult<List<Department>>(_departmentDal.GetAll(), Messages.DepartmentsListed);
        }

        public IDataResult<Department> GetById(int Id)
        {
            return new SuccessDataResult<Department>(_departmentDal.Get(d => d.Id == Id), Messages.DepartmentGetted);
        }

        public IResult Update(Department entity)
        {
            _departmentDal.Update(entity);
            return new SuccessResult(Messages.DepartmentUpdated);
        }
    }
}
