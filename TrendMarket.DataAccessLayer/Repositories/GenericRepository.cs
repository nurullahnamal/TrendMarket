using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrendMarket.DataAccessLayer.Abstract;
using TrendMarket.DataAccessLayer.Context;

namespace TrendMarket.DataAccessLayer.Repositories
{
    public class GenericRepository<T> : IGenericDal<T> where T : class
    {

        private readonly TrendMarketContext _trendMarketContext;


        public GenericRepository(TrendMarketContext trendMarketContext)
        {
            _trendMarketContext = trendMarketContext;
        }


        public void Delete(int id)
        {
            var value=_trendMarketContext.Set<T>().Find(id);
            _trendMarketContext.Set<T>().Remove(value);
            _trendMarketContext.SaveChanges();
        }

        public List<T> GetAll()
        {
            return _trendMarketContext.Set<T>().ToList();
        }

        public T GetById(int id)
        {
           return _trendMarketContext.Set<T>().Find(id);

        }

        public void Insert(T entity)
        {
           _trendMarketContext.Set<T>().Add(entity);
            _trendMarketContext.SaveChanges();
        }

        public void Update(T entity)
        {
          
            _trendMarketContext.Set<T>().Update(entity);
            _trendMarketContext.SaveChanges();
        }
    }
}
