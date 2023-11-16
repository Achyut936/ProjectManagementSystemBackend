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
        //public bool Delete(string Id)
        //{
        //    try
        //    {
        //        _tableprojectsRepository.Delete(Convert.ToInt32(Id));
        //        return true;
        //    }
        //    catch (Exception ex)
        //    {
        //        return false;
        //    }
        //}
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

        //public IEnumerable<string> GetAllProjectNames()
        //{
        //    try
        //    {
        //        var projects = _tableprojectsRepository.GetAll();

        //        if (projects != null)
        //        {
        //            // Assuming that TableProjects has a property named ProjectName
        //            return projects.Select(p => p.projectName).ToList();
        //        }
        //        else
        //        {
        //            return null;
        //        }
        //    }
        //    catch (Exception)
        //    {
        //        throw;
        //    }
        //}

        //public TableProjects GetProjectDetails(int projectId)
        //{
        //    try
        //    {
        //        var obj = _tableprojectsRepository.GetProjectDetails(projectId);
        //        if (obj != null)
        //        {
        //            return obj;
        //        }
        //        else
        //        {
        //            return null;
        //        }
        //    }
        //    catch (Exception)
        //    {
        //        throw;
        //    }
        //}

        public IEnumerable<(int ProjectId, string ProjectName)> GetAllProjectNames()
        {
            try
            {
                var projects = _tableprojectsRepository.GetAll();

                if (projects != null)
                {
                    // Assuming that TableProjects has properties named ProjectId and ProjectName
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


        #region dead code
        //public void Insert(TableProjects entity)
        //{
        //    try
        //    {
        //        if (entity != null)
        //        {
        //            _tableprojectsRepository.Insert(entity);
        //            _tableprojectsRepository.SaveChanges();
        //        }
        //    }
        //    catch (Exception)
        //    {
        //        throw;
        //    }
        //}

        //public void Update(TableProjects entity)
        //{
        //    try
        //    {
        //        if (entity != null)
        //        {
        //            _tableprojectsRepository.Update(entity);
        //            _tableprojectsRepository.SaveChanges();
        //        }
        //    }
        //    catch (Exception)
        //    {
        //        throw;
        //    }
        //}
        #endregion

    }

    }

