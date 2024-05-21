using CQRSPattern.Command;
using CQRSPattern.Data;
using CQRSPattern.Models;
using CQRSPattern.Services;
using MediatR;

namespace CQRSPattern.Handlers
{
    public class AddEmployeeHandler : IRequestHandler<AddEmployeeCommand, Employee>
    {
        private IEmployeeRepository _employeeRepository;
        public AddEmployeeHandler(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }
        public async Task<Employee> Handle(AddEmployeeCommand request, CancellationToken cancellationToken)
        {

            Employee employee = new Employee()
            {
                Name = request.Name,
                Address = request.Address,
                Email = request.Email,
                Phone = request.Phone,
            };
            return await _employeeRepository.AddEmployeeAsync(employee);
        }
    }
}
