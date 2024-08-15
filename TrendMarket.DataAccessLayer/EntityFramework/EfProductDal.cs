using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrendMarket.DataAccessLayer.Abstract;
using TrendMarket.DataAccessLayer.Context;
using TrendMarket.DataAccessLayer.Repositories;
using TrendMarket.EntityLayer.Concrete;

namespace TrendMarket.DataAccessLayer.EntityFramework
{
    public class EfProductDal : GenericRepository<Product>, IProductDal
    {
        private readonly TrendMarketContext _context;
        public EfProductDal(TrendMarketContext trendMarketContext) : base(trendMarketContext)
        {
            _context= trendMarketContext;
        }

        public List<Product> ProductListWithCategory()
        {
            var values = _context.Products.Include(p => p.Category).ToList();
            return values;
        }
    }
}
