using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrendMarket.BusinessLayer.Abstract;
using TrendMarket.EntityLayer.Concrete;

namespace TrendMarket.BusinessLayer.Concrete
{
    public class SocialMediaManager : ISocialMediaService
    {
        private readonly ISocialMediaService socialMediaService;
        public void TDelete(int id)
        {
            socialMediaService.TDelete(id);
        }

        public List<SocialMedia> TGetAll()
        {
            return socialMediaService.TGetAll();
        }

        public SocialMedia TGetById(int id)
        {
            return socialMediaService.TGetById(id); 
        }

        public void TInsert(SocialMedia entity)
        {
            socialMediaService.TInsert(entity);
        }

        public void TUpdate(SocialMedia entity)
        {
            socialMediaService.TUpdate(entity);

        }
    }
}
