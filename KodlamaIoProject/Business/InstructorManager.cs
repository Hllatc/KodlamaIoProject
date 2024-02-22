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
    public class InstructorManager
    {
        //dependency injection
        private readonly IInstructorDal _instructorDal;

        public InstructorManager(IInstructorDal instructorDal)
        {
            _instructorDal = instructorDal;
        }

        public List<Instructor> getAll()
        {
            return _instructorDal.getAll();
        }
        public void Add(Instructor instructor)
        {
            _instructorDal.Add(instructor);
        }
        public void Update(Instructor instructor)
        {
            _instructorDal.Update(instructor);
        }
        public void Remove(Instructor instructor)
        {
            _instructorDal.Remove(instructor);
        }
    }
}
