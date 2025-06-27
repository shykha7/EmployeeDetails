using EmployeeDetails.Models;
using EmployeeDetails.Services;
using Microsoft.AspNetCore.Mvc;
namespace EmployeeDetails.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeService _employee;

        public EmployeeController(IEmployeeService employee) 
        { 
            _employee = employee;
        }

        [HttpPost]
        public IActionResult AddEmployee([FromBody] Employee employee)
        {
            var addedEmployee = employee;
            return CreatedAtAction(nameof(AddEmployee), null, addedEmployee);
        }

        [HttpPut("{id}")]
        public IActionResult UpdatedEmployee(int id, [FromBody] Employee employee)
        {
            var updatedemployee = employee;
            return CreatedAtAction(nameof(UpdatedEmployee), new { id = updatedemployee.Id}, updatedemployee);
        }
    }
}
