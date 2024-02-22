using KodlamaIoProject.DataAccess.Abstract;
using KodlamaIoProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaIoProject.DataAccess.Concrete
{
    public class EfInstructorDal : IInstructorDal
    {
        List<Instructor> instructors;
        public EfInstructorDal()
        {
            Instructor instructor1 = new Instructor();
            instructor1.Id = 1;
            instructor1.FirstName = "Engin";
            instructor1.LastName = "Demiroğ";

            Instructor instructor2 = new Instructor();
            instructor2.Id = 2;
            instructor2.FirstName = "Halit Enes";
            instructor2.LastName = "Kalaycı";

            instructors = new List<Instructor> { instructor1, instructor2 };
        }
        public void Add(Instructor instructor)
        {
            Console.WriteLine("Eğitmen eklendi.");
            instructors.Add(instructor);
        }

        public List<Instructor> getAll()
        {
            return instructors;
        }

        public void Remove(Instructor instructor)
        {
            Console.WriteLine("Eğitmen silindi.");
        }

        public void Update(Instructor instructor)
        {
            Console.WriteLine("Eğitmen güncellendi.");
        }
    }
}
