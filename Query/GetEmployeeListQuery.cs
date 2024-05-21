using CQRSPattern.Models;
using MediatR;

namespace CQRSPattern.Query
{
    public class GetEmployeeListQuery: IRequest<List<Employee>>
    {

    }
}
