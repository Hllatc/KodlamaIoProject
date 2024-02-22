using KodlamaIoProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaIoProject.DataAccess.Abstract
{
    public interface ICategoryDal
    {
        List<Category> getAll();
        void Add(Category category);
        void Update(Category category);
        void Remove(Category category);
    }
}
