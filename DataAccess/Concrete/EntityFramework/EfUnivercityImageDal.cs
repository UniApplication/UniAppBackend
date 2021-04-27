using CORE.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfUnivercityImageDal : EfEntityRepositoryBase<UnivercityImage, UniAppContext>, IUnivercityImageDal
    {
        public bool checkIfImageExist(int uniId)
        {
            using (var context = new UniAppContext())
            {
                var result = from image in context.univercityImages
                             where image.UnivercityId == uniId 
                             select image;

                return result.Any();
            }
        }
    }
}
