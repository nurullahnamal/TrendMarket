using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrendMarket.BusinessLayer.Abstract;
using TrendMarket.EntityLayer.Concrete;

namespace TrendMarket.BusinessLayer.Concrete
{
    public class ReviewManager : IReviewService
    {
        private readonly IReviewService _reviewService;
        public void TDelete(int id)
        {
           _reviewService.TDelete(id);
        }

        public List<Review> TGetAll()
        {
           return _reviewService.TGetAll();
        }

        public Review TGetById(int id)
        {
           return  _reviewService.TGetById(id);
        }

        public void TInsert(Review entity)
        {
           _reviewService.TInsert(entity);
        }

        public void TUpdate(Review entity)
        {
           _reviewService.TUpdate(entity);
        }
    }
}
