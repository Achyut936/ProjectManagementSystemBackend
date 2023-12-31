﻿using DomainLayer.Data;
using DomainLayer.Model;
using Microsoft.EntityFrameworkCore;
using RepositoryLayer.IRepo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryLayer.Repo
{
    public class TableProjectsRepo<T> : ITableProjectsRepo<T> where T : TableProjects
    {
        #region property
        private readonly ApplicationDbContext _applicationDbContext;
        private DbSet<T> entities;
        #endregion
        #region Constructor
        public TableProjectsRepo(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
            entities = _applicationDbContext.Set<T>();
        }
        #endregion

        public T Get(int Id)
        {
            return entities.SingleOrDefault(c => c.ProjectId == Id);
        }
        public IEnumerable<T> GetAll()
        {
            return entities.AsEnumerable();
        }

        public IEnumerable<string> GetAllProjectNames()
        {
            return entities.Select(c => c.projectName).ToList();
        }


        public IEnumerable<T> GetProjectsByMonth(int month)
        {
            return entities.Where(p => p.StartDate.Month == month || p.EndDate.Month == month).ToList();
        }
       
    }
}
