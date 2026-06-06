using Microsoft.AspNetCore.Mvc;

namespace employee_management_aks.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EmployeeController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(new
            {
                Message = "Employee API Running from AKS",
                Environment = "Development"
            });
        }
    }
}