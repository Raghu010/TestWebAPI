using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SdaemonAPIProject.Data;
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

        //[HttpGet]
        //public CreateEF GetSingleData(int Id)
        //{
        //    return context.creates.Find(Id);
        //}
    }
}
