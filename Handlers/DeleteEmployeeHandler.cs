using CQRSPattern.Command;
using CQRSPattern.Models;
using CQRSPattern.Services;
using MediatR;

namespace CQRSPattern.Handlers
{
    public class DeleteEmployeeHandler : IRequestHandler<DeleteEmployeeCommand, int>
    {
        private IEmployeeRepository _employeeRepository;
        public DeleteEmployeeHandler(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }
        public async Task<int> Handle(DeleteEmployeeCommand request, CancellationToken cancellationToken)
        {
            var employee =await  _employeeRepository.GetEmployeeByIdAsync(request.Id);
            if (employee == null)
                return default;

            return await _employeeRepository.DeleteEmployeeAsync(request.Id);
        }
    }
}