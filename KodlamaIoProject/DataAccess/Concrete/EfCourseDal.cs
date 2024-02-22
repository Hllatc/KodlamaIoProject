using KodlamaIoProject.DataAccess.Abstract;
using KodlamaIoProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaIoProject.DataAccess.Concrete
{
    public class EfCourseDal : ICourseDal
    {
        List<Course> courses;
        public EfCourseDal()
        {
            Course course1 = new Course();
            course1.Id = 1;
            course1.InstructorId = 1;
            course1.CourseName = "Yazılım Geliştirici Yetiştirme Kampı (JavaScript)";
            course1.Description = "Eğitim";

            Course course2 = new Course();
            course2.Id = 2;
            course2.InstructorId = 1;
            course2.CourseName = "Yazılım Geliştirici Yetiştirme Kampı (C# + ANGULAR)";
            course2.Description = "Eğitim";


            Course course3 = new Course();
            course3.Id = 3;
            course3.InstructorId = 2;
            course3.CourseName = "(2022) Yazılım Geliştirici Yetiştirme Kampı - JAVA";
            course3.Description = "Eğitim";

            courses = new List<Course> { course1, course2, course3 };
        }
        public void Add(Course course)
        {
            courses.Add(course);
            Console.WriteLine("Course eklendi.");
        }

        public List<Course> getAll()
        {
            return courses;
        }

        public void Remove(Course course)
        {
            courses.Remove(course);
            Console.WriteLine("Course silindi.");
        }

        public void Update(Course course)
        {
            Console.WriteLine("Course güncellendi.");
        }
    }
}
