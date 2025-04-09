using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SdaemonAPIProject.Data;
using SdaemonAPIProject.Model;
using SdaemonAPIProject.Model.Entities;

namespace SdaemonAPIProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProjectController : ControllerBase
    {
        private readonly AppDBContext context;
        public ProjectController(AppDBContext context)
        {
            this.context = context;
        }

        [HttpGet]
        public IActionResult GetAllData()
        {
            var allData = context.creates.ToList();
            return Ok(allData);
        }
        [HttpPost]
        public IActionResult AddData(CreateEFAddDto create)
        {
            var createEntity = new CreateEF
            {
                Title = create.Title, 
                Description = create.Description,
                DueDate = create.DueDate, 
                IsComplete = create.IsComplete
            };

            context.creates.Add(createEntity);
            context.SaveChanges();
            return StatusCode(201, createEntity);
        }
    }
}
