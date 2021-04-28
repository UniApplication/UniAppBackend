using CORE.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entity.Concrete;
using Entity.DTOs;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCommentDal : EfEntityRepositoryBase<Comment, UniAppContext>, ICommentDal
    {
        public List<CommentDetailDto> GetAllDetailById(int univercityId)
        {
            using (UniAppContext univercityContext = new UniAppContext())
            {
                var result = from c in univercityContext.Comments
                             join u in univercityContext.Users
                             on
                             c.UserId equals u.Id
                             join uni in univercityContext.Univercities
                             on
                             c.UnivercityId equals uni.Id
                             where c.UnivercityId == univercityId
                             select new CommentDetailDto
                             {
                                 Id = c.Id,
                                 Entry = c.Entry,
                                 UnivercityName = uni.UnivercityName,
                                 UserName = u.FirstName + " " + u.LastName,
                             };


                return result.ToList();
            }
        }
    }
}
