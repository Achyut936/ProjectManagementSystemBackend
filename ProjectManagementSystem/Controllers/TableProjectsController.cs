using DomainLayer.Data;
using DomainLayer.Model;
using Microsoft.AspNetCore.Mvc;
using ServiceLayer.IService;
using ServiceLayer.Service;

namespace ProjectManagementSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TableProjectsController : Controller
    {

        private readonly ITableProjectsService<TableProjects> _customService;
        private readonly ApplicationDbContext _applicationDbContext;
        public TableProjectsController(ITableProjectsService<TableProjects> TableProjectsService, ApplicationDbContext applicationDbContext)
        {
            _customService = TableProjectsService;
            _applicationDbContext = applicationDbContext;
        }
        [HttpGet(nameof(GetProjectsById))]
        public IActionResult GetProjectsById(int Id)
        {
            var obj = _customService.Get(Id);
            if (obj == null)
            {
                return NotFound();
            }
            else
            {
                return Ok(obj);
            }
        }
        [HttpGet(nameof(GetAllProjects))]
        public IActionResult GetAllProjects()
        {
            var obj = _customService.GetAll();
            if (obj == null)
            {
                return NotFound();
            }
            else
            {
                return Ok(obj);
            }
        }

        [HttpGet(nameof(GetAllProjectNames))]
        public IActionResult GetAllProjectNames()
        {
            var obj = _customService.GetAllProjectNames();
            if (obj == null)
            {
                return NotFound();
            }
            else
            {
                // Modify the response to include both ProjectId and ProjectName
                var response = obj.Select(p => new { ProjectId = p.ProjectId, ProjectName = p.ProjectName });
                return Ok(response);
            }
        }


        [HttpGet("projectsByMonth/{month}")]
        public IActionResult GetProjectsByMonth(int month)
        {
            var projects = _customService.GetProjectsByMonth(month);

            if (projects != null)
            {
                return Ok(projects);
            }
            else
            {
                return NotFound();
            }
        }

    }
}
