using CQRSPattern.Models;

namespace CQRSPattern.Services
{
    public interface IEmployeeRepository
    {
        public Task<List<Employee>> GetEmployeeListAsync();
        public Task<Employee> GetEmployeeByIdAsync(int Id);
        public Task<Employee> AddEmployeeAsync(Employee employee);
        public Task<int> UpdateEmployeeAsync(Employee employee);
        public Task<int> DeleteEmployeeAsync(int Id);
    }
}
