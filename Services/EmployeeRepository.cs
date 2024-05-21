using CQRSPattern.Data;
using CQRSPattern.Models;
using Microsoft.EntityFrameworkCore;

namespace CQRSPattern.Services
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private EmployeeDbContext _employeeDbContext;
        public EmployeeRepository(EmployeeDbContext employeeDbContext)
        {
            _employeeDbContext = employeeDbContext;
        }
        public async Task<Employee> AddEmployeeAsync(Employee employee)
        {
            var result= _employeeDbContext.Employees.Add(employee);
            await _employeeDbContext.SaveChangesAsync();
            return result.Entity;
        }

        public async Task<int> DeleteEmployeeAsync(int Id)
        {
            var emp = _employeeDbContext.Employees.Where(x=>x.Id == Id).FirstOrDefault();
            _employeeDbContext.Employees.Remove(emp);
            return await _employeeDbContext.SaveChangesAsync();
            
        }

        public async Task<Employee> GetEmployeeByIdAsync(int Id)
        {
            var emp = await _employeeDbContext.Employees.Where(x => x.Id == Id).FirstOrDefaultAsync();
            return emp;
        }

        public async Task<List<Employee>> GetEmployeeListAsync()
        {
            var emp = await _employeeDbContext.Employees.ToListAsync();
            return emp;
        }

        public async Task<int> UpdateEmployeeAsync(Employee employee)
        {
            var result = _employeeDbContext.Employees.Update(employee);
            return await _employeeDbContext.SaveChangesAsync();
     
        }
       

    }
}
