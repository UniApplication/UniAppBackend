using Business.Abstract;
using CORE.Utilities;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class DepartmentManager : IDepartmentService
    {
        public IResult Add(Department entity)
        {
            throw new NotImplementedException();
        }

        public IResult Delete(Department entity)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<Department>> GetAll()
        {
            throw new NotImplementedException();
        }

        public IDataResult<Department> GetById(int Id)
        {
            throw new NotImplementedException();
        }

        public IResult Update(Department entity)
        {
            throw new NotImplementedException();
        }
    }
}
