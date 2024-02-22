using KodlamaIoProject.Business;
using KodlamaIoProject.DataAccess.Abstract;
using KodlamaIoProject.DataAccess.Concrete;
using KodlamaIoProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaIoProject
{
    public class Program
    {
        static void Main(string[] args){

            Category category = new Category() { Id=1, CategoryName="Bilgisayar",Description="fregörel"};
            CategoryManager categoryManager = new CategoryManager(new EfCategoryDal()); //yöntemi farklı kullanabiliroyurz. Buna polymorfizm diyoruz.(örn kredi türü hesaplama, tarım, taşıt vb kredi hesaplama yöntemleri farklıdır ve bunları bu şekilde çağırabiliriz.)
            categoryManager.Add(category);

            Instructor instructor = new Instructor() { Id = 3, FirstName = "Hll", LastName = "atc" };

            InstructorManager instructorManager = new InstructorManager(new EfInstructorDal());
            //instructorManager.Add(instructor);
            var liste=instructorManager.getAll();

            foreach(var item in liste)
            {
                Console.WriteLine(item.FirstName);
            }

            CourseManager courseManager=new CourseManager(new EfCourseDal());
            courseManager.getAll().ForEach(item => Console.WriteLine(item.CourseName));



            Console.ReadLine();
        }
    }
}
