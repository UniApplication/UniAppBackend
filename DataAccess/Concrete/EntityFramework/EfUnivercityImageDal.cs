﻿using CORE.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
   public class EfUnivercityImageDal: EfEntityRepositoryBase<UnivercityImage, UniAppContext>, IUnivercityImageDal
    {
    }
}
