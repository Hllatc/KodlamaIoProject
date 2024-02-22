using KodlamaIoProject.DataAccess.Abstract;
using KodlamaIoProject.DataAccess.Concrete;
using KodlamaIoProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaIoProject.Business
{
    public class CourseManager
    {
        //dependency injection
        private readonly ICourseDal _courseDal;

        public CourseManager(ICourseDal courseDal)
        {
            _courseDal = courseDal;
        }

        public List<Course> getAll()
        {
            return _courseDal.getAll();
        }
        public void Add(Course course)
        {
            _courseDal.Add(course);
        }
        public void Update(Course course)
        {
            _courseDal.Update(course);
        }
        public void Remove(Course course)
        {
            _courseDal.Remove(course);
        }
    }
}
