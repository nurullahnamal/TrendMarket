﻿using System;
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
        public EfProductDal(TrendMarketContext trendMarketContext) : base(trendMarketContext)
        {
        }
    }
}
