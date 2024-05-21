using CQRSPattern.Models;
using MediatR;

namespace CQRSPattern.Query
{
    public class GetEmployeeByIdQuery:IRequest<Employee>
    {
        public int Id { get; set; } 
    }
}
