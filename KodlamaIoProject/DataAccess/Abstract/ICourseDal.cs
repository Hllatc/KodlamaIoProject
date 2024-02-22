using KodlamaIoProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaIoProject.DataAccess.Abstract
{
    public interface ICourseDal
    {
        List<Course> getAll();
        void Add(Course course);
        void Update(Course course);
        void Remove(Course course);
    }
}
