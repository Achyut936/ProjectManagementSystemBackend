using DomainLayer.Data;
using DomainLayer.Model;
using Microsoft.AspNetCore.Mvc;
using ServiceLayer.IService;

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
        [HttpPost(nameof(CreateProject))]
        public IActionResult CreateProject(TableProjects tableprojects)
        {
            if (tableprojects != null)
            {
                _customService.Insert(tableprojects);
                return Ok("Created Successfully");
            }
            else
            {
                return BadRequest("Somethingwent wrong");
            }
        }

        [HttpPost(nameof(UpdateProject))]
        public IActionResult UpdateProject(TableProjects tableprojects)
        {
            if (tableprojects != null)
            {
                _customService.Update(tableprojects);
                return Ok("Updated SuccessFully");
            }
            else
            {
                return BadRequest();
            }
        }

        [HttpDelete("Delete/{id}")]
        public IActionResult Delete(string id)
        {
            var tableprojects = _customService.Delete(id);
            return Ok(tableprojects);
        }
    }
}
