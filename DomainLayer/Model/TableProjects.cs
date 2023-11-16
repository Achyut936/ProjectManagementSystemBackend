using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer.Model
{
    public class TableProjects
    {
        [Key]
        public int ProjectId
        {
            get;
            set;
        }
        public string projectName
        {
            get;
            set;
        }
        public string Client
        {
            get;
            set;
        }
        public DateTime StartDate
        {
            get;
            set;
        }
        public DateTime EndDate
        {
            get;
            set;
        }
        public string Country
        {
            get;
            set;
        }
        public int Budget
        {
            get;
            set;
        }
        public string Status
        {
            get;
            set;
        }
    }
}
