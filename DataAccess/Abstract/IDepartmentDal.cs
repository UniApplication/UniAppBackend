﻿using CORE.DataAccess;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    public interface IDepartmentDal: IEntityRepository<Department>
    {
    }
}
