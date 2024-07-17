using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrendMarket.BusinessLayer.Abstract;
using TrendMarket.EntityLayer.Concrete;

namespace TrendMarket.BusinessLayer.Concrete
{
    public class ProductManager : IProductService
    {
        private readonly IProductService _productService;
        public void TDelete(int id)
        {
           _productService.TDelete(id); 
        }

        public List<Product> TGetAll()
        {
          return  _productService.TGetAll();
        }

        public Product TGetById(int id)
        {
            return _productService.TGetById(id);
        }

        public void TInsert(Product entity)
        {
           _productService.TInsert(entity);
        }

        public void TUpdate(Product entity)
        {
            _productService.TUpdate(entity);
        }
    }
}
