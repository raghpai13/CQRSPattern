using CQRSPattern.Command;
using CQRSPattern.Models;
using CQRSPattern.Query;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CQRSPattern.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private IMediator _mediator;
        public EmployeeController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<List<Employee>> GetEmployeeList()
        {
            var employeeList = await _mediator.Send(new GetEmployeeListQuery());
            return employeeList;

        }

        [HttpGet("{id}")]
        public async Task<Employee> GetEmployeeById(int id)
        {
            var employee= await _mediator.Send(new GetEmployeeByIdQuery() { Id=id});
            return employee;

        }

        [HttpPost]
        public async Task<Employee> AddEmployee(Employee employee)
        {
            var result = await _mediator.Send(new AddEmployeeCommand(employee.Name,employee.Address,employee.Email,employee.Phone));
            return result;
        }

        [HttpPut]
        public async Task<int> UpdateEmployee(Employee employee)
        {
            var result = await _mediator.Send(new UpdateEmployeeCommand(employee.Id,employee.Name, employee.Address, employee.Email, employee.Phone));
            return result;
        }

        [HttpDelete("{id}")]
        public async Task<int> DeleteEmployee(int id)
        {
            return await _mediator.Send(new DeleteEmployeeCommand() { Id = id });
           

        }

    }
}
