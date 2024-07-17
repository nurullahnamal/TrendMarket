using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrendMarket.BusinessLayer.Abstract;
using TrendMarket.EntityLayer.Concrete;

namespace TrendMarket.BusinessLayer.Concrete
{
    public class CategoryManager : ICategoryService
    {
        private readonly ICategoryService _categoryService;

        public CategoryManager(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        public void TDelete(int id)
        {
           _categoryService.TDelete(id);
        }

        public List<Category> TGetAll()
        {
            return _categoryService.TGetAll();
        }

        public Category TGetById(int id)
        {
            return _categoryService.TGetById(id);
        }

        public void TInsert(Category entity)
        {
           _categoryService.TInsert(entity);
        }

        public void TUpdate(Category entity)
        {
            _categoryService.TUpdate(entity);
        }
    }
}
