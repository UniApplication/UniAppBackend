using CORE.Utilities;
using Entity.Concrete;
using Entity.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
  public interface IPostService:IBaseBusinessService<Post>
    {
        IDataResult<List<PostDetail>> GetAllDetail();
    }
}
