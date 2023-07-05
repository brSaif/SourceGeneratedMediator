using Mediator;
using MediatorSGSample.Requests;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MediatorSGSample;

public static class MinimalApiExtensions
{
    public static WebApplication MediatorGet<TRequest>(this WebApplication app, string template)
        where TRequest : IHttpRequest
    {
        app.MapGet(template, async (IMediator mediator, [AsParameters] TRequest request) 
            => await mediator.Send(request));
        return app;
    }
    
    public static WebApplication MediatorPost<TRequest>(this WebApplication app, string template)
        where TRequest : IHttpRequest
    {
        app.MapPost(template, async (IMediator mediator, [FromBody] TRequest request) 
            => await mediator.Send(request));
        return app;
    }
}