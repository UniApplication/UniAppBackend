using CORE.DataAccess;
using Entity.Concrete;
using Entity.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    public interface IUnivercityDal: IEntityRepository<Univercity>
    {
        List<UnivercityDetailDto> GetAllDetails();
        UnivercityDetailDto GetDetailById(int univercityId);
    }
}
