using Mediator;
using MediatorSGSample.Requests;
using Microsoft.AspNetCore.Http;

namespace MediatorSGSample.Handlers;

public sealed class ExampleRequestHandler : IRequestHandler<ExampleRequest, IResult>
{
    // public ExampleRequestHandler()
    // {  }
    
    public async ValueTask<IResult> Handle(ExampleRequest request, CancellationToken cancellationToken)
    {
        Task.Delay(1, cancellationToken);

        return Results.Ok(new
        {
            Massage = $"name is {request.Name}, age is {request.Age}",
            RequetsId = Guid.NewGuid(),
            RandomGuid = Guid.NewGuid()
        });
    }
}