using KodlamaIoProject.DataAccess.Abstract;
using KodlamaIoProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaIoProject.DataAccess.Concrete
{
    public class EfCategoryDal : ICategoryDal
    {
        List<Category> categories;
        public EfCategoryDal()
        {
            Category category1 = new Category();
            category1.Id = 1;
            category1.CategoryName = "Programlama";
            category1.Description = "Eğitim";

            Category category2 = new Category();
            category1.Id = 1;
            category1.CategoryName = "Veritabanı";
            category1.Description = "Eğitim";


            Category category3 = new Category();
            category1.Id = 1;
            category1.CategoryName = "Tasarım";
            category1.Description = "Eğitim";

            categories = new List<Category> { category1, category2, category3 };
        }
        public void Add(Category category)
        {
            Console.WriteLine("Category eklendi.");
        }

        public List<Category> getAll()
        {
            Console.WriteLine("Category listelendi.");
            return categories;
        }

        public void Remove(Category category)
        {
            Console.WriteLine("Category silindi.");
        }

        public void Update(Category category)
        {
            Console.WriteLine("Category güncellendi.");
        }
    }
}
