using KodlamaIoProject.DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaIoProject.Business
{
    public class ProjectManager
    {
        private readonly IProjectManager _projectManager;
        public ProjectManager(IProjectManager projectmanager)
        {
            _projectManager = projectmanager;
        }

        public ProjectManager()
        {
        }
        public void Add()
        {
           _projectManager.Add();
        }
        public void Update()
        {
            _projectManager.Update();
        }
        public void Remove()
        {
            _projectManager.Remove();
        }
    }

   
}
