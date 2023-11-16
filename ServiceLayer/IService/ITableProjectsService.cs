using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.IService
{
    public interface ITableProjectsService<T> where T : class
    {

        IEnumerable<T> GetAll();
        T Get(int Id);
        //IEnumerable<string> GetAllProjectNames();
        IEnumerable<(int ProjectId, string ProjectName)> GetAllProjectNames();
        IEnumerable<T> GetProjectsByMonth(int month);
        //T GetProjectDetails(int projectId);
        //void Insert(T entity);
        //void Update(T entity);
        //bool Delete(string Id);
    }
}
