using CORE.Utilities;
using Entity.Concrete;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IUnivercityImageService
    {
        IResult Add(IFormFile file, UnivercityImage univercityImage);
        IDataResult<List<UnivercityImage>> GetAll();
        IDataResult<UnivercityImage> GetByUnivercityId(int univercityId);
    }
}
