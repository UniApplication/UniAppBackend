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
    public class EfUnivercityDal : EfEntityRepositoryBase<Univercity, UniAppContext>, IUnivercityDal
    {
        public List<UnivercityDetailDto> GetAllDetails()
        {
            using (UniAppContext univercityContext = new UniAppContext())
            {
                var result = from u in univercityContext.Univercities
                             join c in univercityContext.Cities
                             on
                             u.CityId equals c.Id
                             join i in univercityContext.univercityImages
                             on
                             u.Id equals i.UnivercityId
                             select new UnivercityDetailDto 
                             {
                                 UnivercityId = u.Id,
                                 UnivercityName=u.UnivercityName,
                                 UnivercityDescription=u.UnivercityDescription,
                                 UnivercityRector=u.UnivercityRector,
                                 CityName=c.CityName,
                                 StarCount=u.StarCount,
                                 UnivercityImage=i.ImagePath

                             };

                             
                return result.ToList();
            }
        }
        public List<UnivercityDetailDto> GetDetailByCityId(int cityId)
        {
            using (UniAppContext univercityContext = new UniAppContext())
            {
                var result = from u in univercityContext.Univercities
                             join c in univercityContext.Cities
                             on
                             u.CityId equals c.Id
                             join i in univercityContext.univercityImages
                             on
                             u.Id equals i.UnivercityId
                             where u.CityId==cityId
                             select new UnivercityDetailDto
                             {
                                 UnivercityId = u.Id,
                                 UnivercityName = u.UnivercityName,
                                 UnivercityDescription = u.UnivercityDescription,
                                 UnivercityRector = u.UnivercityRector,
                                 CityName = c.CityName,
                                 StarCount = u.StarCount,
                                 UnivercityImage = i.ImagePath

                             };


                return result.ToList();
            }
        }

        public UnivercityDetailDto GetDetailById(int univercityId)
        {
            using (UniAppContext univercityContext = new UniAppContext())
            {
                var result = from u in univercityContext.Univercities
                             join c in univercityContext.Cities
                             on
                             u.CityId equals c.Id
                             join i in univercityContext.univercityImages
                             on
                             u.Id equals i.UnivercityId
                             where u.Id==univercityId
                             select new UnivercityDetailDto
                             {
                                 UnivercityId = u.Id,
                                 UnivercityName = u.UnivercityName,
                                 UnivercityDescription = u.UnivercityDescription,
                                 UnivercityRector = u.UnivercityRector,
                                 CityName = c.CityName,
                                 StarCount = u.StarCount,
                                 UnivercityImage = i.ImagePath

                             };


                return result.FirstOrDefault();
            }
        }
    }
}
