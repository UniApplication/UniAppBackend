using CORE.Utilities;
using Entity.Concrete;
using Entity.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IUnivercityService : IBaseBusinessService<Univercity>
    {
        IDataResult<List<UnivercityDetailDto>> GetAllDetail();
        IDataResult<UnivercityDetailDto> GetUnivercityDetailById(int uniId);
    }
}
