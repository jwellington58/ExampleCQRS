using System.Threading.Tasks;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Shop.Domain.Commands.Requests;
using Shop.Domain.Commands.Responses;
using Shop.Domain.Handlers;

namespace Shop.Controllers
{
    [ApiController]
    [Route("api/customers")]
    public class CustomerController : ControllerBase
    {
        [HttpPost]
        [Route("")]
        public Task<CreateCustomerResponse> Create([FromServices] IMediator mediator, 
                                            [FromBody] CreateCustomerRequest command)
        {
            return mediator.Send(command);
        }
    }
}