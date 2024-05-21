using CQRSPattern.Models;
using MediatR;

namespace CQRSPattern.Command
{
    public class AddEmployeeCommand:IRequest<Employee>
    {
        public AddEmployeeCommand(string name,string address, string email, string phone)
        {
            Name = name;
            Address = address;  
            Email = email;
            Phone = phone;
        }

        public string Name { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
    }
}
