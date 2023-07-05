using Mediator;
using Microsoft.AspNetCore.Http;

namespace MediatorSGSample.Requests;

public interface IHttpRequest : IRequest<IResult>
{
    
}