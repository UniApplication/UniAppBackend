using CORE.Utilities;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICommentService:IBaseBusinessService<Comment>
    {
        IDataResult<List<Comment>> GetCommentByUnivercityId(int univercityId);
    }
}
