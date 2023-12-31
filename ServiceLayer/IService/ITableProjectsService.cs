﻿using System;
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
        
        IEnumerable<(int ProjectId, string ProjectName)> GetAllProjectNames();
        IEnumerable<T> GetProjectsByMonth(int month);
       
    }
}
