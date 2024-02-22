using KodlamaIoProject.DataAccess.Abstract;
using KodlamaIoProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaIoProject.Business
{
    public class CategoryManager
    {
        //dependency injection
        private readonly ICategoryDal _categoryDal;

        public CategoryManager()
        {
        }

        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }

        public List<Category> getAll()
        {
            return _categoryDal.getAll();
        }
        public void Add(Category category)
        {
            _categoryDal.Add(category);
        }
        public void Update(Category category)
        {
            _categoryDal.Update(category);
        }
        public void Remove(Category category)
        {
            _categoryDal.Remove(category);
        }
    }
}
