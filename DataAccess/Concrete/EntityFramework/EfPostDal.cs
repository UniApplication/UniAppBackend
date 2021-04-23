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
    public class EfPostDal : EfEntityRepositoryBase<Post, UniAppContext>, IPostDal
    {
        public List<PostDetail> GetAllDetail()
        {
            using (UniAppContext univercityContext = new UniAppContext())
            {
                var result = from p in univercityContext.Posts
                             join u in univercityContext.Users
                             on p.UniId equals u.Id
                             orderby p.Id descending
                             select new PostDetail
                             {
                                 Id=p.Id,
                                 UniName=u.FirstName+" "+u.LastName,
                                 UniPost=p.UniPost

                             };

                return result.ToList();
            }
        }
    }
    }

