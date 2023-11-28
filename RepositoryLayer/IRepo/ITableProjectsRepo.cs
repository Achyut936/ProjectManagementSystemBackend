using DomainLayer.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryLayer.IRepo
{
    public interface ITableProjectsRepo<T> where T : TableProjects
    {

        IEnumerable<T> GetAll();
        IEnumerable<string> GetAllProjectNames();   
        T Get(int Id);
        IEnumerable<T> GetProjectsByMonth(int month);
       
    }
}
