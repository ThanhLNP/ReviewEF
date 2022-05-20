using Microsoft.AspNetCore.Mvc;
using ReviewEF.Domains.Entities;
using ReviewEF.Services.Employees;

namespace ReviewEF.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EmployeesController : ControllerBase
    {
        private readonly IEmployeesService _employeesService;
        private readonly ILogger<EmployeesController> _logger;

        public EmployeesController(ILogger<EmployeesController> logger, IEmployeesService employeesService)
        {
            _employeesService = employeesService;
            _logger = logger;
        }

        [HttpGet("")]
        public async Task<ActionResult<Employee>> GetAll([FromQuery] GetAllEmployeesQuery query)
        {
            var response = await _employeesService.GetAll(query);

            return Ok(response);
        }

        [HttpGet("detail/{id}")]
        public async Task<ActionResult<Employee>> GetDetail(long id)
        {
            var response = await _employeesService.GetDetail(id);

            return Ok(response);
        }

        [HttpPost("")]
        public async Task<ActionResult> Post([FromBody] PostEmployeesBody body)
        {
            await _employeesService.Post(body);

            return Created("Employees", body);
        }
    }
}
