using Business.Abstract;
using CORE.Aspects.Autofac.Caching;
using CORE.Utilities;
using CORE.Utilities.BusinessRules;
using CORE.Utilities.FileHelper;
using DataAccess.Abstract;
using Entity.Concrete;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class UnivercityImageManager : IUnivercityImageService

    {

        IUnivercityImageDal _univercityImageDal;

        public UnivercityImageManager(IUnivercityImageDal univercityImageDal)
        {
            _univercityImageDal = univercityImageDal;
        }
        [CacheRemoveAspect("IUnivercityService.Get")]
        public IResult Add(IFormFile file,UnivercityImage univercityImage)

        {

                IResult result = BusinessRules.Run(CheckIfUnivercityHaveMoreThan1Images(univercityImage.UnivercityId),
                    DeleteIfUnivercityHaveImage(univercityImage.UnivercityId));


                if (result != null)
                {
                    return result;
                }

                univercityImage.ImagePath = Filehelper.AddAsync(file);
                _univercityImageDal.Add(univercityImage);
                return new SuccessResult();
            

        }
        public IDataResult<List<UnivercityImage>> GetAll()
        {

            return new SuccessDataResult<List<UnivercityImage>>(_univercityImageDal.GetAll(), "Hepsi geldi");
        }
        public IDataResult<UnivercityImage> GetByUnivercityId(int univercityId)
        {
            return new SuccessDataResult<UnivercityImage>(_univercityImageDal.Get(p => p.UnivercityId==univercityId), "Unilerin Resimleri Getirildi");
        }

        private IResult CheckIfUnivercityHaveMoreThan1Images(int image)
         {
        var result = _univercityImageDal.GetAll(p => p.UnivercityId== image).Count;
        if (result > 1)
        {
            return new ErrorResult();
        }
        return new SuccessResult();
         }

        private IResult DeleteIfUnivercityHaveImage(int univercityId)
        {
            var resultImage = _univercityImageDal.Get(u => u.UnivercityId == univercityId);
            if (resultImage != null)
            {

                _univercityImageDal.Delete(resultImage);

            }
            return new SuccessResult("Default resim silindi");
           
        }
    }
   
}
