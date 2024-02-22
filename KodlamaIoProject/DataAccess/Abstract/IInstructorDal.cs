using KodlamaIoProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaIoProject.DataAccess.Abstract
{
    public interface IInstructorDal
    {
        List<Instructor> getAll();
        void Add(Instructor instructor);
        void Update(Instructor instructor);
        void Remove(Instructor instructor);
    }
}
