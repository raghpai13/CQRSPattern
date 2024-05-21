using CQRSPattern.Command;
using CQRSPattern.Models;
using CQRSPattern.Services;
using MediatR;

namespace CQRSPattern.Handlers
{
    public class UpdateEmployeeHandler : IRequestHandler<UpdateEmployeeCommand, int>
    {
        private IEmployeeRepository _employeeRepository;
        public UpdateEmployeeHandler(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }
        public async Task<int> Handle(UpdateEmployeeCommand request, CancellationToken cancellationToken)
        {
            var emp = await _employeeRepository.GetEmployeeByIdAsync(request.Id);
            if (emp == null)
                return default;
            Employee employee = new Employee()
            {
               
                Name = request.Name,
                Address = request.Address,
                Email = request.Email,
                Phone = request.Phone,
            };
            return await _employeeRepository.UpdateEmployeeAsync(employee);
        }
    }
}
