using DomainLayer.Model;
using RepositoryLayer.IRepo;
using ServiceLayer.IService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Service
{
    public class TableProjectsService : ITableProjectsService<TableProjects>
    {

        private readonly ITableProjectsRepo<TableProjects> _tableprojectsRepository;
        public TableProjectsService(ITableProjectsRepo<TableProjects> TableProjectsRepo)
        {
            _tableprojectsRepository = TableProjectsRepo;
        }
        public bool Delete(string Id)
        {
            try
            {
                _tableprojectsRepository.Delete(Convert.ToInt32(Id));
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public TableProjects Get(int Id)
        {
            try
            {
                var obj = _tableprojectsRepository.Get(Id);
                if (obj != null)
                {
                    return obj;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        public IEnumerable<TableProjects> GetAll()
        {
            try
            {
                var obj = _tableprojectsRepository.GetAll();
                if (obj != null)
                {
                    return obj;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        public void Insert(TableProjects entity)
        {
            try
            {
                if (entity != null)
                {
                    _tableprojectsRepository.Insert(entity);
                    _tableprojectsRepository.SaveChanges();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void Update(TableProjects entity)
        {
            try
            {
                if (entity != null)
                {
                    _tableprojectsRepository.Update(entity);
                    _tableprojectsRepository.SaveChanges();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}

