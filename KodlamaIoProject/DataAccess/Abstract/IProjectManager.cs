using KodlamaIoProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaIoProject.DataAccess.Abstract
{
    public interface IProjectManager
    {
        //List<> getAll();
        void Add();
        void Update();
        void Remove();
    }
}
