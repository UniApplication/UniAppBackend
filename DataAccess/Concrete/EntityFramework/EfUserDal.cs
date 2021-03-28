using CORE.DataAccess.EntityFramework;
using CORE.Entities.Concrete;
using DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfUserDal: EfEntityRepositoryBase<User, UniAppContext>, IUserDal
    {
    }
}
