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


        public IEnumerable<TableProjects> GetProjectsByMonth(int month)
        {
            try
            {
                var projects = _tableprojectsRepository.GetProjectsByMonth(month);

                if (projects != null)
                {
                    return projects;
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

       

        public IEnumerable<(int ProjectId, string ProjectName)> GetAllProjectNames()
        {
            try
            {
                var projects = _tableprojectsRepository.GetAll();

                if (projects != null)
                {
                    
                    return projects.Select(p => (p.ProjectId, p.projectName)).ToList();
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


      

    }

    }

