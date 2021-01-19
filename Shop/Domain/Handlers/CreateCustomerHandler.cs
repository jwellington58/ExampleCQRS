using System;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using Shop.Domain.Commands.Requests;
using Shop.Domain.Commands.Responses;

namespace Shop.Domain.Handlers
{
    public class CreateCustomerHandler : IRequestHandler<CreateCustomerRequest, CreateCustomerResponse>
    {
        Task<CreateCustomerResponse> IRequestHandler<CreateCustomerRequest, CreateCustomerResponse>.Handle(CreateCustomerRequest request, CancellationToken cancellationToken)
        {
            //Regras aqui
            var result = new CreateCustomerResponse(){
                Name = request.Name,
                Email = request.Email,
                Date = DateTime.Now,
                Id = Guid.NewGuid()
            };
            return Task.FromResult(result);
        }
    }
}